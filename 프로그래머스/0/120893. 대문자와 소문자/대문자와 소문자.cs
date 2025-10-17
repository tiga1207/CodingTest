using System;
using System.Text;

public class Solution {
    public string solution(string my_string) {
        StringBuilder sb = new StringBuilder();
foreach(var str in my_string)
{

    if (str >= 'A' && str <'a')
        sb.Append((char)(str + 32));
    if(str >= 'a')
        sb.Append((char)(str - 32));
}
return sb.ToString();
    }
}