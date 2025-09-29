namespace LeetcodeAlgo;

//DP
public class LC62
{
    public int UniquePaths(int m, int n)
    {
        var dp = new int[m,n];
        dp[0, 0] = 1;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (i - 1 >= 0)
                {
                    dp[i, j] += dp[i - 1, j];
                }

                if (j - 1 >= 0)
                {
                    dp[i, j] += dp[i, j - 1];
                }
            }
        }

        return dp[m - 1, n - 1];
    }
}