/**
 * Link: https://leetcode.com/contest/biweekly-contest-10/problems/intersection-of-three-sorted-arrays/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} arr1
 * @param {number[]} arr2
 * @param {number[]} arr3
 * @return {number[]}
 */
var arraysIntersection = function(arr1, arr2, arr3) {
    if (arr1.length == 0 || arr2.length == 0 || arr3.length == 0) return [];
    
    var i1 = 0, i2 = 0, i3 = 0;
    var res = [];
    
    while(i1 < arr1.length && i2 < arr2.length && i3 < arr3.length) {
        // push intersection into the result
        if (arr1[i1] == arr2[i2] && arr1[i1] == arr3[i3] && arr2[i2] == arr3[i3]) {
            res.push(arr1[i1]);
            ++i1; ++i2; ++i3;
        }
        else {
            // find the start of intersection
            var max = Math.max(arr1[i1], arr2[i2], arr3[i3]);
            if (arr1[i1] < max) ++i1;
            else if (arr2[i2] < max) ++i2;
            else if (arr3[i3] < max) ++i3;
        }
    }
    
    return res;
};