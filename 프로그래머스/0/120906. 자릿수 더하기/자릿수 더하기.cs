using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
            string sb = $"{n}";

            for(int i =0; i <sb.Length; i++)
            {
                answer += sb[i] - '0';
            }
            return answer;
    }
}