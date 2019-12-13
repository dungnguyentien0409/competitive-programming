/**
 * Problem: https://leetcode.com/problems/count-primes/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} n
 * @return {number}
 */
var countPrimes = function(n) {
    var isPrime = Array(n).fill(true);
    var count = 0;
    
    for (var i = 2; i < n; i++) {
        if (isPrime[i]) count++;
        
        for (var j = 2; i * j < n; j++) isPrime[i * j] = false;
    }
    
    return count;
};