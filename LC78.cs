namespace LeetcodeAlgo;

// 拓展发 叠加
public class LC78
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        var result = new List<IList<int>>()
        {
            new List<int>()
        };

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            var tempResult = new List<IList<int>>();

            for (var j = 0; j < result.Count; j++)
            {
                var rs = result[j];

                var ns = new List<int>(rs);
                
                ns.Add(num);
                
                tempResult.Add(ns);
            }
            
            result.AddRange(tempResult);
        }

        return result;
    }
}