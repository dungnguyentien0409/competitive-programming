/*
 * Problem: Radix sort
 * Author: Dung Nguyen Tien (Chris)
*/
function radixSort(arr) {
  const max = getMax(arr);
  
  for (let i = 0; i < max; i++) {
    let buckets = Array(10).fill().map(() => []);
    for (let j = 0; j < arr.length; j++) {
      buckets[getDigit(arr[j], i)].push(arr[j]);
    }
    arr = [].concat(...buckets);
  }
  return arr;
}

function getMax(arr) {
  let max = 0;
  for(var num of arr) {
    if (max < num.toString().length) {
      max = num.toString().length;
    }
  }
  return max;
}

function getDigit(num, i) {
  return Math.floor(num / Math.pow(10, i)) % 10;
}

var arr = [123,5,3,85,1024,908];
arr = radixSort(arr);
document.writeln(JSON.stringify(arr));