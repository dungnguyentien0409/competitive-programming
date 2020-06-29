/*
 * Link: https://leetcode.com/problems/reconstruct-itinerary/
 * Idea: StefanPochmann
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        var map = CreateMap(tickets);
        var route = new List<string>();
        var st = new Stack<string>();
        
        st.Push("JFK");
        while(st.Count > 0) {
            while(map.ContainsKey(st.Peek()) && map[st.Peek()].Count > 0) {
                var next = map[st.Peek()][0];
                map[st.Peek()].RemoveAt(0);
                
                st.Push(next);
            }
            
            route.Insert(0, st.Pop());
        }
        
        return route;
    }
    
    public Dictionary<string, List<string>> CreateMap(IList<IList<string>> tickets) {
        var map = new Dictionary<string, List<string>>();
        
        foreach(var ticket in tickets) {
            string from = ticket[0], to = ticket[1];
            
            if (!map.ContainsKey(from)) map.Add(from, new List<string>());
            
            map[from].Add(to);
        }
        
        foreach(var key in map.Keys.ToList()) {
            map[key].Sort(delegate(string a, string b) {
                return a.CompareTo(b);
            });
        }
        
        return map;
    }
}