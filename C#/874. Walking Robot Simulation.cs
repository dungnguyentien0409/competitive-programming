/*
 * Link: https://leetcode.com/problems/walking-robot-simulation/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int RobotSim(int[] commands, int[][] obstacles) {
        var directions = new int[4][] {
            new int[2] { 0, 1 },
            new int[2] { 1, 0 },
            new int[2] { 0, -1 },
            new int[2] { -1, 0 }
        };
        var set = GetObstacles(obstacles);
        int x = 0, y = 0, d = 0;
        int max = 0;
        
        foreach(var command in commands) {
            if (command == -1) {
                d = (d + 1) % 4;
            }   
            else if (command == -2) {
                d = (d + 3) % 4;
            }
            else {
                var steps = 0;

                while(steps < command 
                      && !set.Contains((x + directions[d][0]) + " " + (y + directions[d][1]))) {
                    x += directions[d][0];
                    y += directions[d][1];
                    steps++;
                }
            }
            
            max = Math.Max(max, x * x + y * y);
        }
        
        return max;
    }
    
    public HashSet<string> GetObstacles(int[][] obstacles) {
        var set = new HashSet<string>();
        
        foreach(var obs in obstacles) {
            set.Add(obs[0] + " " + obs[1]);
        }
        
        return set;
    }
}