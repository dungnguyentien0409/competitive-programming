/*
 * Link: https://leetcode.com/problems/design-hashmap/
 * Author: Dung Nguyen Tien (Chris)
*/

public class MyHashMap {
    public BST bst;
    
    /** Initialize your data structure here. */
    public MyHashMap() {
        bst = new BST();    
    }
    
    /** value will always be non-negative. */
    public void Put(int key, int value) {
        bst.Put(key, value);
    }
    
    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key) {
        return bst.Get(key);
    }
    
    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void Remove(int key) {
        bst.Remove(key);
    }
}

public class BST {
    public Node root;
    
    public BST() {}
    
    public void Put(int key, int value) {
        var n = root;
        
        root = PutHelper(n, key, value);
    }
    
    public Node PutHelper(Node n, int key, int value) {
        if (n == null) {
            return new Node(key, value);
        }
        
        if (n.key == key) {
            n.val = value;
        }
        else if (n.key < key) {
            n.right = PutHelper(n.right, key, value);
        }
        else if(n.key > key) {
            n.left = PutHelper(n.left, key, value);
        }
        
        return n;
    }
    
    public int Get(int key) {
        var n = root;
        
        return GetHelper(n, key);
    }
    
    public int GetHelper(Node n, int key) {
        if (n == null) return -1;
        
        if (n.key == key) return n.val;
        else if (n.key < key) return GetHelper(n.right, key);
        else return GetHelper(n.left, key);
    }
    
    public void Remove(int key) {
        var n = root;
        
        root = RemoveHelper(n, key);
    }
    
    public Node RemoveHelper(Node n, int key) {
        if (n == null) return n;
        
        if (n.key < key) {
            n.right = RemoveHelper(n.right, key);
        }
        else if (n.key > key) {
            n.left = RemoveHelper(n.left, key);
        }
        else {
            if (n.left == null) return n.right;
            else if (n.right == null) return n.left;
            
            var minNode = GetMin(n.right);
            n.key = minNode.key;
            n.val = minNode.val;
            n.right = RemoveHelper(n.right, n.key);
        }
        
        return n;
    }
    
    public Node GetMin(Node n) {
        if (n.left == null) return n;
        
        return GetMin(n.left);
    }
}

public class Node {
    public int key;
    public int val;
    public Node left;
    public Node right;
    
    public Node(int k, int v) {
        key = k;
        val = v;
        left = null;
        right = null;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */