namespace LeetcodeAlgo;

public class LC57
{
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        if (intervals.Length == 0)
        {
            return new[] { newInterval };
        }

        var intervalList = intervals.ToList();

        var insertPos = -1;

        for (var i = 0; i < intervalList.Count; i++)
        {
            if (intervalList[i][0] <= newInterval[0])
            {
                insertPos = i;
            }
            else
            {
                break;
            }
        }
        
        intervalList.Insert(insertPos, newInterval);

        return null;
    }
}