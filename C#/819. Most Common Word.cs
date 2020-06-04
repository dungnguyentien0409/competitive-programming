/*
 * Link: https://leetcode.com/problems/most-common-word/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        var arr = paragraph.ToLower()
            .Split(new char[] { '!', '?', '\'', ',', ';', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        var map = new Dictionary<string, int>();
        var set = new HashSet<string>(banned);
        int max = 0;
        string res = "";
        
        foreach(var word in arr) {
            if (!set.Contains(word)) {
                if (!map.ContainsKey(word)) map.Add(word, 0);
                
                map[word]++;
                Console.WriteLine(word + " " + map[word]);
                
                if (map[word] > max) {
                    max = map[word];
                    res = word;
                }
            }
        }
        
        return res;
    }
}