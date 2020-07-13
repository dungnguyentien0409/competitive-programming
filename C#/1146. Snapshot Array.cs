/*
 * Link: https://leetcode.com/problems/snapshot-array/
 * Author: Dung Nguyen Tien (Chris)
*/

public class SnapshotArray {
    int version;
    Dictionary<int, int>[] snaps;
    
    public SnapshotArray(int length) {
        version = 0;
        snaps = new Dictionary<int, int>[length];
    }
    
    public void Set(int index, int val) {
        if (snaps[index] == null) {
            snaps[index] = new Dictionary<int, int>();
        }
        
        if (snaps[index].ContainsKey(version)) {
            snaps[index][version] = val;
        }
        else {
            snaps[index].Add(version, val);
        }
    }
    
    public int Snap() {
        return version++;
    }
    
    public int Get(int index, int snap_id) {
        if (snaps[index] == null) return 0;
        
        if (snaps[index].ContainsKey(snap_id)) 
            return snaps[index][snap_id];
        
        while(!snaps[index].ContainsKey(snap_id) && snap_id >= 0) snap_id--;
        
        return snap_id >= 0 ? snaps[index][snap_id] : 0;
    }
}

/**
 * Your SnapshotArray object will be instantiated and called as such:
 * SnapshotArray obj = new SnapshotArray(length);
 * obj.Set(index,val);
 * int param_2 = obj.Snap();
 * int param_3 = obj.Get(index,snap_id);
 */