/*
 * Link: https://leetcode.com/problems/online-stock-span/
 * Author: Dung Nguyen Tien (Chris)
*/

public class StockSpanner {
    Stack<Stock> st;
    int date;
    
    public StockSpanner() {
        st = new Stack<Stock>();
        date = 0;
    }
    
    public int Next(int price) {
        date += 1;
        
        while(st.Count > 0 && st.Peek().value <= price) {
            st.Pop();
        }

        var duration = st.Count > 0 ? date - st.Peek().date: date;
        st.Push(new Stock(price, date));
        
        return duration;
    }
}

public class Stock {
    public int value;
    public int date;
    
    public Stock(int v, int d) {
        value = v;
        date = d;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */