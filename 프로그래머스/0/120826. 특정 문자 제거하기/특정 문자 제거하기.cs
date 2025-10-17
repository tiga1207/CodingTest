using System;
using System.Text;

public class Solution {
    public string solution(string my_string, string letter) {
        StringBuilder sb = new StringBuilder();
for (int i = 0; i < my_string.Length; i++)
{
    if (my_string[i] == letter[0])
    {
        sb.Append("");
    }
    else
    {
        sb.Append(my_string[i]);
    }
}

return sb.ToString();
    }
}