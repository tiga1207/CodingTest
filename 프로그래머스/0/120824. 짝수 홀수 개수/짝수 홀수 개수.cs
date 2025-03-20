using System;


public class Solution {
    public int[] solution(int[] num_list) {
        int even = 0;
        int odd = 0;
        int[] answer = new int[2];
        for(int i =0 ; i < num_list.Length ; i++) 
        {
            if(num_list[i]%2 ==0)//짝수 개수
            {
                even +=1;
            }
            else//홀수
            {
                odd +=1;
            }
        }
        
        answer[0] = even;
        answer[1] = odd;
        
        return answer;
    }
}