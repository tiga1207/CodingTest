using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        //(a,b) a * b = n의 개수 -> answer
        for(int i =1 ; i<=n;i++)
        {
            if(n%i ==0)
            {
                answer ++;
            }
        }
        
        
        return answer;
    }
}