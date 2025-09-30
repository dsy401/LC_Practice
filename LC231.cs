namespace LeetcodeAlgo;

public class LC231
{
    public bool IsPowerOfTwo(int n)
    {
        var low = 0;

        var high = n;

        while (low <= high)
        {
            var mid = low + (high - low) / 2;

            var current = Math.Pow(2, mid);

            if (current == n)
            {
                return true;
            }

            if (current > n)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return false;
    }
}