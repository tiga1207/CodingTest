using System;

public class Solution {
    public int solution(int[] numbers) {
        int max1 = numbers[0];
int max2 = 0;

for(int i =1; i< numbers.Length;i++)
{
    if (numbers[i] >= max1)
    {
        max2 = max1;
        max1 = numbers[i];
        continue;
    }
    if (numbers[i] > max2)
    {
        max2 = numbers[i];
    }
}

return max1 * max2;
    }
}