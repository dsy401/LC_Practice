namespace LeetcodeAlgo;

public class LC20
{
    public bool IsValid(string s)
    {
        if (s.Length <= 1)
        {
            return false;
        }

        var stack = new List<string>();

        for (var i = 0; i < s.Length; i++)
        {
            var currentP = s[i].ToString();

            if (stack.Count == 0)
            {
                stack.Add(currentP);
                continue;
            }

            var pop = stack[stack.Count - 1];

            stack.RemoveAt(stack.Count - 1);

            if ((pop == "(" && currentP == ")") ||
                (pop == "{" && currentP == "}") ||
                (pop == "[" && currentP == "]")
               )
            {
                continue;
            }

            stack.Add(pop);
            stack.Add(currentP);
        }

        return stack.Count == 0;
    }
}