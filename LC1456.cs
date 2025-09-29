namespace LeetcodeAlgo;

public class LC1456
{
    public int MaxVowels(string s, int k)
    {

        var vowels = new List<char>
        {
            'a', 'e', 'i', 'o', 'u'
        };
        
        var j = k - 1;

        var i = 0;

        var currentResult = 0;

        var max = 0;

        for (var start = i; start < j + 1; start++)
        {
            if (vowels.Contains(s[start]))
            {
                currentResult++;
                max++;
            }
        }

        while (j < s.Length - 1)
        {
            if (vowels.Contains(s[i]))
            {
                currentResult--;
            }
            
            i++;
            j++;

            if (vowels.Contains(s[j]))
            {
                currentResult++;
            }

            if (currentResult > max)
            {
                max = currentResult;
            }
        }

        return max;
    }
}