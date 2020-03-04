/**
 * Link: https://leetcode.com/problems/largest-rectangle-in-histogram/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} heights
 * @return {number}
 */
var largestRectangleArea = function(heights) {
    var f_area = 0;
    var st = [];
    var i = 0;
    
    while(i < heights.length) {
        // if heights[i] more than the current heights in stack, push i to stack
        if (st.length == 0 || heights[i] > heights[st[0]]) {
            st.unshift(i++);
        }
        else {
            // if heights[i] < current[height], take out the current height to consider, i keep pointing to the height which is higher than current height in stack
            var h = heights[st.shift()];
            
            // the width is equal to i - indexOfCurrentHeigh - 1 (cause i keep pointing to the height which is higher than current height in stack)
            // if stack equal to 0 mean move to the element smallest in the stack, so the width is i (mean 0 to i - 1)
            var width = st.length == 0 ? i : i - st[0] - 1;
            var area = h * width;
            console.log(area)
            f_area = Math.max(area, f_area);
        }
    }
    
    while(st.length > 0) {
        var h = heights[st.shift()];
        var width = st.length == 0 ? i : i - st[0] - 1;
        var area = h * width;
        f_area = Math.max(area, f_area);
    }
    
    return f_area
};
