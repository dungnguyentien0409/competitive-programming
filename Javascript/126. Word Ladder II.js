/**
 * Link: https://leetcode.com/problems/word-ladder-ii/
 * Author: Dung Nguyen Tien (Chri)
 * @param {string} beginWord
 * @param {string} endWord
 * @param {string[]} wordList
 * @return {string[][]}
 */
var findLadders = function(beginWord, endWord, wordList) {
    // for each word, beginWord, endWord and word in wordList, find the word that different only one char
    const graph = bfs(beginWord, endWord, wordList);
    return dfs(graph, beginWord, endWord);
};

function dfs(graph, beginWord, endWord, selected=[beginWord], output = []) {
    // if can find the last element
    if (selected[selected.length - 1] == endWord) {
        output.push([...selected]);
        return;
    }
    
    for(const u of graph[beginWord]) {
        if (!selected.some(s => s == u)) {
            selected.push(u);
            dfs(graph, u, endWord, selected, output);
            selected.pop();
        }
    }
    
    return output;
}

function bfs(beginWord, endWord, wordList) {
    const graph = createGraph([beginWord, ...wordList]);
    const visited = new Set();
    const distance = {[beginWord] : 1};
    const queue = [beginWord];

    visited.add(beginWord);
    
    while(queue.length) {
        var w = queue.pop();
        for(const word of wordList) {
            if (isTransformedWord(w, word)) {
                if (distance[w] + 1 <= (distance[word] || Infinity)) {
                    // consider the word on next level: dot => dog => log (not dot => dog => dot)
                    distance[word] = distance[w] + 1;
                    graph[w].add(word);
                }
                if (!visited.has(word)) {
                    visited.add(word);
                    queue.unshift(word);
                }
            }
        }
    }
    return graph;
}

function createGraph(arr) {
    const graph = {};
    
    for(const w of arr) {
        graph[w] = new Set();
    }
    
    return graph;
}

function isTransformedWord(w1, w2) {
    if (w1 == w2) return false;
    
    var c = 0;
    for (var i = 0; i < w1.length; i++) {
        if (w1[i] != w2[i]) c++;
        
        if (c > 1) return false;
    }
    
    return true;
}