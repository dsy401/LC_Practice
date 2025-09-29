namespace LeetcodeAlgo;

public class LC141
{
    public bool HasCycle(ListNode head)
    {
        
        if (head == null || head.next == null)
        {
            return false;
        }
        
        var turtle = head;

        var rabbit = head?.next;

        while (turtle != null && rabbit != null)
        {
            if (turtle == rabbit) return true;

            turtle = turtle?.next;

            rabbit = rabbit?.next?.next;
        }

        return false;
    }
}