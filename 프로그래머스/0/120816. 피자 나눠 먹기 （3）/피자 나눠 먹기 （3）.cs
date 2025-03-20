using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 0;
        
        //피자 slice 조각, 먹는 사람 수 n. n명의 사람이 최소 1조각 이상 먹으려면 몇 판?
        if(n < slice)
        {
            answer = 1;
        }
        else
        {
            if(n % slice == 0)
            {
                answer = n/slice;
            }
            else
            {
                answer = n/slice + 1;
            }
        }
        
        return answer;
    }
}