public class Solution {
    public int JobScheduling(int[] startTime, int[] endTime, int[] profit) {
        var jobs = Create(startTime, endTime, profit);
        jobs.Sort(delegate(Job a, Job b) {
            return a.end - b.end;
        });
        
        var dp = new int[jobs.Count + 1];
        for(var i = 1; i <= jobs.Count; i++) {
            var job = jobs[i - 1];
            
            var pre = BinarySearch(jobs, 0, i - 2, job.start);
            dp[i] = Math.Max(dp[i], dp[pre + 1] + job.profit);
            dp[i] = Math.Max(dp[i], dp[i - 1]);
        }
        
        foreach(var i in dp) Console.Write(i + "\t");
        
        return dp[jobs.Count];
    }
    
    public int BinarySearch(List<Job> jobs, int start, int end, int startTime) {
        while(start < end) {
            var mid = start + (end - start + 1) / 2;
            
            if (jobs[mid].end <= startTime) {
                start = mid;
            }
            else {
                end = mid - 1;
            }
        }
        
        return jobs[start].end <= startTime ? start : -1;
    }
    
    public List<Job> Create(int[] startTime, int[] endTime, int[] profit) {
        var res = new List<Job>();
        
        for(var i = 0; i < profit.Length; i++) {
            res.Add(new Job(startTime[i], endTime[i], profit[i]));
        }
        
        return res;
    }
}

public class Job {
    public int start;
    public int end;
    public int profit;
    public int duration;
    
    public Job(int s, int e, int p) {
        start = s;
        end = e;
        profit = p;
        duration = end - start;
    }
}