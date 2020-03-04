/**
 * Link: https://leetcode.com/problems/trapping-rain-water/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} height
 * @return {number}
 */
var trap = function(height) {
    var st = [];
    var i = 0;
    var s_area = 0;
    
    while(i < height.length) {
        var peek = st[st.length - 1];
        if (st.length == 0 || height[peek] >= height[i]) {
            st.push(i++);
        }
        else  {
            var middle = st.pop();
            
            if (st.length == 0) continue;
            
            var left = st[st.length - 1];
            var h = Math.min(height[i], height[left]) - height[middle];
            var w = i - left - 1;
            var area = h * w;
            s_area += area;
        }
    }
    
    console.log(i);
    
    return s_area;
};