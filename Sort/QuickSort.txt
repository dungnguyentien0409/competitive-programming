/*
  *Problem: QuickSort
  *Author: Dung Nguyen Tien (Chris)
*/

function quickSort(arr, low, high) {
  if (low < high) {
    var pivot = partition(arr, low, high);
    
    quickSort(arr, low, pivot - 1);
    quickSort(arr, pivot + 1, high);
  }
}

// to move the pivot to its correct place 
// return its place
function partition(arr, low, high) {
  var pivot = arr[high];
  //i point to the lower than pivot element
  var i = low - 1;
  
  for(j = low; j < high; j++) {
    if (arr[j] < pivot) {
      i++;
      swap(arr, i, j);
    }
    // if (a[j] > pivot)
    // i point to the previous element
    // until find the lower than pivot
    // increase i to point to the higher and swap
  }
  swap(arr, i + 1, high);
  return i + 1;
}

function swap(arr, x, y) {
  if (x >= 0 && y >= 0) {
    var tmp = arr[x];
    arr[x] = arr[y];
    arr[y] = tmp;
  }
}

var arr = [1,4,7,8,8,9];
quickSort(arr, 0, arr.length - 1)
document.writeln(JSON.stringify(arr));