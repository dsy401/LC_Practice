namespace LeetcodeAlgo;

public class LC215
{
    public int FindKthLargest(int[] nums, int k) {
        var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

        foreach (var num in nums)
        {
            maxHeap.Enqueue(num, num);
        }

        int result = -1;
        
        while (k > 0)
        {
            result = maxHeap.Dequeue();
            k--;
        }

        return result;
    }
}