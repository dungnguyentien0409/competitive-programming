/**
 * Link: https://leetcode.com/problems/most-common-word/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} paragraph
 * @param {string[]} banned
 * @return {string}
 */
var mostCommonWord = function(paragraph, banned) {
    var arr = paragraph.split(/[\.,?!:;`'\s]+/);
    console.log(arr);
    var dict = {};
    var occur = 0;
    var commonWord = "";
    
    for(var w of arr) {
        w = w.toLowerCase();
        if (banned.indexOf(w) == -1) {
            dict[w] = (dict[w] || 0) + 1;
            
            if (dict[w] > occur) {
                occur = dict[w];
                commonWord = w;
            }
        }    
    }
    
    return commonWord;
};