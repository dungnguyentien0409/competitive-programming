/*
 * Problem: Insertion sort
 * Author: Dung Nguyen Tien (Chris)
*/
function insertionSort(arr) {
  for (var i = 1; i < arr.length; i++) {
    var index = binarySearch(arr.slice(0, i), arr[i]);
    if (index != i) {
      var tmp = arr.splice(i, 1)[0];
      arr.splice(index, 0, tmp);
    }
  }
}

function binarySearch(arr, target) {
  var left = 0;
  var right = arr.length - 1;
  
  while(left < right) {
    var mid = Math.floor((left + right) / 2);
    if (arr[mid] < target) left = mid + 1;
    else right = mid;
  }
  
  if (arr[left] < target) return left + 1;
  return left;
}

var arr = [1,5,3,7,8,3, 0];
insertionSort(arr);
document.writeln(JSON.stringify(arr));