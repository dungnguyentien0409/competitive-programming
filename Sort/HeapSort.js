/*
 * Problem: Heap sort
 * Author: Dung Nguyen Tien (Chris)
*/

function heapify(arr, i) {
  var left = 2 * i;
  var right = 2 * i + 1;
  var imax = i;
  
  if (left < arr.length && arr[left] > arr[imax]) imax = left;
  if (right < arr.length && arr[right] > arr[imax]) imax = right;
  
  if (imax != i) {
    if (imax == left) {
      [arr[i], arr[left]] = [arr[left], arr[i]];
      heapify(arr, left);
    }
    else {
      [arr[i], arr[right]] = [arr[right], arr[i]];
      heapify(arr, right);
    }
  }
}

function buildHeap(arr, index) {
  var n = Math.floor(index / 2);
  
  for (var i = n; i >= 0; i--) {
    heapify(arr, i);
  }
}

function heapSort(arr) {
  for (var i = arr.length - 1; i >= 0; i--) {
    buildHeap(arr, i);
    document.writeln(arr[0]);
    [arr[0], arr[i]] = [arr[i], arr[0]];
  }
}

var arr = [1,5,3,8,9,0];
heapSort(arr);
document.writeln(JSON.stringify(arr));