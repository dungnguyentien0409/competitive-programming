/**
 * Link: https://leetcode.com/problems/remove-invalid-parentheses/submissions/
 * Author: Dung Nguyen Tien (Chirs)
 * @param {string} s
 * @return {string[]}
 */
function removeInvalidParentheses(s) {
    var queue = new Set([s]);
    
    while(queue.size > 0) {
        var reduceOnes = new Set();

        for (var str of queue) {
            //find the longest parenthese after remove one
            if (validParentheses(str)) {
                return [...queue].filter(f => validParentheses(f));
            }
            
            // reduce one element
            for (var i = 0; i < str.length; i++) {
                var newStr = str.substring(0, i) + str.substring(i + 1);
                reduceOnes.add(newStr);
            }
        }
        
        queue = reduceOnes;
    }
    
    return [''];
}

function validParentheses(s) {
    var count  = 0;
    
    for (var i = 0; i < s.length; i++) {
        if (s[i] == "(") count++;
        else if (s[i] == ")") {
            if (count == 0) return false;
            
            count--;
        }
    }
    
    return count == 0;
}