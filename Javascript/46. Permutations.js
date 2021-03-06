/**
 * Link: https://leetcode.com/problems/permutations/submissions/
 * Author: Dung Nguyen Tien
 * @param {number[]} nums
 * @return {number[][]}
 */

var permute = function(nums) {
    // idea:
    // take the first element, permute the right = permutedRights
    // with each item of permutedRights add the first element in
    // Forexample : "abc"
    // first: a, permutedRights = [[b,c], [c,b]]
    // with each element, let say [b,c]: add a in
    // we have: [a,b,c], [b,a,c], [b,c,a]
    if (nums.length == 0) return [[]];
    
    var res = [];
    var first = nums[0];
    var rights = nums.slice(1);
    
    var permutedRights = permute(rights);
    for (let p of permutedRights) {
        for (let i = 0; i <= p.length; i++) {
            let tmp = p.slice(0);
            tmp.splice(i, 0, first);
            res.push(tmp);
        }
    }
    
    return res;
};