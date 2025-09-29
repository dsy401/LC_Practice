namespace LeetcodeAlgo;

public class LC344
{
    public void ReverseString(char[] s)
    {
        var i = 0;
        var j = s.Length - 1;

        while (i < j)
        {
            (s[i], s[j]) = (s[j], s[i]);

            i++;
            j--;
        }
    }
}