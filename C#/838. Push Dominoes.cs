public class Solution {
    public string PushDominoes(string dominoes) {
        int len = dominoes.Length;
        int[] fallRight = new int[len], fallLeft = new int[len];
        
        int count = 0;
        for (var i = 0; i < len; i++) {
            fallRight[i] = count;
            if (dominoes[i] == 'R') {
                count = 1;
            }
            else if (dominoes[i] =='L'){
                count = 0;
            }
            else if (count > 0) count++;
        }
        
        count = 0;
        for (var i = len - 1; i >= 0; i--) {
            fallLeft[i] = count;
            if (dominoes[i] == 'L') {
                count = 1;
            }
            else if (dominoes[i] =='R'){
                count = 0;
            }
            else if (count > 0) count++;
        }
        
        var arr = dominoes.ToCharArray();
        for (var i = 0; i < len; i++) {
            if (arr[i] != '.') continue;
            
            if (fallRight[i] > fallLeft[i]) {
                arr[i] = fallLeft[i] == 0 ? 'R' : 'L';
            }
            else if (fallLeft[i] > fallRight[i]) {
                arr[i] = fallRight[i] == 0 ? 'L' : 'R';
            }
        }
        
        return new string(arr);
    }
}