namespace LeetcodeAlgo;

public class LC692
{
    public IList<string> TopKFrequent(string[] words, int k)
    {
        var maxHeap = new PriorityQueue<string, object[]>(Comparer<object[]>.Create((x, y) =>
        {
            var p1 = (int) x[0];
            var p2 = (int) y[0];
            
            var pCheck = p2.CompareTo(p1);

            if (pCheck != 0)
            {
                return pCheck;
            }

            var s1 = (string)x[1];
            var s2 = (string)y[1];

            return string.Compare(s1, s2, StringComparison.Ordinal);
        }));

        var map = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (map.ContainsKey(word))
            {
                map[word]++;
            }
            else
            {
                map[word] = 1;
            }
        }

        foreach (var word in map.Keys)
        {
            maxHeap.Enqueue(word, new object[]{map[word], word});
        }

        var result = new List<string>();
        
        while (k > 0)
        {
            result.Add(maxHeap.Dequeue());
            k--;
        }

        return result;
    }
}