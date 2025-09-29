namespace LeetcodeAlgo;

public class LC56
{
    public int[][] Merge(int[][] intervals) {

        if (intervals.Length == 0 || intervals.Length == 1)
        {
            return intervals;
        }

        var maxHeap = new PriorityQueue<int[], int>(Comparer<int>.Create((x, y) => x.CompareTo(y)));

        foreach (var interval in intervals)
        {
            maxHeap.Enqueue(interval, interval[0]);
        }

        var result = new List<int[]>();
        
        var current = maxHeap.Dequeue();

        while (maxHeap.Count != 0)
        {
            var next = maxHeap.Dequeue();

            if (current[1] >= next[0])
            {
                current = new[] { current[0], Math.Max(next[1], current[1]) };
            }
            else
            {
                result.Add(current);
                current = next;
            }
        }

        result.Add(current);

        return result.ToArray();
    }
}