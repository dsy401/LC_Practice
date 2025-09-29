namespace LeetcodeAlgo;

public class LC217
{
    public bool ContainsDuplicate(int[] nums)
    {
        var dict = new Dictionary<int, int>();


        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict.Add(num, 1);
            }
        }

        foreach (var v in dict.Values)
        {
            if (v > 1)
            {
                return true;
            }
        }

        return false;
    }
}