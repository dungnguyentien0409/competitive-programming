/*
 * Link: https://leetcode.com/problems/design-hashset/
 * Author: Dung Nguyen Tien (Chris)
*/

public class MyHashSet {
    /** Initialize your data structure here. */
    
    BST bst;
    public MyHashSet()
    {
        bst = new BST();
    }

    public void Add(int key)
    {
        bst.Insert(key);
    }

    public void Remove(int key)
    {
        bst.Remove(key);
    }

    /** Returns true if this set contains the specified element */
    public bool Contains(int key)
    {
        return bst.Contains(key);
    }
}

public class BST {
    public Node root;
    
    public BST() {
    }
    
    public bool Contains(int v) {
        var node = root;
        
        while (node != null) {
            if (node.val == v) return true;
            else if (node.val < v) node = node.right;
            else node = node.left;
        }
        
        return false;
    }
    
    public void Insert(int v) {
        var node = root;
        
        root = InsertHelper(node, v);
    }
    
    public Node InsertHelper(Node n, int v) {
        if (n == null) {
            return new Node(v);
        }
        
        if (n.val < v) {
            n.right = InsertHelper(n.right, v);
        }
        else if (n.val > v) {
            n.left = InsertHelper(n.left, v);
        }
        
        return n;
    }
    
    public void Remove(int v) {
        var node = root;
        
        root = RemoveHelper(node, v);
    }
    
    public Node RemoveHelper(Node n, int v) {
        if (n == null) return null;
        
        if (n.val < v) {
            n.right = RemoveHelper(n.right, v);
        }
        else if (n.val > v) {
            n.left = RemoveHelper(n.left, v);
        }
        else {
            if (n.left == null) return n.right;
            else if (n.right == null) return n.left;
            
            n.val = GetMin(n.right);
            Console.WriteLine("min: " + n.val);
            n.right = RemoveHelper(n.right, n.val);
        }
        
        return n;
    }
    
    public int GetMin(Node n) {
        if (n.left == null) return n.val;
        
        return GetMin(n.left);
    }
}

public class Node {
    public int val;
    public Node left;
    public Node right;
    
    public Node(int v) {
        val = v;
        left = null;
        right = null;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */