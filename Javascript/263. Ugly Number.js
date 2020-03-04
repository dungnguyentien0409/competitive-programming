/**
 * Link: https://leetcode.com/problems/ugly-number/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} num
 * @return {boolean}
 */
var isUgly = function(num) {
    if (num == 1) return true; 
    
    // i = 2, 3, 5. 4 consider in case of 2
    for (var i = 2; i <= 5; i++){
        while(num >= i && num % i == 0) {
            num = num / i;
            if (num == 1) return true;
        }
    }
    return false;
};