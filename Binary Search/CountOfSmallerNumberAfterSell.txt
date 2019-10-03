/**
 * Problem: https://leetcode.com/problems/count-of-smaller-numbers-after-self/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number[]}
 */
var countSmaller = function(nums) {
  let arr = [];
  // for each element from nums
  // take it and insert to array
  // its position in array is the number of element smaller than it
  for (let i = nums.length - 1; i >= 0; i--) {
    // using binary search to find the place to insert
    // nums[i] into array
    // index will point it right to the element smaller than nums[i]
    let index = findIndex(arr, nums[i]); 
    arr.splice(index, 0, nums[i]);
    nums[i] = index;
  }
  //console.log(findIndex([3,7,9], 10));
  
  return nums;
};

function findIndex(arr, target) {
    // if the array is empty
    // or the first element bigger than target
    // target should be insert at the first of array
    if (arr.length == 0 || arr[0] >= target) return 0;
    
    var left = 0;
    var right = arr.length - 1;
    
    while(left != right) {
        var mid = Math.floor((left  + right) / 2);
        
        // left try to point to the element equal to target
        if (arr[mid] < target) left = mid + 1;
        else right = mid;
    }
    
    // if the whole array is smaller than target
    if (arr[left] < target) return left + 1;
    return left;
}