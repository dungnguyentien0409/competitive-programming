/*
 * Problem: Bubble sort
 * Author: Dung Nguyen Tien (Chris)
*/
function bubbleSort(arr) {
  var noSwap = true;
  for (var len = arr.length; len > 0; len--) {
    noSwap = true
    for (var i = 0; i < len - 1; i++) {
      if (arr[i] > arr[i + 1]) {
        [arr[i], arr[i + 1]] = [arr[i + 1], arr[i]];
        noSwap = false;
      }
    }
    // if the array is sorted already
    if (noSwap) break;
  }
}

var arr = [1,5,3,7,8,3, 0];
bubbleSort(arr);
document.writeln(JSON.stringify(arr));