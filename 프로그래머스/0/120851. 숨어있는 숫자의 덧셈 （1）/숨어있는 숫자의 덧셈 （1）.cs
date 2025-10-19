using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
            foreach (var item in my_string)
            {
                if(item >48 && item <58)
                {
                    answer+= item-48;
                }
            }
            return answer;
    }
}