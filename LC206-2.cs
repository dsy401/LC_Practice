namespace LeetcodeAlgo;

public class LC206_2
{
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null)
        {
            return head;
        }

        var newHeader = ReverseList(head.next);

        head.next.next = head;
        head.next = null;

        return newHeader;
    }
}