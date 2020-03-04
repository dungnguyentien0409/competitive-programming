/**
 * Link: https://leetcode.com/problems/powx-n/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} x
 * @param {number} n
 * @return {number}
 */
var myPow = function(x, n) {
    if(n == 0) return 1;
    if(n < 0){
        n = -n;
        x = 1 / x;
    }
    
    return (n % 2 == 0) ? 
            myPow(x * x, Math.floor(n / 2)) : x * myPow(x * x, Math.floor(n / 2));
};