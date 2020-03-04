/**
 * Problem: https://leetcode.com/problems/the-skyline-problem/
 * Author: Dung Nguyen Tien (Chris)
 * Implement following idea of Tushar Roy
 * Reference: https://www.youtube.com/watch?v=GSBLe8cKu0s
 * @param {number[][]} buildings
 * @return {number[][]}
 */
var getSkyline = function(buildings) {
    //determine the start point and end point of a building, also mark it as start or end. It is sorted by rule 
    var buildingPoints = getBuildingPoints(buildings); 
    console.log(buildingPoints);
    var res = [];
    var queue = [0];
    var max = 0;
    
    for (var point of buildingPoints) {
        // pick each point: if start => push height to queue, end => remove height from queue. the queue is increasing
        if (point.isStart) {
            // start => push height to queue, find the index by binarySearch
            var index = binarySearch(queue, point.height);
            queue.splice(index, 0, point.height);
        }
        else {
            // remove height from queue
            var index = queue.indexOf(point.height);
            queue.splice(index, 1);
        }
        
        // if the push or remove changes the maxHeight, mean it moves to another block, push that point (x, maxCurrentHeight) to res
        var currentMax = queue[queue.length - 1];
        if (max != currentMax) {
            max = currentMax;
            res.push([point.x, max]);
        }
    }
    
    return res;
};

function binarySearch(arr, target) {
    var left = 0;
    var right = arr.length - 1;
    var mid = 0;
    
    while(left < right) {
        mid = Math.floor(left + (right - left) / 2);
        
        if (arr[mid] < target) left = mid + 1;
        else right = mid;
    }
    
    if (arr[left] < target) return ++left;
    return left;
}

function getBuildingPoints(buildings) {
    var buildingPoints = [];
    for (var building of buildings) {
        var start = {};
        start.x = building[0];
        start.height = building[2];
        start.isStart = true;
        buildingPoints.push(start);
        
        var end = {};
        end.x = building[1];
        end.height = building[2];
        buildingPoints.push(end);
        end.isStart = false;
    }
    
    buildingPoints.sort(compPareBuildingPoint);
    
    return buildingPoints;
}

function compPareBuildingPoint(a, b) {
    //first compare by x.
    if (a.x != b.x) return a.x - b.x;
    else {
        //If they are same then use this logic
        //if two starts are compared then higher height building should be picked first
        //if two ends are compared then lower height building should be picked first
        //if one start and end is compared then start should appear before end
        return (a.isStart ? -a.height : a.height) - (b.isStart ? -b.height : b.height);
    }
}