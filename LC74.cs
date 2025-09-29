namespace LeetcodeAlgo;

public class LC74
{
    public bool SearchMatrix(int[][] matrix, int target) {
        if (matrix.Length == 0)
        {
            return false;
        }

        var low = 0;
        var high = matrix.Length * matrix[0].Length - 1;

        while (low <= high)
        {
            var mid = low + (high - low) / 2;

            var midIndex = GetIndex(mid, matrix[0].Length);

            if (matrix[midIndex[0]][midIndex[1]] == target)
            {
                return true;
            } else if (matrix[midIndex[0]][midIndex[1]] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return false;
    }

    private int[] GetIndex(int num, int colLength)
    {
        var row = num / colLength;

        var col = num % colLength;

        return new[] { row, col };
    }
}