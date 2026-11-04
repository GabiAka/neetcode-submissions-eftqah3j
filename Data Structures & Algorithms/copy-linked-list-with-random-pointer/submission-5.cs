/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        // Original: A  → B  → C  → null
        // Copied:   A' → B' → C' → null

        if(head == null) return null;

        // combine lại
        Node current = head;

        while (current != null) {
            // sau step 1
            Node next = current.next;  // B

            Node alterCurrent = new Node(current.val);
            current.next = alterCurrent;  // A -> A'
            alterCurrent.next = next;     // A -> A' -> B -> C
            current = next;               // B
        }

        // xử lý biến random, next đã đổi chỗ
        current = head;  // A -> A' -> B -> B' -> C -> C' -> null
        while (current != null) {
            Node random = current.random;
            Node copied = current.next;
            copied.random = random?.next;
            current = current.next.next;
        }

        // xử lý separation lại
        current = head;                  // A -> A' -> B -> B' -> C -> C' -> null
        Node copiedCurrent = head.next;  // A' -> B -> B' -> C -> C' -> null
        while (current != null) {
            Node temp = current.next; //để khỏi mất A', A' -> B -> B' -> C -> C' -> null
            current.next = temp.next; // A -> B -> B' -> C -> C' -> null
            temp.next = current.next?.next; //A' -> B' -> C -> C' -> null

            current = current.next;
        }
        return copiedCurrent;
    }
}
