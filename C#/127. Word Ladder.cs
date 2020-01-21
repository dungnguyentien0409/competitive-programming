/*
 * Link: https://leetcode.com/problems/word-ladder/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        var distance = BFS(beginWord, endWord, wordList);   
        
        return distance;
    }
    
    public int BFS(string begin, string end, IList<string> wordList) {
        if (!wordList.Contains(begin)) {
            wordList.Add(begin);
        }
        
        var distance = 0;
        var map = CreateMap(wordList);
        var visited = InitiateVisited(wordList);
        var queue = new Queue<string>();
        
        queue.Enqueue(begin);
        visited[begin] = true;
        while(queue.Count > 0) {
            var len = queue.Count;
            
            distance++;
            for(var i = 0; i < len; i++) {
                var word = queue.Dequeue();
                var nextWords = map[word];
                
                foreach(var nextWord in nextWords) {
                    if (nextWord == end) return distance + 1;
                    
                    if(!visited[nextWord]) {
                        visited[nextWord] = true;
                        queue.Enqueue(nextWord);
                    }
                }
            }
        }
        
        return 0;
    }
    
    public Dictionary<string, bool> InitiateVisited(IList<string> wordList) {
        var visited = new Dictionary<string, bool>();
        
        foreach(var w in wordList) {
            if (!visited.ContainsKey(w)) {
                visited.Add(w, false);
            }
        }
        
        return visited;
    }
    
    public Dictionary<string, List<string>> CreateMap(IList<string> wordList) {
        var map = new Dictionary<string, List<string>>();
        
        foreach(var w1 in wordList) {
            if (!map.ContainsKey(w1)) map.Add(w1, new List<string>());
            
            foreach(var w2 in wordList) {
                if (IsConnected(w1, w2)) {
                    map[w1].Add(w2);
                }
            }
        }
        
        return map;
    }
    
    public bool IsConnected(string w1, string w2) {
        var count = 0;
        
        for (var i = 0; i < w1.Length; i++) {
            if (w1[i] != w2[i]) {
                count++;
                
                if (count > 1) return false;
            }
        }
        
        return true;
    }
}