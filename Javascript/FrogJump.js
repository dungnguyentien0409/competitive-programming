/**
 * Link: https://leetcode.com/problems/frog-jump/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} stones
 * @return {boolean}
 */
var canCross = function(stones) {
    var map = {};
    var trace = {};
    
    for (var i = 0; i < stones.length; i++) {
        map[stones[i]] = i;
    }
    
    for (pos of stones) {
        trace[pos] = [];    
    }
    
    return dfs(stones, 0, 0, map, trace);
    //return dfs(stones, 0, 0);
};


function dfs(stones, start, jump, map, trace) {
    // if the jum of current position is wrong then return false
    if (trace[stones[start]].indexOf(jump) > -1) return false; 
    if (start == stones.length - 1) return true;
    
    var canJump = false;
    var nextJumps = jump == 0 ? 
                [jump + 1] : [jump - 1, jump, jump + 1];
    
    for (var nextJump of nextJumps) {
        var nextStart = stones[start] + nextJump;
        var iNextStart = map[nextStart];
        
        if (iNextStart != undefined) {
            canJump = dfs(stones, iNextStart, nextJump, map, trace);
            if (canJump) return true;
            
            // save the wrong nextJump for each pos
            trace[nextStart].push(nextJump);
        }
    }
    
    return canJump;
}