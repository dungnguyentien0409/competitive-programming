/*
 * Problem: Selection sort
 * Author: Dung Nguyen Tien (Chris)
*/
function selectionSort(arr) {
  var imin = 0;
  for (var i = 0; i < arr.length - 1; i++) {
    imin = i;
    for (var j = i + 1; j < arr.length; j++) {
      if (arr[j] < arr[imin]) imin = j;
    }
    [arr[i], arr[imin]] = [arr[imin], arr[i]];
  }
}

var arr = [1,5,3,7,8,3, 0];
selectionSort(arr);
document.writeln(JSON.stringify(arr));