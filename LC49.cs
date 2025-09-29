namespace LeetcodeAlgo;

public class LC49
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var result= new List<IList<string>>();

        var map = new Dictionary<string, List<int>>();

        var newStrs = strs.Select(str => new string(str.OrderBy(c => c).ToArray())).ToList();

        for (var i = 0; i < newStrs.Count; i++)
        {
            if (map.ContainsKey(newStrs[i]))
            {
                map[newStrs[i]].Add(i);
            }
            else
            {
                map[newStrs[i]] = new List<int> { i };
            }
        }

        foreach (var str in map.Keys)
        {
            var resultIndice = map[str];

            var subset = new List<string>();

            foreach (var index in resultIndice)
            {
                subset.Add(strs[index]);
            }
            
            result.Add(subset);
        }

        return result;
    }
}