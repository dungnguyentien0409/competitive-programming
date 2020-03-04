/*
 * Link: https://leetcode.com/problems/two-sum-iii-data-structure-design/
 * Author: Dung Nguyen Tien (Chris)
*/

public class TwoSum {

    /** Initialize your data structure here. */
    Dictionary<int, int> map;
    
    public TwoSum() {
        this.map = new Dictionary<int, int>();
    }
    
    /** Add the number to an internal data structure.. */
    public void Add(int number) {        
        if (!this.map.ContainsKey(number)) this.map.Add(number, 0);
        
        this.map[number]++;
    }
    
    /** Find if there exists any pair of numbers which sum is equal to the value. */
    public bool Find(int value) {
        foreach(var key in this.map.Keys) {
            if (value - key == key) {
                if (this.map[key] > 1) {
                    return true;
                }
            }
            else {
                if (map.ContainsKey(value - key)) return true;
            }
        }
        
        return false;
    }
}

/**
 * Your TwoSum object will be instantiated and called as such:
 * TwoSum obj = new TwoSum();
 * obj.Add(number);
 * bool param_2 = obj.Find(value);
 */