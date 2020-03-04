/**
 * Problem: https://leetcode.com/problems/course-schedule/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} numCourses
 * @param {number[][]} prerequisites
 * @return {boolean}
 */
var canFinish = function(numCourses, prerequisites) {
    var learnt = Array(numCourses).fill(false);
    var total = 0;
    var map = createMap(numCourses, prerequisites);
    
    // if the course is not equal to total, continue learning
    while(total < numCourses) {
        var check = false;
        for (var c in map) {
            if (!learnt[c] && canLearn(learnt, map[c])) {
                learnt[c] = true;
                total++;
                check = true;
            }
        }
        
        // if go thorugh each course, cant learn anything, and the total is not the numCourses, mean having circle
        if (!check) return false;
    }
    return true;
};

// check if can learn this course
function canLearn(learnt, prerequisites) {
    var can = true;

    for (var p of prerequisites) can = can && learnt[p];
    
    return can;
}
         
// for each course, create the list of prerequisites
function createMap(numCourses, prerequisites) {
    var map = {};
    
    for (var i = 0; i < numCourses; i++) {
        map[i] = [];
    }
    
    for (var p of prerequisites) {
        map[p[0]].push(p[1]);
    }
    
    return map;
}