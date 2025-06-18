using System;

public class Solution
{
    public int solution(int[] array)
    {
        int answer = 0;

        //1. 각 원소마다 나온 값을 저장하기 위한 배열을 선언.
        int[] saveArray = new int[1000];
        //2. 매개변수로 받은 배열의 크기만큼 순회하면서, 해당 배열의 값을 새로운 배열의 인덱스로 삼아서 해당 인덱스의 값을 +1해줌.
        for(int i =0; i < array.Length; i++)
        {
            saveArray[array[i]]++; //array의 원소를 saveArray의 인덱스로 저장하고 +1 해줌.
        }

        //최빈값 구하기 및 최빈값 여러 개인지 판정하기.
        int mode = 0;
        int max = 0;
        int maxCount = 0;
        for (int i = 0; i < saveArray.Length; i++)
        {
            if (max == saveArray[i])
            {
                maxCount++;
            }
            else if (max < saveArray[i])
            {
                mode = i;
                maxCount = 1;
                max = saveArray[i];
                
            }
            
        }
        //최빈 값이 하나? -> answer = mode, 아니면 -1
        if (maxCount == 1)
            answer = mode;
        else
            answer = -1;

        return answer;
    }
}