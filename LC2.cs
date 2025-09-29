namespace LeetcodeAlgo;

public class LC2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var dummy = new ListNode();

        var current = dummy;
        
        var current1 = l1;
        var current2 = l2;

        var carrier = 0;

        while (current1 != null || current2 != null || carrier != 0)
        {
            current.next = new ListNode();
            
            var r1 = current1?.val ?? 0;
            var r2 = current2?.val ?? 0;

            var sum = r1 + r2 + carrier;

            carrier = sum < 10 ? 0 : 1;

            current.next.val = carrier == 1 ? sum - 10 : sum;

            current1 = current1?.next;
            current2 = current2?.next;

            current = current.next;
        }

        return dummy.next;
    }
}