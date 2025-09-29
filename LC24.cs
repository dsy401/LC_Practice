namespace LeetcodeAlgo;

public class LC24
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        var dummy = new ListNode();
        var currentR = dummy;

        var current = head;
        int temp = -1;
        var i = 0;

        while (current != null)
        {
            if (i % 2 == 0)
            {
                temp = current.val;
            }
            else
            {
                currentR.next = new ListNode
                {
                    val = current.val,
                    next = new ListNode
                    {
                        val = temp
                    }
                };
                
                currentR = currentR.next.next;
                temp = -1;
            }
            current = current.next;
            i++;
        }

        if (temp != -1)
        {
            currentR.next = new ListNode
            {
                val = temp
            };
        }

        return dummy.next;
    }
}