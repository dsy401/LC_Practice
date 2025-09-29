namespace LeetcodeAlgo;


public class LC206
{
    public ListNode ReverseList(ListNode head)
    {
        var dummy = new ListNode
        {
            next = head
        };

        while (head != null && head.next != null)
        {
            var dummyNext = dummy.next;
            var headNext = head.next;

            dummy.next = headNext;
            head.next = headNext.next;
            headNext.next = dummyNext;
        }

        return dummy.next;
    }
}