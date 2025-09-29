namespace LeetcodeAlgo;

public class LC496
{
    class Stack
    {
        private List<int> _list;
        
        public Stack(int[] nums)
        {
            _list = new List<int>(nums);
        }

        public Stack()
        {
            _list = new List<int>();
        }

        public int Pop()
        {
            var item = _list[_list.Count - 1];
            
            _list.RemoveAt(_list.Count - 1);

            return item;
        }

        public void Push(int num)
        {
            _list.Add(num);
        }

        public bool IsEmpty()
        {
            return _list.Count == 0;
        }
    }
    
    
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var result = new int[nums1.Length];

        for (var i = 0; i < nums1.Length; i++)
        {
            var stack = new Stack(nums2);
            
            var currentNum = nums1[i];  

            var max = -1;
            
            while (!stack.IsEmpty())
            {
                var popItem = stack.Pop();

                if (popItem > currentNum)
                {
                    max = popItem;
                } else if (popItem == currentNum)
                {
                    break;
                }
            }

            result[i] = max;
        }

        return result;
    }
}