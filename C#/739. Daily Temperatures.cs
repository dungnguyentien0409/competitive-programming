/* 
 * Link: https://leetcode.com/problems/daily-temperatures/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] DailyTemperatures(int[] T) {
        var st = new Stack<int>();
        var map = new Dictionary<int, int>();
        var result = new int[T.Length];
        Array.Fill(result, -1);
        
        for(var i = 0; i < T.Length; i++) {
            var t = T[i];
            
            while(st.Count > 0 && T[st.Peek()] < t) {
                result[st.Pop()] = i;
            }
            
            st.Push(i);
        }
        
        for (var i = 0; i < T.Length; i++) {
            if (result[i] == -1) {
                result[i] = 0;
            }
            else {
                result[i] = result[i] - i;
            }
        }
        
        return result;
    }
}