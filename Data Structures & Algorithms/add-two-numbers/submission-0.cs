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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode();
        ListNode tail = dummy;
        int carry = 0;

        // l1 : 9, 12, 15
        // l2 : 18, 20, 30

        while (l1 != null || l2 != null || carry > 0) {
            int val1 = l1 != null ? l1.val : 0;
            int val2 = l2 != null ? l2.val : 0;

            int sum = val1 + val2 + carry;  // 4

            int newSum = sum % 10;    // 4
            carry = sum / 10;  // 0

            Console.WriteLine("---");
            Console.WriteLine(newSum);
            Console.WriteLine(carry);
            tail.next = new ListNode(newSum);

            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;
            tail = tail.next;
        }

        return dummy.next;
    }
}
