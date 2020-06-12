/*
 * Link: https://leetcode.com/problems/insert-delete-getrandom-o1-duplicates-allowed/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class RandomizedCollection {
    Random rn;
    List<int> nums;
    Dictionary<int, HashSet<int>> map;
    /** Initialize your data structure here. */
    public RandomizedCollection() {
        rn = new Random();
        nums = new List<int>();
        map = new Dictionary<int, HashSet<int>>();
    }
    
    /** Inserts a value to the collection. Returns true if the collection did not already contain the specified element. */
    public bool Insert(int val) {
        var contain = map.ContainsKey(val);
        
        nums.Add(val);
        if (!contain) map.Add(val, new HashSet<int>());
        
        map[val].Add(nums.Count - 1);
        
        return !contain;
    }
    
    /** Removes a value from the collection. Returns true if the collection contained the specified element. */
    public bool Remove(int val) {
        if (!map.ContainsKey(val) 
            || (map.ContainsKey(val) && map[val].Count == 0)) return false;
        
        var index = map[val].First();
        
        map[val].Remove(index);
        if (index < nums.Count - 1) {
            int last = nums[nums.Count - 1];
            nums[index] = last;
            map[last].Remove(nums.Count - 1);
            map[last].Add(index);
        }
        
        nums.RemoveAt(nums.Count - 1);
        if (map[val].Count == 0) map.Remove(val);
        
        return true;
    }
    
    /** Get a random element from the collection. */
    public int GetRandom() {
        var index = rn.Next(0, nums.Count);
        
        return nums[index];
    }
    
    public void Swap(int x, int y) {
        if (x == y) return;
        
        var tmp = nums[x];
        nums[x] = nums[y];
        nums[y] = tmp;
    }
}

/**
 * Your RandomizedCollection object will be instantiated and called as such:
 * RandomizedCollection obj = new RandomizedCollection();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */