/*
 * Link: https://leetcode.com/problems/letter-combinations-of-a-phone-number/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if (digits.Length == 0) return new List<string>();
        
        var map = CreateMap();
        var res = new List<string>();
        
        backtrack(res, "", map, digits, 0);
        
        return res;
    }
    
    public void backtrack(List<string> res, string current, Dictionary<char, char[]> map, string digits, int pos) {
        if (pos == digits.Length) {
            res.Add(current);
            return;
        }
        
        var chars = map[digits[pos]];
        
        foreach(var c in chars) {
            backtrack(res, current + c, map, digits, pos + 1);
        }
    }
    
    public Dictionary<char, char[]> CreateMap() {
        var map = new Dictionary<char, char[]>();
        
        map.Add('1', new char[] {});
        map.Add('2', new char[] { 'a', 'b', 'c' });
        map.Add('3', new char[] { 'd', 'e', 'f' });
        map.Add('4', new char[] { 'g', 'h', 'i' });
        map.Add('5', new char[] { 'j', 'k', 'l' });
        map.Add('6', new char[] { 'm', 'n', 'o' });
        map.Add('7', new char[] { 'p', 'q', 'r', 's' });
        map.Add('8', new char[] { 't', 'u', 'v' });
        map.Add('9', new char[] { 'w', 'x', 'y', 'z' });
        
        return map;
    }
}