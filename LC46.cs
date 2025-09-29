namespace LeetcodeAlgo;

public class LC46
{
    public IList<IList<int>> Permute(int[] nums)
    {
        var result = new List<IList<int>>();

        Action<IList<int>, int> func = null;

        func = (IList<int> subset, int depth) =>
        {
            if (depth == nums.Length)
            {
                result.Add(subset);
                return;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (subset.Contains(nums[i])) continue;

                var newSubset = new List<int>(subset);
                newSubset.Add(nums[i]);
                
                func(newSubset, depth + 1);
            }
        };

        func(new List<int>(), 0);


        return result;
    }
}