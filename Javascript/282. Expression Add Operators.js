/**
 * @param {string} num
 * @param {number} target
 * @return {string[]}
 */
var _num, _target;
var addOperators = function(num, target) {
    _num = num;
    _target = target;
    
    var res = [];
    helper(res, 0, "", 0, 0);
    
    return res;
};


function helper(res, pos, cur, val, multiple) {
    if (pos == _num.length && val == _target) {
        res.push(cur);
    }
    
    for(var i = pos; i < _num.length; i++) {
        if (i > pos && _num[pos] == '0') break;
        
        var numString = _num.substr(pos, i - pos + 1);
        var numInt = parseInt(numString);
        
        if (pos == 0) {
            helper(res, i + 1, numString, numInt, numInt);
        }
        else {
            helper(res, i + 1, cur + "+" + numString, val + numInt, numInt);
            helper(res, i + 1, cur + "-" + numString, val - numInt, -numInt);
            helper(res, i + 1, cur + "*" + numString, val - multiple + multiple * numInt, multiple * numInt);
        }
    }
}