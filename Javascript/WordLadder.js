/**
 * Problem: https://leetcode.com/problems/word-ladder/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} beginWord
 * @param {string} endWord
 * @param {string[]} wordList
 * @return {number}
 */
var ladderLength = function(beginWord, endWord, wordList) {
    var l = beginWord.length;
    var dict = {};
    
    // dict save the list of word having the same template newString which is only different one char at a place: like "*ot": ["hot", "lot"], "*og": ["dog", "log"]
    wordList.forEach(w => {
        for(var i = 0; i < l; i++) {
            var newString = w.substring(0, i) + "*" + w.substring(i + 1, l);
            
            if (dict[newString] != null) dict[newString].push(w);
            else dict[newString] = [w];
        }
    })
    
    // way to transform beginWord to endWord
    var queue = [];
    var visited = [];
    
    queue.unshift([beginWord, 1]);
    visited.push([beginWord, true]);
    
    // using bfs
    while(queue.length > 0) {
        var node = queue.pop();
        var word = node[0];
        var level = node[1];
        
        for(var i = 0 ; i < l; i++) {
            // list of Word that is different from beginWord one char
            var newString = word.substring(0, i) + "*" + word.substring(i + 1, l);
            var nextWords = dict[newString];
            
            if (nextWords != null) {
                for (var j = 0; j < nextWords.length; j++) {
                    var w = nextWords[j];
                    if(w == endWord) return level + 1;
                    
                    // mark visited and push to queue
                    if (!visited.some(s => s[0] == w)) {
                        queue.unshift([w, level + 1]);
                        visited.push([w, true]);
                    }
                }
            }
        }
    }
    return 0;
};