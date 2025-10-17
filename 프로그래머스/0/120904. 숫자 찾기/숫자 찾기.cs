using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int num, int k) {
        string numString = num.ToString();
List<int> list = new List<int>();


for (int i = 0; i < numString.Length; i++)
{
    //int num3;
    list.Add(numString[i]-'0');
    //int.TryParse(numString[i].ToString(), out num3);
    //list.Add(num3);
}

for (int i = 0; i < list.Count; i++)
{
    if (list[i] == k)
        return i + 1;
}
return -1;
    }
}