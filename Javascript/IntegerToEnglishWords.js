/**
 * Link: https://leetcode.com/problems/integer-to-english-words/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} num
 * @return {string}
 */
const LESS_THAN_20 = ["", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"];
    const TENS = ["", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"];
const THOUSANDS = ["", "Thousand", "Million", "Billion"];

var numberToWords = function(num) {
    if (num == 0) return "Zero";
    
    var i = 0;
    var words = "";
    
    while (num > 0) {
        // we translate group of 3 digit
        // the first 3 end with nothing, the second three end with thousand, the third three end with million, the fourth three end with billion
        if (num % 1000 != 0) words = helper(num % 1000)
                                  + THOUSANDS[i] + " " + words;
        
        // exclude the last 3, move i to the next unit
        num = Math.floor(num / 1000);
        i++;
    }
    
    return words.trim();
};

function helper(n) {
    if (n == 0) 
        return "";
    // if less than 20: return it
    else if (n < 20) 
        return LESS_THAN_20[n] + " ";
    // if less then 100 and bigger then 19, return the first digit and recurse the rest
    else if (n < 100) 
        return TENS[Math.floor(n / 10)] + " " + helper(n % 10);
    // if less then 1000 and bigger than 99, return the first digit with hundred and recurse the rest
    else 
        return LESS_THAN_20[Math.floor(n / 100)] + " Hundred " + helper(n % 100);
}