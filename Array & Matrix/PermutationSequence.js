/**
 * Problem: https://leetcode.com/problems/permutation-sequence/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} n
 * @param {number} k
 * @return {string}
 */
/*
Idea: Let say for n = 4, k = 4 => arr = [1,2,3,4]
We have a set of permutation sorted asc: 
1234, 1243, 1324, 1342, 1423, 1432 // group 1: lead by 1
2134, 2143, 2314, 2341, 2413, 2431 // group 2: lead by 2
3124, 3142, 3214, 3241, 3412, 3421 // group 3: lead by 3
4123, 4132, 4213, 4231, 4312, 4321 // group 4: lead by 4
We can have n group, each group have (n - 1) items: => n! permutation

first, define which group k belong to: x = Math.ceil(k/(n - 1)!) - 1 - group 1 => x = 0
second, k belong to group 1 => k element should start with 1: push 1 to result
third, calculate the position of k in group 1: k = k - (x * nf);
fourth, continue with the item in group 1: permute n = n - 1
*/
var getPermutation = function(n, k) {
    var res = [];
    var arr = [];
    
    for (var i = 1; i <= n; i++) arr.push(i);
    
    var n2 = n;
    while(k > 0) {
        // which group k belong to
        var items = getFactorial(n2 - 1);
        var nGroup = Math.ceil(k / items) - 1;
        var no = arr.splice(nGroup, 1)[0];
        res.push(no);
        
        // calculate inside the group
        k = k - (nGroup * items);
        n2 = n2 - 1;
    }
    // push the last item
    res.push(arr.splice(0, 1)[0]);
    
    return res.join('');
};

function getFactorial(n) {
    if (n == 1) return n;
    else if (n > 1) {
        return n * getFactorial(n - 1);
    }
}