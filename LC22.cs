namespace LeetcodeAlgo;

public class LC22
{
    public IList<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();

        Action<int, int, string> func = null;
        func = (int left, int right, string s) =>
        {
            if (left == right && right == n)
            {
                result.Add(s);
                return;
            }

            if (right > left)
            {
                return;
            }

            if (left < n)
            {
                func(left + 1, right, $"{s}(");
            }

            if (left > right)
            {
                func(left, right + 1, $"{s})");
            }
        };

        func(0, 0, "");

        return result;
    }
}