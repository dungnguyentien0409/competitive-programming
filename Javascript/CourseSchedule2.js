/**
 * Link: https://leetcode.com/problems/course-schedule-ii/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} numCourses
 * @param {number[][]} prerequisites
 * @return {number[]}
 */
var findOrder = function(numCourses, prerequisites) {
    var order = [];
    var map = createMap(numCourses, prerequisites);
    
    while (order.length < numCourses) {
        var check = false;
        for (var c in map) {
            var prerequisites = map[c];
            if (!order.includes(parseInt(c)) && hasLearnt(order, map, c)) {
                order.push(parseInt(c));
                check = true;
            }
        }
        
        // if go through the list of courses, cant find the next courses to learn, return false
        if (!check) {
            return [];
        }
    }
    
    return order;
}

// check if the prerequistics has learnt or not
function hasLearnt(order, map, c) {
    var prerequisites = map[c];
    
    if (prerequisites.length == 0 ||
       (order.length > 0 && prerequisites.every(p => order.includes(p)))) return true;
    
    return false;
}

// for every course, build the list of prerequisties
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