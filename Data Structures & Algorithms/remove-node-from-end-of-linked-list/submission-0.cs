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

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummy = new ListNode(0, head);
        ListNode slow = dummy;
        ListNode fast = dummy;

        for (int i = 0; i < n; i++) {
            fast = fast.next;
        }

        while (fast.next != null) {
            slow = slow.next;
            fast = fast.next;
            Console.WriteLine("---");
            Console.WriteLine(slow.val);
            Console.WriteLine(fast.val);
        }
        slow.next = slow.next.next;
        return dummy.next;
    }
}

//dummy,1,2,3,4
//n=2

//slow = dummy,1,2
//fast = 2,3,4
