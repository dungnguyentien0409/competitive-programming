/**
 * Link: https://leetcode.com/problems/fraction-to-recurring-decimal/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} numerator
 * @param {number} denominator
 * @return {string}
 */
function fractionToDecimal(numerator, denominator) {
    if (numerator == 0) return "0";
    
    var sign = (numerator > 0 ^ denominator > 0) ? "-" : "";
    
    numerator = Math.abs(numerator);
    denominator = Math.abs(denominator);
    var res = sign + Math.floor(numerator / denominator);
    var decimal = numerator % denominator;
    
    if (decimal == 0) return res;
    
    res += ".";
    var map = {}
    
    while (decimal != 0) {
        map[decimal] = res.length;
        
        decimal *= 10;
        res += Math.floor(decimal / denominator);
        decimal = decimal %  denominator;
        
        // that deciaml has been calculated already
        if (map[decimal] != undefined) {
            var len = map[decimal];
            res = res.substr(0, len) + "(" + res.substring(len, res.length) + ")";
            break;
        }
    }
    
    return res;
}