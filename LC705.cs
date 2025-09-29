namespace LeetcodeAlgo;

public class LC705
{
    public class MyHashSet
    {

        private List<int> _list;

        public MyHashSet()
        {
            _list = new List<int>();
        }
    
        public void Add(int key) {
            if (_list.Contains(key))
            {
                return;
            }
            
            _list.Add(key);
        }
    
        public void Remove(int key)
        {
            _list.Remove(key);
        }
    
        public bool Contains(int key)
        {
            return _list.Contains(key);
        }
    }
}