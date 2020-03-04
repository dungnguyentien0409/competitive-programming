/**
 * Link: https://leetcode.com/problems/course-schedule-iii/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} courses
 * @return {number}
 */
var scheduleCourse = function(courses) {
    // sort by the end date
    courses.sort(function(a, b) {
        if (a[1] == b[1]) return a[0] - b[0];
        return a[1] - b[1];
    })

    var order = [];
    var time = 0
    for (var i = 0; i < courses.length; i++) {
        var course = courses[i];
        var duration = course[0];
        var deadline = course[1];
        
        // for every course, put the duration into queue, and calculate the time. if the time exceed, pop the longest one.
        var index = binarySearch(order, duration);
        order.splice(index, 0, duration);
        time += duration;
        
        if (time > deadline) {
            var removeLongest = order.pop();
            time -= removeLongest;
        }
    }
    
    return order.length;
};


function binarySearch(arr, target) {
    var left = 0;
    var right = arr.length - 1;
    
    while(left < right) {
        var mid = Math.floor((left + right) / 2);
        
        if (arr[mid] < target) left = mid + 1;
        else right = mid;
    }
    
    if (arr[left] < target) return left + 1;
    return left;
}