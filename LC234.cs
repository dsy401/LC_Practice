namespace LeetcodeAlgo;

public class LC234
{
    public bool IsPalindrome(ListNode head) {
        if (head == null)
        {
            return false;
        }

        if (head.next == null)
        {
            return true;
        }

        var list = new List<int>();
        
        var current = head;

        while (current != null)
        {
            list.Add(current.val);
            current = current.next;
        }

        var mid = list.Count / 2;

        var i = mid - 1;
        var j = list.Count % 2 == 0 ? mid : mid + 1;

        while (i >= 0 && j <= list.Count - 1)
        {
            if (list[i] != list[j])
            {
                return false;
            }
            
            i--;
            j++;
        }
        
        return true;
    }
}