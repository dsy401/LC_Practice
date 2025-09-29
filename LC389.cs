namespace LeetcodeAlgo;

public class LC389
{
    public char FindTheDifference(string s, string t)
    {
        var dict1 = new Dictionary<char, int>();

        for (var i = 0; i < t.Length; i++)
        {
            var key = t[i];
            if (dict1.ContainsKey(key))
            {
                dict1[key]++;
            }
            else
            {
                dict1.Add(key, 1);
            }
        }
        
        var dict2 = new Dictionary<char, int>();
        
        for (var i = 0; i < s.Length; i++)
        {
            var key = s[i];
            if (dict2.ContainsKey(key))
            {
                dict2[key]++;
            }
            else
            {
                dict2.Add(key, 1);
            }
        }

        var result = new char();

        foreach (var key in dict1.Keys)
        {
            if (
                (dict2.ContainsKey(key) && dict1[key] != dict2[key]) ||
                (!dict2.ContainsKey(key))
            )
            {
                result = key;
            }
        }

        return result;
    }
}