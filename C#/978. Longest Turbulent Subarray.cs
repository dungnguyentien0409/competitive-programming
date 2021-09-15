public class Solution {
    public int MaxTurbulenceSize(int[] arr) {
        if (arr.Length == 0) return 0;
            
        int firstCase = 1, secondCase = 1, max = 1;
        
        for(var i = 0; i < arr.Length - 1; i++) {
            if (i % 2 != 0) {
                if (arr[i] > arr[i + 1]) {
                    firstCase++;
                    secondCase = 1;
                }
                else {
                    firstCase = 1;
                    
                    if (arr[i] < arr[i + 1]) {
                        secondCase++;
                    }
                }
            }   
            else {
                if (arr[i] < arr[i + 1]) {
                    firstCase++;
                    secondCase = 1;
                }
                else {
                    firstCase = 1;
                    
                    if (arr[i] > arr[i + 1]) {
                        secondCase++;
                    }
                }
            }
            
            max = Math.Max(max, Math.Max(firstCase, secondCase));
        }
        
        return max;
    }
}