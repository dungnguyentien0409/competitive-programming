/**
 * Link: https://leetcode.com/problems/daily-temperatures/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} T
 * @return {number[]}
 */
var dailyTemperatures = function(T) {
    // monotonic stack
    var st = [];
    var ret = Array(T.length).fill(0);
    
    for (var i = 0; i < T.length; i++) {
        // if the array going down, keep pushing to stack the day
        // if i point to the higher T
        while(st.length > 0 && T[i] > T[st[0]]) {
            // pop the right after lower in stack
            var index = st.shift();
            // calculate the day
            ret[index] = i - index;
            // i still point to the higher
        }
        st.unshift(i);
    }
    
    return ret;
};
