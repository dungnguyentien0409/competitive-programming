/*
 * Problem: merge sort
 * Author: Dung Nguyen Tien (Chris)
*/

function merge(leftArr, rightArr) {
  var sortedArr = [];
  while (leftArr.length && rightArr.length) {
    if (leftArr[0] <= rightArr[0]) sortedArr.push(leftArr.shift());
    else sortedArr.push(rightArr.shift());
  }
  while (leftArr.length)
    sortedArr.push(leftArr.shift());
  while (rightArr.length)
    sortedArr.push(rightArr.shift());
  return sortedArr;
}

function mergesort(arr) {
  if(arr.length >= 2) {
    var midpoint = Math.floor(arr.length / 2);
    var leftArr   = arr.slice(0, midpoint);
    var rightArr  = arr.slice(midpoint, arr.length);
    return merge(mergesort(leftArr), mergesort(rightArr));
  }
  return arr;
}
var arr = [1,2,3];
arr = mergesort(arr);
document.writeln("merge: " + JSON.stringify(arr)); 0,1,2,3,4