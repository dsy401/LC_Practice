namespace LeetcodeAlgo;

public class LC881
{
    public int NumRescueBoats(int[] people, int limit)
    {
        var peopleList = people.ToList();

        peopleList.Sort();

        var result = 0;

        var i = 0;

        var j = peopleList.Count - 1;

        while (i <= j)
        {
            if (peopleList[i] + peopleList[j] <= limit)
            {
                i++;
            }

            j--;

            result++;
        }

        return result;
    }
}