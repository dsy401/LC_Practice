namespace LeetcodeAlgo;

public class LC90
{
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        var result = new List<IList<int>>()
        {
            new List<int>()
        };

        var map = new Dictionary<string, bool>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            var tempResult = new List<IList<int>>();

            for (var j = 0; j < result.Count; j++)
            {
                var rs = result[j];

                var ns = new List<int>(rs);
                
                ns.Add(num);
                
                ns.Sort();

                var mapKey = string.Join("_", ns);

                if (!map.ContainsKey(string.Join("_", ns)))
                {
                    tempResult.Add(ns);
                    map[mapKey] = true;
                }
            }
            
            result.AddRange(tempResult);
        }

        return result;
    }
}