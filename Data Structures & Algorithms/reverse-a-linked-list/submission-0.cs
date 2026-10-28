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
    public ListNode ReverseList(ListNode head) {
        // khởi tạo điểm bắt đầu
        ListNode current = head;

        // node trước node ban đầu là null
        ListNode prev = null;

        // current = null, điểm cuối
        while (current != null) {
            // dòng bắt đầu, lưu giá trị next, tránh trường hợp current.next là prev trước thì vòng
            // lặp vô tận
            ListNode next = current.next;

            // reverse, nên đổi chiều next là trước, thay vì sau
            current.next = prev;

            // lưu lại giá trị prev là giá trị hiện tại
            prev = current;

            // dòng kết thúc
            current = next;
        }

        return prev;
    }
}
