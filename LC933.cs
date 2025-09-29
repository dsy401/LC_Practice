namespace LeetcodeAlgo;

public class LC933
{
    public class RecentCounter
    {

        private List<int> _queue;
        
        public RecentCounter()
        {
            _queue = new List<int>();
        }
    
        public int Ping(int t) {
            if (_queue.Count == 0)
            {
                _queue.Insert(0, t);
                return 1;
            }

            while (true)
            {
                var endIndex = _queue.Count - 1;
                var end = _queue[endIndex];
                if (t - end > 3000)
                {
                    _queue.Remove(endIndex);
                }
                else
                {
                    _queue.Insert(0, t);
                    break;
                }
            }

            return _queue.Count;
        }
    }
}