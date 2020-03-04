/**
 * Link: https://leetcode.com/problems/word-break-ii/
 * Author: Dung Nguyen Tien(Chris)
 * @param {string} s
 * @param {string[]} wordDict
 * @return {string[]}
 */
var wordBreak = function(s, wordDict, cache = []) {
    // if the string already have the result, return
    if(cache[s]) return cache[s];
    
    // the result for empty string
    if(s.length === 0){
        cache[s] = [];
        return [];
    }
    
    const result = [];
    for(let word of wordDict){
        const index = s.indexOf(word);
        // the the first word
        if(index === 0){
            // exclude the first word from the string
            const newStr = s.slice(word.length);
            // call to caculate the res of the string
            // values is all the segments making the rest string
            const values = wordBreak(newStr, wordDict, cache);
            // push all the segment including the first word
            if(values.length === 0 && newStr.length === 0)
                result.push(word);
            else{
                values.forEach(val => {
                    result.push(word + ' ' + val);
                });
            }
        }
    }
    
    cache[s] = result;
    return result;
};
