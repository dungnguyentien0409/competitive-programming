/**
 * Link: https://leetcode.com/problems/4sum/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @param {number} target
 * @return {number[][]}
 */
var fourSum = function(nums, target) {
    var set = new Set();
    var result = [];
    // sort the arry ascending
    nums.sort(function(a,b){return a-b;})
    
    for(var i = 0; i < nums.length - 3; i++) {
        for (var j = i + 1; j < nums.length - 2; j++) {
            var left = j + 1;
            var right = nums.length - 1;
            
            // i, j point to the first and second item
            // left, right point to the third and fourth item
            while(left < right) {
                var sum = nums[i] + nums[j] + nums[left] + nums[right];
                if (sum == target) {
                    var key = getKey([nums[i], nums[j], nums[left], nums[right]])
                    // check if that result existed
                    if (!set.has(key)) {
                        set.add(key);
                        result.push([nums[i], nums[j], nums[left], nums[right]]);
                    }
                    left++;
                    right--;
                }
                else if (sum > target) {
                    right--;
                }
                else {
                    left++;
                }
            }
        }
    }
    return result;
};

function getKey(a) {
    var res = '';
    for (var i = 0; i < a.length; i++) {
        res += a[i];
    }
    
    return res;
}