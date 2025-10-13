/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = null;
        ListNode current = null;
        int carried = 0;
        while (l1 != null || l2 != null)
        {
            int firstValue = 0;
            int secondValue = 0;
            if (l1 != null)
            {
                firstValue = l1.val;
            }
            if (l2 != null)
            {
                secondValue = l2.val;
            }
            int digit = firstValue + secondValue + carried;
            carried = 0;
            if (digit > 9)
            {
                digit %= 10;
                carried = 1;
            }

            var node = new ListNode(digit);

            if (head == null)
            {
                head = node;
                current = node;
            }
            else
            {
                current.next = node;
                current = node;
            }

            if (l1 != null)
            {
                l1 = l1.next;
            }
            if (l2 != null)
            {
                l2 = l2.next;
            }
        }
        if (carried != 0)
        {
            current.next = new ListNode(carried);
        }

        return head;
    }
}