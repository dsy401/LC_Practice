namespace LeetcodeAlgo;

public class LC128
{
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);

        var longest = 0;

        foreach (var num in set)
        {
            var currentResult = 1;
            var next = num + 1;
            
            if (!set.Contains(num - 1))
            {
                while (set.Contains(next))
                {
                    currentResult ++;
                    next++;
                }

                longest = Math.Max(currentResult, longest);
            }
        }

        return longest;
    }
}