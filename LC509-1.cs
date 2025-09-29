namespace LeetcodeAlgo;

public class LC509_1
{
    public int Fib(int n)
    {
        var dp = new int[n + 1];

        dp[0] = 0;
        dp[1] = 1;

        for (var i = 2; i < n + 1; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[^1];
    }
}