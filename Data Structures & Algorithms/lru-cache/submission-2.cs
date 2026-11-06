
public class Node {
    public int val;
    public int key;
    public Node prev;
    public Node next;

    public Node(int _val = 0, int _key = 0, Node _prev = null, Node _next = null) {
        this.val = _val;
        this.key = _key;
        this.prev = _prev;
        this.next = _next;
    }
}

public class LRUCache {
    Dictionary<int, Node> dictionary;  // mục đích là để update giá trị
    Node dummy;                        // mục đích là sắp xếp thứ tự
    Node tail;
    int capacity;

    public LRUCache(int capacity) {
        dummy = new Node();
        tail = dummy;
        dictionary = new Dictionary<int, Node>();
        this.capacity = capacity;
    }

    public int Get(int key) {
        // kiểm tra có tồn tại hay không
        // nếu không tồn tại thì return -1
        if (!dictionary.ContainsKey(key))
            return -1;

        if (dictionary[key] == tail)
            return tail.val;

        // nếu tồn tại, thì lấy ra kết quả, và move kết quả ra đầu Node (MRU)
        Node node = dictionary[key];

        // xóa node hiện tại
        if (node.prev != null)
            node.prev.next = node.next;

        if (node.next != null)
            node.next.prev = node.prev;

        // move sang đầu
        tail.next = node;
        node.next = null;
        node.prev = tail;
        tail = node;

        return node.val;
    }

    public void Put(int key, int value) {
        // kiểm tra có tồn tại hay không
        // nếu tồn tại thì update key, move sang MRU
        Node node;
        if (dictionary.ContainsKey(key)) {
            // update lại giá trị trên dict
            node = dictionary[key];
            node.val = value;

            if (node == tail)
                return;

            // xóa node hiện tại, move sang đầu
            if (node.prev != null)
                node.prev.next = node.next;

            if (node.next != null)
                node.next.prev = node.prev;

            // move sang đầu
            tail.next = node;
            node.next = null;
            node.prev = tail;
            tail = node;

        } else {
            // thêm mới giá trị trên dict
            node = new Node(value, key);
            if (capacity > dictionary.Count) {
                dictionary.Add(key, node);
                // kiểm tra capacity, nếu capacity còn thì thêm vào MRU luôn
                // thêm vào MRU
                tail.next = node;
                node.prev = tail;
                tail = node;

            } else {
                // hết dung lượng, bỏ item LRU, thêm vào MRU
                Node lru = dummy.next;
                dummy.next = lru.next;

                if (dummy.next != null) {
                    dummy.next.prev = dummy;
                } else {
                    tail = dummy;
                }

                dictionary.Remove(lru.key);

                // thêm vào mru
                tail.next = node;
                node.prev = tail;
                tail = node;
                dictionary.Add(key, node);
            }
        }
    }
}
