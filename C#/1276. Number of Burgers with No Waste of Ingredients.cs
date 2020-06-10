/*
 * Link: https://leetcode.com/problems/number-of-burgers-with-no-waste-of-ingredients/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> NumOfBurgers(int tomatoSlices, int cheeseSlices) {
        if (tomatoSlices >= cheeseSlices && tomatoSlices % 2 == 0 
            && tomatoSlices / 2 - cheeseSlices >= 0
            && 2 * cheeseSlices - tomatoSlices / 2 >= 0) {
            var jumbo = tomatoSlices / 2 - cheeseSlices;
            var small = cheeseSlices - jumbo;
            
            return new int[2] { jumbo, small };
        }
        
        return new int[] {};
    }
}