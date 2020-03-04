/**
 * Problem: https://leetcode.com/problems/letter-combinations-of-a-phone-number/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} digits
 * @return {string[]}
 */
var letterCombinations = function(digits) {
    if (digits.length == 0) return [];
    
    var letters = [];
    var length = digits.length;
    var res = [];
    
    // create array letters for only digits
    for (var i = 0; i < length; i++) {
        letters.push(number[digits[i]]);
    }
    
    backtrack(res, "", 0, letters, length);
    
    return res;
};

 const number = [
    [], [],
    ["a", "b", "c"],
    ["d", "e", "f"],
    ["g", "h", "i"],
    ["j", "k", "l"],
    ["m", "n", "o"],
    ["p", "q", "r", "s"],
    ["t", "u", "v"],
    ["w", "x", "y", "z"]
];

function backtrack(res, current, x, letters, length) {
    if (x >= letters.length && current.length == length) {
        res.push(current);
        return;
    }
    
    for (var i = x; i < letters.length; i++) {
        for (var j = 0; j < letters[x].length; j++) {
            current = current + letters[i][j];
            backtrack(res, current, i + 1, letters, length);
            current = current.slice(0, current.length - 1);
        }
    }
}