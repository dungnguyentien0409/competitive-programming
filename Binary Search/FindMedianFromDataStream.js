/**
 * initialize your data structure here.
 */
var MedianFinder = function() {
    // the increasing array stores two part of array. the lower.length alwasy equal to higher.length or less then one element
    this.lower = [];
    this.higher = [];
    
    // 
    this.binarySearch = function(arr, target) {
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
    
    // to keep lower.length == higher.length or lower.length = higher.length + 1
    this.balance = function() {
        var lower = this.lower;
        var higher = this.higher;
        
        if (higher.length > lower.length) {
            var item = higher.splice(0, 1)[0];
            lower.push(item);
        }
        else if (lower.length > higher.length + 1) {
            var item = lower.splice(lower.length - 1, 1)[0];
            higher.unshift(item);
        }
    }
};

/** 
 * @param {number} num
 * @return {void}
 */
MedianFinder.prototype.addNum = function(num) {
    var lower = this.lower, higher = this.higher;
    
    // check the order to push num to the higher or the lower
    if (higher.length == 0  || num < higher[0]) {
        // push num to higher
        var index = this.binarySearch(lower, num);
        lower.splice(index, 0, num);
    }
    else {
        var index = this.binarySearch(higher, num);
        higher.splice(index, 0, num);
    }

    this.balance();
};

/**
 * @return {number}
 */
MedianFinder.prototype.findMedian = function() {
    var lower = this.lower;
    var higher = this.higher;

    if (lower.length > higher.length) return lower[lower.length - 1];
    
    return (lower[lower.length - 1] + higher[0]) / 2.0;
};

/** 
 * Your MedianFinder object will be instantiated and called as such:
 * var obj = new MedianFinder()
 * obj.addNum(num)
 * var param_2 = obj.findMedian()
 */