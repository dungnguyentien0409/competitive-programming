/*
 * Link: https://leetcode.com/problems/iterator-for-combination/
 * Author: Dung Nguyen Tien (Chris)
*/

public class CombinationIterator {
    Stack<char> st;
    Dictionary<char, int> map;
    string res, str;
    int len;
    
    public CombinationIterator(string characters, int combinationLength) {
        st = new Stack<char>();
        map = new Dictionary<char, int>();
        res = "";
        str = characters;
        len = combinationLength;
        
        for (var i = 0; i < characters.Length; i++) {
            var c = characters[i];
            
            map.Add(c, i);
            
            if (res.Length < len) {
                st.Push(c);
                res += c;
            }
        }
    }
    
    public string Next() {
        var current = res;
        var index = str.Length - 1;
        
        while(st.Count > 0 && map[st.Peek()] == index) {
            st.Pop();
            index--;
            res = res.Substring(0, res.Length - 1);
        }
        
        if (st.Count == 0) return current;
        
        index = map[st.Pop()];
        res = res.Substring(0, res.Length - 1);
        
        while(res.Length < len) {
            res += str[++index];
            st.Push(str[index]);
        }
        
        
        return current;
    }
    
    public bool HasNext() {
        return st.Count > 0;
    }
}

/**
 * Your CombinationIterator object will be instantiated and called as such:
 * CombinationIterator obj = new CombinationIterator(characters, combinationLength);
 * string param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */