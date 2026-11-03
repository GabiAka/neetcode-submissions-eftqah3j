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
        if (head == null) return null;
        Node current = head;
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        while (current != null) {
            Node currentNext = current.next;
            Node currentRandom = current.random;

            // kiểm tra map next tồn tại chưa
            if (currentNext != null && !map.ContainsKey(currentNext)  ) {
                Node deepCurrentNext = new Node(currentNext.val);
                map.Add(currentNext, deepCurrentNext);
            }

            // kiểm tra random next tồn tại chưa
            if (currentRandom != null && !map.ContainsKey(currentRandom) ) {
                Node deepCurrentRandom = new Node(currentRandom.val);
                map.Add(currentRandom, deepCurrentRandom);
            }

            // kiểm tra cặp hiện tại đã tồn tại chưa
            if (!map.ContainsKey(current) ) {
                Node deepCurrentMap = new Node(current.val);
                map.Add(current, deepCurrentMap);
            }

            //gán giá trị
            Node deepCurrent = map[current];
            deepCurrent.next = current.next != null ? map[current.next] : null;
            deepCurrent.random = current.random != null ?  map[current.random] : null;

            // loop qua item khắc
            current = current.next;
        }
        return map[head];
    }
}
