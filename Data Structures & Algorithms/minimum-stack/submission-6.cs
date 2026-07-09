public class MinStack {
    public Stack<int> sobj;
    public Stack<int> minStack;
    public int min = 0;
    public MinStack() {
        sobj = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        if(sobj.Count() == 0){
            minStack.Push(val);
        }
        sobj.Push(val);
        if(minStack.Peek()>=val){
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        int val = sobj.Peek();
        sobj.Pop();
        if(minStack.Peek() == val){
            minStack.Pop();
        }
    }
    
    public int Top() {
        return sobj.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
