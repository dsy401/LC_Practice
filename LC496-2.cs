namespace LeetcodeAlgo;

public class LC496_2
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var stack = new Stack<int>();

        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums2.Length; i++)
        {
            var currentItem = nums2[i];

            while (stack.Count != 0)
            {
                var top = stack.Pop();

                if (currentItem > top)
                {
                    dict.Add(top, currentItem);
                }
                else
                {
                    stack.Push(top);
                    break;
                }
            }
            
            stack.Push(nums2[i]);
        }

        var result = new int[nums1.Length];

        for (var i = 0; i < nums1.Length; i++)
        {
            if (!dict.ContainsKey(nums1[i]))
            {
                result[i] = -1;
            }
            else
            {
                result[i] = dict[nums1[i]];
            }
        }

        return result;
    }
}