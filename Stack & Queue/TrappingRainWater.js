/**
 * Problem: https://leetcode.com/problems/trapping-rain-water/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} height
 * @return {number}
 */
var trap = function(height) {
    var s_area = 0;
    var st = []
    var i = 0
    
    while(i < height.length) {
        // keep pushing to stack the continously decreasing column
        // when find a column higher than previous column
        while(st.length > 0 && height[st[0]] < height[i]) {
            var top = st.shift();
            
            // when there is no trap at all
            if (st.length == 0) break;
            
            // the order of col: height[st[0]] - height[top] - height[i], by that way we can calculate the trapping
            var h = Math.min(height[i], height[st[0]]) - height[top];
            var area = h * (i - st[0] - 1);
            s_area += area
        }
        st.unshift(i++);
    }
    
    return s_area;
};