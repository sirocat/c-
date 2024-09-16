using System;

public class Solution {
    public int solution(int[] num_list) {
        int sum = 0;
        int mul = 1;
        
        for(int i = 0; i < num_list.Length; i++) {
            sum += num_list[i];
            mul *= num_list[i];
        }
        //집가고싶다        
        return mul < (sum * sum) ? 1 : 0;
    }
}
