namespace LeetcodeAlgo;

public class LC21
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var current1 = list1;
        var current2 = list2;

        var dummy = new ListNode();

        var current = dummy;

        while (current1 != null || current2 != null)
        {
            if (current1 != null && current2 != null)
            {
                var val1 = current1.val;
                var val2 = current2.val;

                if (val1 < val2)
                {
                    current.next = new ListNode
                    {
                        val = val1
                    };

                    current1 = current1?.next;
                }
                else
                {
                    current.next = new ListNode
                    {
                        val = val2
                    };
                    
                    current2 = current2?.next;
                }
                
                current = current.next;
            } else if (current1 != null && current2 == null)
            {
                current.next = new ListNode
                {
                    val = current1.val
                };

                current1 = current1?.next;
                current = current.next;
            } else if (current2 != null && current1 == null)
            {
                current.next = new ListNode
                {
                    val = current2.val
                };

                current2 = current2?.next;
                current = current.next;
            }
        }

        return dummy.next;
    }
}