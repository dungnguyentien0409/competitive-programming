/*
 * Link: https://www.spoj.com/problems/BYTESM2/
 * Author: Dung Nguyen Tien (Chris)
*/
function findTheMaxStone(arr) {
  var cols = arr[0].length;
  var f_totalCoin = 0;
  
  for(var i = 0; i < cols; i++) {
    // start from the first row, each column
    var totalCoin = collectStone(arr, 0, i);
    // find the start having the max coin
    if (totalCoin > f_totalCoin) f_totalCoin = totalCoin;
  }  
  
  return f_totalCoin;
}

function collectStone(arr, x, y) {
  if (x < 0 || y < 0 || x >= arr.length || y >= arr[0].length) {
    return 0;
  }
  // expand to down or diagonally left, right, find the path having the max coin
  var bottom = collectStone(arr, x + 1, y);
  var diagonallyLeft = collectStone(arr, x + 1, y - 1);
  var diagonallyRight = collectStone(arr, x + 1, y + 1);
  var sum = arr[x][y] + Math.max(bottom, diagonallyLeft, diagonallyRight);

  return sum || 0;
}

var arr = [[3,1,7,4,2],
           [2,1,3,1,1],
           [1,2,2,1,8],
           [2,2,1,5,3],
           [2,1,4,4,4],
           [5,2,7,5,1]];

document.writeln(findTheMaxStone(arr));