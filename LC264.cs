namespace LeetcodeAlgo;

public class LC264
{
    public int NthUglyNumber(int n)
    {
        var hashSet = new HashSet<long>();
        hashSet.Add(1);
        
        var heap = new PriorityQueue<long, long>();
        heap.Enqueue(1,1);
        
        var factors = new List<int> { 2, 3, 5 };

        long result = 1;

        for (var i = 0; i < n; i++)
        {
            result = heap.Dequeue();

            foreach (var factor in factors)
            {
                var item = result * factor;

                if (!hashSet.Contains(item))
                {
                    hashSet.Add(item);
                    heap.Enqueue(item, item);
                }
            }
        }

        return (int) result;
    }
}