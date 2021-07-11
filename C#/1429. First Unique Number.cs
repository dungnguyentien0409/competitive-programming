public class FirstUnique {
    Queue<int> q;
    Dictionary<int, bool> map;
    public FirstUnique(int[] nums) {
        q = new Queue<int>();
        map = new Dictionary<int, bool>();
        
        foreach(var n in nums) {
            Add(n);
        }
    }
    
    public int ShowFirstUnique() {
        while(q.Count > 0 && !map[q.Peek()]) {
            q.Dequeue();
        }
        
        return q.Count > 0 ? q.Peek() : -1;
    }
    
    public void Add(int value) {
        if (map.ContainsKey(value)) {
            map[value] = false;
            return;
        }
        
        map[value] = true;
        q.Enqueue(value);
    }
}

/**
 * Your FirstUnique object will be instantiated and called as such:
 * FirstUnique obj = new FirstUnique(nums);
 * int param_1 = obj.ShowFirstUnique();
 * obj.Add(value);
 */