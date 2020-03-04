/**
 * Link: https://leetcode.com/problems/lfu-cache/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} capacity
 */
var LFUCache = function(capacity) {
    this.minFrequence = 0;
    this.capacity = capacity;
    this.keys = {}; // store node: everynode contain key, value, frequent
    this.frequences = [new LruDoubleLinkedList(), 
                       new LruDoubleLinkedList()]; // store Lfu double linked list
    this.size = 0;
};

/** 
 * @param {number} key
 * @return {number}
 */
LFUCache.prototype.get = function(key) {
    var node = this.keys[key];

    if (node == undefined) return -1;
    
    var oldFrequence = node.frequence;
    node.frequence += 1;
    
    // remove node from old frequence list and add node to new frequence list
    delete this.keys[node.key];
    this.frequences[oldFrequence].removeNode(node);
    
    
    if (this.frequences[node.frequence] == undefined)
        this.frequences[node.frequence] = new LruDoubleLinkedList();
    node = this.frequences[node.frequence].addNode(node);
    this.keys[node.key] = node;
    
    // if we remove the only one element of minfrequence, then update minfrequence
    if (this.frequences[this.minFrequence].isEmpty()) this.minFrequence++;
    
    return node.val;
};

/** 
 * @param {number} key 
 * @param {number} value
 * @return {void}
 */
LFUCache.prototype.put = function(key, value) {
    if (this.capacity == 0) return;
    
    var node = this.keys[key];
    if (node == undefined) {
        // if the cache is full, remove one before add
        if (this.size == this.capacity) {
            var tailKey = this.frequences[this.minFrequence].removeTail();
            delete this.keys[tailKey];
            this.size--;
        }
        
        // add new item to cache, so the min frequence for the new is one
        node = { key: key, val: value, frequence: 1, prev: null, next: null }; 
        node = this.frequences[node.frequence].addNode(node);
        this.minFrequence = 1;
        this.size++;
    }
    else {
        // update the value of node: delete the current, update, increase the frequence and add back
        this.frequences[node.frequence].removeNode(node);
        delete this.keys[key];
        
        node.val = value;
        node.frequence++;
        
        if (this.frequences[node.frequence] == undefined)
        this.frequences[node.frequence] = new LruDoubleLinkedList();
            node = this.frequences[node.frequence].addNode(node);
        // if the node we increment the frequence is the last node of the minfrequent list, then increase the minFrequence
        if (this.frequences[this.minFrequence].isEmpty())
            this.minFrequence++;  
    } 
    this.keys[key] = node;   
};

function LruDoubleLinkedList() {
    this.head = { key: null, val: null, prev: null, next: null };
    this.tail = { key: null, val: null, prev: this.head, next: null };
    this.head.next = this.tail;
    this.size = 0;
    
    this.addNode = function(node) {
        var firstNode = this.head.next;
        
        this.head.next = node;
        node.prev = this.head;
        node.next = firstNode;
        firstNode.prev = node;
        this.size++;
        
        return node;
    }
    
    this.removeTail = function() {
        // tail is the null node
        var tailNode = this.tail.prev;
        var beforeTailNode = tailNode.prev;
        var key = tailNode.key;
        
        beforeTailNode.next = this.tail;
        this.tail.prev = beforeTailNode;
        tailNode = null;
        this.size--;
        
        return key;
    }
    
    this.removeNode = function(node) {
        var prevNode = node.prev;
        var nextNode = node.next;
        var key = node.key;
        
        prevNode.next = nextNode;
        nextNode.prev = prevNode;
        node = null;
        this.size--;
        return key;
    }
    
    this.isEmpty = function() {
        if (this.head.next == this.tail) return true;
        return false
    }
    
    return this;
}

/** 
 * Your LFUCache object will be instantiated and called as such:
 * var obj = new LFUCache(capacity)
 * var param_1 = obj.get(key)
 * obj.put(key,value)
 */