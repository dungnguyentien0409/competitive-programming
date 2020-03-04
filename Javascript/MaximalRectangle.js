/**
 * Problem: https://leetcode.com/problems/maximal-rectangle/
 * Author: Dung Nguyen Tien (Chris)
 * @param {character[][]} matrix
 * @return {number}
 */
var maximalRectangle = function(matrix) {
    if (matrix == null || matrix.length == 0 || matrix[0].length == 0) return 0;
    
    var nCol = matrix[0].length;
    var nRow = matrix.length;
    var h = Array(nCol).fill(0);
    var max = 0;
    
    // for each row of i, we calculate again the height array which is the height of column consider until i. than implement the largest rectangle in histogram
    // reference: https://github.com/dungnguyentien0409/competitive-programming/blob/master/Stack%20%26%20Queue/LargestRectangleinHistogram.js
    for (var i = 0; i < nRow; i++) {
        for (var j = 0; j < nCol; j++) {
            if (matrix[i][j] == '1') h[j]++;
            else h[j] = 0;
        }
        // find max for every height array
        max = Math.max(max, largestRectangle(h));
    }
    
    return max;
};
        
// the largest rectangle in histogram
// reference: https://github.com/dungnguyentien0409/competitive-programming/blob/master/Stack%20%26%20Queue/LargestRectangleinHistogram.js
var largestRectangle = function(heights) {
    if (heights.length == 0) return 0;
    
    var i = 0;
    var st = [];
    var f_area = 0;
    
    while(i < heights.length) {
        if (st.length == 0 || heights[st[0]] < heights[i]) {
            st.unshift(i++);
        }
        else {
            var h = heights[st.shift()];
            var area = h * (st.length == 0 ? i : i - st[0] - 1);
            f_area = Math.max(f_area, area);
        }
    }
    
    while(st.length > 0) {
        var h = heights[st.shift()];
        var area = h * (st.length == 0 ? i : i - st[0] - 1);
        f_area = Math.max(f_area, area);
    }
    
    return f_area;
}