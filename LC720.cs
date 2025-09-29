namespace LeetcodeAlgo;

public class LC720
{
    class Trie
    {
        public Dictionary<char, Trie> Children = new();
        public string Value = "";
        public bool HasEnd = false;
    }
    
    public string LongestWord(string[] words)
    {
        var result = "";
        
        if (words.Length == 0) return result;

        var root = new Trie();

        Trie current = null;

        foreach (var word in words)
        {
            current = root;

            foreach (var c in word)
            {
                if (!current.Children.ContainsKey(c))
                {
                    current.Children.Add(c, new Trie());
                }

                current = current.Children[c];
            }

            current.Value = word;
            current.HasEnd = true;
        }

        foreach (var word in words)
        {
            current = root;

            var needChange = true;
            
            if (result.Length < word.Length || (result.Length == word.Length && string.Compare(word, result, StringComparison.Ordinal) < 0))
            {
                foreach (var c in word)
                {
                    current = current.Children[c];

                    if (!current.HasEnd)
                    {
                        needChange = false;
                        break;
                    }
                }
                
                if (needChange)
                {
                    result = word;
                }
            }
        }

        return result;
    }
}