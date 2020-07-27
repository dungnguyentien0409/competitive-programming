/*
 * Link: https://leetcode.com/problems/add-binary/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string AddBinary(string a, string b) {
        int i1 = a.Length - 1, i2 = b.Length - 1;
        int carry = 0;
        var res = new StringBuilder();
        
        while(i1 >= 0 || i2 >= 0) {
            int sum = carry;
            
            if (i1 >= 0) sum += a[i1--] - '0';
            if (i2 >= 0) sum += b[i2--] - '0';
            
            res.Insert(0, sum % 2);
            carry = sum / 2;
        }
        
        if (carry == 1) res.Insert(0, carry);
        
        return res.ToString();
    }
}