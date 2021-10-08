
var Trie = function() {
    this.trie = {};
};

/** 
 * @param {string} word
 * @return {void}
 */
Trie.prototype.insert = function(word) {
    let trie = this.trie;
    
    for(let w of word) {
        if (!trie[w]) {
            trie[w] = {};
        }
        
        trie = trie[w];
    }
    
    trie['.'] = null;
};

/** 
 * @param {string} word
 * @return {boolean}
 */
Trie.prototype.search = function(word) {
    let trie = this.trie;
    
    for(let w of word) {
        if (!trie[w]) return false;
        
        trie = trie[w];
    }
    
    return '.' in trie;
};

/** 
 * @param {string} prefix
 * @return {boolean}
 */
Trie.prototype.startsWith = function(prefix) {
    let trie = this.trie;
    
    for(var w of prefix) {
        if (!trie[w]) return false;
        
        trie = trie[w];
    }
    
    return Object.keys(trie).length > 0;
};

/** 
 * Your Trie object will be instantiated and called as such:
 * var obj = new Trie()
 * obj.insert(word)
 * var param_2 = obj.search(word)
 * var param_3 = obj.startsWith(prefix)
 */