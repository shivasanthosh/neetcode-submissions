public class MinStack {

    private Stack<int> s ;
    private Stack<int> ms ;

    public MinStack() {
        this.s = new Stack<int>();
        this.ms = new Stack<int>();
    }
    
    public void Push(int val) {
        s.Push(val);
        int currentMin;
        if(ms.Count> 0)
        {
            currentMin = Math.Min(val,ms.Peek());
        }
        else
        {
            currentMin = val;
        }
         ms.Push(currentMin);
    }
    
    public void Pop() {
        s.Pop();
        ms.Pop();
    }
    
    public int Top() {
        return s.Peek();
    }
    
    public int GetMin() {
        return ms.Peek();
    }
}
