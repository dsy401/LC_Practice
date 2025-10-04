namespace LeetcodeAlgo;

public class LC989
{
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        var result = new LinkedList<int>();

        var carrier = 0;
        
        for (var i = num.Length - 1; i >= 0; i--)
        {
            var reminder = k % 10;
            k = k / 10;

            var total = reminder + num[i] + carrier;

            carrier = total / 10;
            result.AddFirst( total % 10);
        }

        k = k + carrier;

        while (k != 0)
        {
            result.AddFirst( k % 10);
            k = k / 10;
        }

        return result.ToList();
    }
}