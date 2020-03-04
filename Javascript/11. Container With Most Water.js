/**
 * Link: https://leetcode.com/problems/container-with-most-water/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} height
 * @return {number}
 */
var maxArea = function(height) {
    if (height.length < 1) {
        return;
    }
    
    var left = 0;
    var right = height.length - 1;
    var max = 0;
    
    while(left < right) {
        // for each left right, calculate the water it can contain
        max = Math.max(max, calculateArea(height, left, right));
        
        // try to find a higher height for left
        if (height[left] < height[right]) {
            left++;
        }
        // try to find a higher height for right
        else {
            right--;
        }
    }
    
    return max;
};

var calculateArea = function(height, x1, x2) {
    if (x1 > height.length - 1 || x2 > height.length - 1) {
        return;
    }
    
    var y1 = height[x1];
    var y2 = height[x2];
    var ymin = y1 < y2 ? y1 : y2;
    
    return ((x2 - x1) * ymin);
}