public class MinStack {
    public Stack<int> stacks { get; set; }
    public Stack<int> minStacks { get; set; }

    public MinStack() {
        stacks = new Stack<int>();
        minStacks = new Stack<int>();
    }

    public void Push(int val) {
        if (minStacks.Count != 0) {
            var min = minStacks.Peek();
            if(val < min) min = val;
            stacks.Push(val);
            minStacks.Push(min);
        }else{
            stacks.Push(val);
            minStacks.Push(val);
        }
    }

    public void Pop() {
        stacks.Pop();
        minStacks.Pop();
    }

    public int Top() {
        var top = stacks.Peek();
        return top;
    }

    public int GetMin() {
        var min = minStacks.Peek();
        return min;
    }
}
