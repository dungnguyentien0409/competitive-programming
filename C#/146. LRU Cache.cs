/*
 * Link: https://leetcode.com/problems/lru-cache/
 * Author: Dung Nguyen Tien (Chris)
*/

public class LRUCache {
    DoubleLinkedList list;
        
    public LRUCache(int capacity) {
        list = new DoubleLinkedList(capacity);
    }
    
    public int Get(int key) {
        var res = list.Get(key);
        
        return res;
    }
    
    public void Put(int key, int value) {
        var node = new Node(key, value);
        list.Add(node);
    }
}

public class DoubleLinkedList {
    public Node head;
    public Node tail;
    public int size;
    public int count;
    public Dictionary<int, Node> map;
    
    public DoubleLinkedList(int capacity) {
        head = new Node(Int32.MaxValue, Int32.MaxValue);
        tail = new Node(Int32.MaxValue, Int32.MaxValue);
        size = capacity;
        count = 0;
        map = new Dictionary<int, Node>();
        
        head.next = tail;
        tail.prev = head;
    }
    
    public int Get(int key) {
        if (!map.ContainsKey(key)) return -1;
        
        var node = map[key];
        
        Remove(node);
        Add(node);
        
        return node.val;
    }
    
    public void Add(Node n) {
        if (map.ContainsKey(n.key)) {
            var node = map[n.key];
            Remove(node);
        }
        
        var first = head.next;
        
        head.next = n;
        n.prev = head;
        n.next = first;
        first.prev = n;
        
        map.Add(n.key, n);
        count++;
        
        if (count > size) {
            Remove(tail.prev);
        }
    }
    
    public void Remove(Node n) {
        var prev = n.prev;
        var next = n.next;
        
        prev.next = next;
        next.prev = prev;
        n.next = null;
        n.prev = null;
        
        map.Remove(n.key);
        count--;
    }
}

public class Node {
    public int key;
    public int val;
    public Node prev;
    public Node next;
    
    public Node(int k, int v) {
        key = k;
        val = v;
        prev = null;
        next = null;
    }
}
/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */