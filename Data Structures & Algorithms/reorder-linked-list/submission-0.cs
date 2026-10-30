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
    public void ReorderList(ListNode head) {
        // step 1: tìm middle
        ListNode slow = head, fast = head;
        while (fast.next != null && fast.next.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        // step 2: tách ra thành 2 list (nữa đầu và nữa sau)
        ListNode second = slow.next;
        slow.next = null;
        ListNode first = head;

        // step 3: tiến hành reverse second
        ListNode prev = null;
        while (second != null) {
            // nhảy tới node tiếp theo
            ListNode next = second.next;

            // link lại giá trị
            second.next = prev;

            // update prev bằng giá trị hiện tại
            prev = second;

            // nhảy tới node tiếp theo
            second = next;
        }

        // step 4: merge xen kẽ\
        second = prev;
        while (second != null) {
            ListNode temp1 = first.next;
            ListNode temp2 = second.next;

            //nối first vào second
            first.next = second;

            //nối second vào temp 1;
            second.next = temp1;

            first = temp1;
            second = temp2;

        }
    }
}
