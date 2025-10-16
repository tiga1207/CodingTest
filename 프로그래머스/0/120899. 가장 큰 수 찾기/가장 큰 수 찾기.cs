using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array) {
        int max = array[0];
int index = 0;
List<int> answer = new List<int>();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
        index = i;
    }
}
answer.Add(max);
answer.Add(index);

return answer.ToArray();
    }
}