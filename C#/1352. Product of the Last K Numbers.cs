/*
 * Link: https://leetcode.com/problems/product-of-the-last-k-numbers/
 * Author: Dung Nguyen Tien (Chris)
*/

public class ProductOfNumbers {
    List<int> products;
    
    public ProductOfNumbers() {
        Add(0);
    }
    
    public void Add(int num) {
        if (num == 0) {
            products = new List<int>();
            products.Add(1);
        }
        else {
            var last = products[products.Count - 1];
            
            products.Add(last * num);
        }
    }
    
    public int GetProduct(int k) {
        if (k > products.Count - 1) return 0;
        
        var last = products[products.Count - 1];
        
        return last / products[products.Count - 1 - k];
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */