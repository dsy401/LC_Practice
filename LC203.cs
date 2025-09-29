namespace LeetcodeAlgo;


  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }

public class LC203
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        var node = new ListNode
        {
            next = head
        };

        var prev = node;


        while (head != null)
        {
            if (head.val == val)
            {
                prev.next = head.next;
            }
            else
            {
                prev = head;
            }

            head = head.next;
        }

        return node.next;
    }
}