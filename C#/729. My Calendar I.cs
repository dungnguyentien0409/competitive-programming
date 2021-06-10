/*
 * Link: https://leetcode.com/problems/my-calendar-i/
 * Author: Dung Nguyen Tien (Chris)
*/

public class MyCalendar {
    List<int[]> list;
    public MyCalendar() {
        list = new List<int[]>();
    }
    
    public bool Book(int start, int end) {
        foreach(var item in list) {
            if (item[1] > start && item[0] < end) return false;
        }
        
        list.Add(new int[2] { start, end });
        
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */