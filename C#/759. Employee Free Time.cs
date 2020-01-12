/*
 * Link: https://leetcode.com/problems/employee-free-time/submissions/
 * Author: Dung Nguyen Tien (Chris)
// Definition for an Interval.
public class Interval {
    public int start;
    public int end;

    public Interval(){}
    public Interval(int _start, int _end) {
        start = _start;
        end = _end;
    }
}
*/
public class Solution {
    public IList<Interval> EmployeeFreeTime(IList<IList<Interval>> schedule) {
        // flattern and merge shedule
        var intervals = MergeInterval(schedule);

        // find the space between each schedule
        if (intervals.Count <= 1) return intervals;
        
        var res = new List<Interval>();
        for (var i = 1; i < intervals.Count; i++) {
            res.Add(new Interval(intervals[i - 1].end, intervals[i].start));
        }
        
        return res;
    }
    
    public IList<Interval> MergeInterval(IList<IList<Interval>> schedule) {
        var intervals = Flattern(schedule);
        var res = new List<Interval>();
        
        res.Add(intervals[0]);
        for(var i = 1; i < intervals.Count; i++) {
            var cur = intervals[i]; 
            var prev = res[res.Count - 1];
            res.RemoveAt(res.Count - 1);
            
            if (prev.end >= cur.start) {
                var start = Math.Min(prev.start, cur.start);
                var end = Math.Max(prev.end, cur.end);
                res.Add(new Interval(start, end));
            }
            else {
                res.Add(prev);
                res.Add(cur);
            }
        }
        
        return res;
    }
    
    public IList<Interval> Flattern(IList<IList<Interval>> schedule) {
        var flattern = new List<Interval>();
        
        foreach(var s in schedule) {
            flattern.AddRange(s);
        }
        
        var sorted = flattern.ToArray();
        Array.Sort(sorted, delegate(Interval a, Interval b) {
            return a.start - b.start;
        });
        return sorted.ToList();
    }
}