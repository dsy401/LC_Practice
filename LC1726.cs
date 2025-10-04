namespace LeetcodeAlgo;

public class LC1726
{
    public int TupleSameProduct(int[] nums)
    {
        var map = new Dictionary<int, IList<int[]>>();
        
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                var product = nums[i] * nums[j];

                if (map.ContainsKey(product))
                {
                    map[product].Add(new int[] {nums[i],nums[j]});
                }
                else
                {
                    map[product] = new List<int[]> { new int[] { nums[i], nums[j] } };
                }
            }
        }

        var result = 0;

        foreach (var product in map.Keys)
        {
            var tuples = map[product];

            var count = tuples.Count;

            if (count > 1)
            {
                result += count * (count - 1) / 2 * 8;
            }
        }

        return result;
    }
}