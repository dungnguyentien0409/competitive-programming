/**
 * Problem: https://leetcode.com/problems/expressive-words/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} S
 * @param {string[]} words
 * @return {number}
 */
var expressiveWords = function(S, words) {
    var map1 = createMap(S);
    var map2 = [];
    var res = [];
    
    for (var w of words) {
        map2 = createMap(w);
        
        if (compareMap(map1, map2)) {
            res.push(map2);
        }
    }
    
    return res.length;
};

function compareMap(map1, map2) {
    if (map1.length != map2.length) return false;
    
    var n = map1.length;
    for (var i = 0; i < n; i++) {
        var c1 = map1[i];
        var c2 = map2[i];
        
        
        if (c1[0] != c2[0] //case different
            || c1[1] < c2[1] // case that cannot add more
            || c1[1] != c2[1] && c1[1] < 3) // if it is duplicated and the group size is less than 3
            return false;
    }
    
    return true;
}

function createMap(S) {
    var map = [];
    
    var i1 = 0;
    map.push([S[0], 1]);
    
    for(var i = 1; i < S.length; i++) {
        var previousChar = map[i1][0];
        
        if (S[i] == previousChar) { 
            map[i1][1]++;
        }
        else {
            map.push([S[i], 1]);
            i1++;
        }
    }
    
    return map;
}