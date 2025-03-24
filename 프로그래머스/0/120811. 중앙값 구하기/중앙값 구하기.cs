using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        for(int i = 0 ; i < array.Length-1 ; i++)
        {
            for(int j = i + 1 ; j< array.Length; j++)
            {
                if(array[i] > array[j])
                {
                    int temp =0;
                    temp = array [i];
                    array[i] =array[j];
                    array[j] = temp;
                }
            }
        }
        answer = array[array.Length/2];
        return answer;
    }
}