/**
 * Link: https://leetcode.com/problems/lru-cache/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} capacity
 */
var LRUCache = function(capacity) {
    /*
        Idea: use double linked list and hash map, 
        For adding new item, add to the first of the list
        For each item use, take out of the list and put the the first of the list
        The map is to store [key, node] pair to get
        If the list exceed the pop the last
    */
    this.capacity = capacity;
    this.map = {};
    this.head = {
        key: null,
        val: null,
        prev: null,
    };
    this.tail = {
        key: null,
        val: null,
        prev: this.head,
        next: null,
    };
    this.head.next = this.tail;
    this.count = 0;
    
    this.removeNode = function(node) {
        var prevNode = node.prev;
        var nextNode = node.next;
        
        delete this.map[node.key];
        prevNode.next = nextNode;
        nextNode.prev = prevNode;
        node = null;
        this.count--;
    }
    
    this.addNode = function(node) {
        var firstNode = this.head.next;
        node.next = firstNode;
        node.prev = this.head;
        
        firstNode.prev = node;
        this.head.next = node;
        this.count++;
        this.map[node.key] = node;

        if (this.count > this.capacity) {
            var lastNode = this.tail.prev;
            this.removeNode(lastNode);
        }
    }
};

/** 
 * @param {number} key
 * @return {number}
 */
LRUCache.prototype.get = function(key) {
    if (this.map[key] == undefined) return -1;
    
    var node = this.map[key];
    this.removeNode(node);
    this.addNode(node);
    
    return node.val;
};

/** 
 * @param {number} key 
 * @param {number} value
 * @return {void}
 */
LRUCache.prototype.put = function(key, value) {
    var node = this.map[key];
    
    if (node == undefined) {
        var node = {
            key: key,
            val: value,
            prev: null,
            next: null,
        };
    }
    else {
        this.removeNode(node);
        node.val = value;
    }
    this.addNode(node);
};

/** 
 * Your LRUCache object will be instantiated and called as such:
 * var obj = new LRUCache(capacity)
 * var param_1 = obj.get(key)
 * obj.put(key,value)
 */