/*
 * Link: https://www.geeksforgeeks.org/given-two-sorted-arrays-number-x-find-pair-whose-sum-closest-x/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} matrix
 * @return {number[][]}
*/

function findCloset(a, b, target) {
  // sort 2 array
  a.sort(function(a,b) {return a - b;});
  b.sort(function(a,b) {return a - b;});
  
  // start by the biggest a, smallest b
  var x = a.length - 1;
  var y = 0;
  var res = [];
  var diff = Number.MAX_SAFE_INTEGER;
  
  while(x >= 0 && y < b.length) {
    sum = a[x] + b[y];
    if (Math.abs(sum - target) <= diff) {
      if (Math.abs(sum -target) < diff) {
        // update the smallest diff
        // if find the smaller, remove all previous pairs
        diff = Math.abs(sum - target);
        res = [];
      }
      res.push([a[x], b[y]]);
    }
    
    // if the sum is bigger than target, decrease i to down the sum
    if (sum > target) --x;
    // if the sum is smaller than target, increase i to up the sum
    else if (sum < target) ++y;
  }
  return res;
}

var ar1 = [1, 4, 5, 7];
var ar2 = [10, 40, 30, 20];
var x = 32;  
var res = findCloset(ar1, ar2, x);
document.writeln(JSON.stringify(res));