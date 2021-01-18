/**
 * Link: https://leetcode.com/problems/nested-list-weight-sum/
 * Author: Dung Nguyen Tien (Chris)
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // Constructor initializes an empty nested list.
 *     public NestedInteger();
 *
 *     // Constructor initializes a single integer.
 *     public NestedInteger(int value);
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // Set this NestedInteger to hold a single integer.
 *     public void SetInteger(int value);
 *
 *     // Set this NestedInteger to hold a nested list and adds a nested integer to it.
 *     public void Add(NestedInteger ni);
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class Solution {
    public int DepthSum(IList<NestedInteger> nestedList) {
        int sum = 0, level = 0;
        var queue = new Queue<NestedInteger>();
        
        foreach(var item in nestedList) queue.Enqueue(item);
        
        while(queue.Count > 0) {
            level++;
            
            var len = queue.Count;
            for (var i = 0; i < len; i++) {
                var item = queue.Dequeue();
                
                if (item.IsInteger()) {
                    sum += (item.GetInteger() * level);
                }
                else {
                    foreach(var child in item.GetList()) {
                        queue.Enqueue(child);
                    }
                }
            }
        }
        
        return sum;
    }
}