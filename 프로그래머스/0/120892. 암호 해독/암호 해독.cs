using System;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
int length = cipher.Length;

for(int i =1; i <= length; i++)
{
    if (i % code ==0)
        answer += cipher[i-1];
}
return answer;
    }
}