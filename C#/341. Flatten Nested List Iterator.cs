/**
 * Link: https://leetcode.com/problems/flatten-nested-list-iterator/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator
{
    Queue<int> queue;

    public NestedIterator(IList<NestedInteger> nestedList)
    {
        queue = new Queue<int>();
        
        foreach (var node in nestedList)
            dfs(node);
    }

    public bool HasNext()
    {
        return queue.Count != 0;
    }

    public int Next()
    {
        return queue.Count == 0 ? -1 : queue.Dequeue();
    }

    public void dfs(NestedInteger node)
    {
        if (node.IsInteger()) {
            queue.Enqueue(node.GetInteger());
        }
        else{
            foreach (var child in node.GetList())
                dfs(child);
        }
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */