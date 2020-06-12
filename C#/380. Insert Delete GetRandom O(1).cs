/*
 * Link: https://leetcode.com/problems/insert-delete-getrandom-o1/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class RandomizedSet {
    Random rn;
    List<int>nums;
    Dictionary<int, int> map;
    
    /** Initialize your data structure here. */
    public RandomizedSet() {
        rn = new Random();
        nums = new List<int>();
        map = new Dictionary<int, int>();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if (map.ContainsKey(val)) return false;
        
        nums.Add(val);
        map.Add(val, nums.Count - 1);
        
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if (!map.ContainsKey(val)) return false;
        
        var index = map[val];
        var last = nums[nums.Count - 1];
        
        Swap(index, nums.Count - 1);
        
        map[last] = index;
        map.Remove(val);
        nums.RemoveAt(nums.Count - 1);
        
        return true;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        var item = rn.Next(0, nums.Count);
        
        return nums[item];
    }
    
    public void Swap(int x, int y) {
        if (x == y) return;
        
        var tmp = nums[x];
        nums[x] = nums[y];
        nums[y] = tmp;
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */