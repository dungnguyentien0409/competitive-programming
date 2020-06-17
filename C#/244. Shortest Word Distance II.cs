/*
 * Link: https://leetcode.com/problems/shortest-word-distance-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class WordDistance {
    Dictionary<string, List<int>> map;
    
    public WordDistance(string[] words) {
        map = new Dictionary<string, List<int>>();
        
        for(var i = 0; i < words.Length; i++) {
            var w = words[i];
            
            if (!map.ContainsKey(w)) map.Add(w, new List<int>());
            
            map[w].Add(i);
        }
    }
    
    public int Shortest(string word1, string word2) {
        var list1 = map[word1];
        var list2 = map[word2];
        var min = Int32.MaxValue;
        
        for (int i = 0, j = 0; i < list1.Count && j < list2.Count;) {
            min = Math.Min(min, Math.Abs(list1[i] - list2[j]));
            
            if (list1[i] < list2[j]) {
                i++;
            }
            else {
                j++;
            }
        }
        
        return min;
    }
}

/**
 * Your WordDistance object will be instantiated and called as such:
 * WordDistance obj = new WordDistance(words);
 * int param_1 = obj.Shortest(word1,word2);
 */