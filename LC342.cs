namespace LeetcodeAlgo;

public class LC342
{
    public bool IsPowerOfFour(int n)
    {
        if (n == 1) return true;
        
        if (n % 4 != 0 || n <= 0) return false;

        var low = 1;
        var high = n / 4 + 1;

        while (low <= high)
        {
            var mid = low + (high - low) / 2;

            var current = Math.Pow(4, mid);
            
            if (current == n)
            {
                return true;
            }

            if (current < n)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return false;
    }
}