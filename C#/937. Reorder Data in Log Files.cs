/*
 * Link: https://leetcode.com/problems/reorder-data-in-log-files/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string[] ReorderLogFiles(string[] logs) {
        var letters = new List<string>();
        var digits = new List<string>();
        
        foreach(var log in logs) {
            if (IsDigit(log)) {
                digits.Add(log);
            }
            else {
                letters.Add(log);
            }
        }
        
        SortLetter(letters);
        
        letters.AddRange(digits);
        return letters.ToArray();
    }
    
    public void SortLetter(List<string> letters) {
        letters.Sort(delegate(string a, string b) {
            var arr1 = a.Split(" ", 2);
            var arr2 = b.Split(" ", 2);
            
            if (arr1[1].CompareTo(arr2[1]) == 0) {
                return arr1[0].CompareTo(arr2[0]);
            }
            return arr1[1].CompareTo(arr2[1]);
        });
    }
    
    public bool IsDigit(string log) {
        var separator = " ";
        var arr = log.Split(separator, 2);
        
        int n;
        return int.TryParse(arr[1][0].ToString(), out n);
    }
}