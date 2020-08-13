/*
 * Link: https://leetcode.com/problems/iterator-for-combination/
 * Author: Dung Nguyen Tien (Chris)
*/

public class CombinationIterator {
    Queue<string> queue;
    
    public CombinationIterator(string characters, int combinationLength) {
        queue = new Queue<string>();
        
        backtrack(queue, new StringBuilder(), characters, 0, combinationLength);
    }
    
    public string Next() {
        return queue.Dequeue();
    }
    
    public bool HasNext() {
        return queue.Count > 0;
    }
    
    public void backtrack(Queue<string> queue, StringBuilder sb, string characters, int pos, int combinationLength) {
        if (sb.Length == combinationLength) {
            queue.Enqueue(sb.ToString());
            return;
        }
        
        for (var i = pos; i < characters.Length; i++) {
            sb.Append(characters[i]);
            
            backtrack(queue, sb, characters, i + 1, combinationLength);
            
            sb.Remove(sb.Length - 1, 1);
        }
    }
}

/**
 * Your CombinationIterator object will be instantiated and called as such:
 * CombinationIterator obj = new CombinationIterator(characters, combinationLength);
 * string param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */