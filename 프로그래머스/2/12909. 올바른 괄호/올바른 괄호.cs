using System;

public class Solution {
   public bool solution(string s)
{
    int count = 0;
    foreach (var a in s)
    {
        if (a == '(')
            count++;
        else
            count--;
        if (count < 0) return false; //닫는 괄호가 foreach문을 도는 동안 먼저 나오면 자동 false 반환
    }
    return count == 0; //foreach문 전부 다 돌고 괄호 (와 )의 개수 밸런스 체크
    
}
}