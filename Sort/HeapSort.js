/*
 * Problem: Heap sort
 * Author: Dung Nguyen Tien (Chris)
*/

function heapify(arr, n, i) {
  var left = 2 * i;
  var right = 2 * i + 1;
  var imax = i;
  
  if (left < n && arr[left] > arr[imax]) imax = left;
  if (right < n && arr[right] > arr[imax]) imax = right;
  
  if (imax != i) {
    if (imax == left) {
      [arr[i], arr[left]] = [arr[left], arr[i]];
      heapify(arr, n, left);
    }
    else {
      [arr[i], arr[right]] = [arr[right], arr[i]];
      heapify(arr, n, right);
    }
  }
}

function buildHeap(arr) {
  var n = Math.floor(arr.length / 2) - 1;
  
  for (var i = n; i >= 0; i--) {
    heapify(arr, arr.length, i);
  }
}

function heapSort(arr) {
  buildHeap(arr);
  for (var i = arr.length - 1; i >= 0; i--) {
    [arr[0], arr[i]] = [arr[i], arr[0]];
    heapify(arr, i, 0);
  }
}

var arr = [1,5,3,8,9,0];
heapSort(arr);
document.writeln(JSON.stringify(arr));