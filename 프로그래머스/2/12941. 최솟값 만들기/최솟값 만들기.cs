using System;

public class Solution {
    public int solution(int[] A, int[] B)
{
    Array.Sort(A);
    Array.Sort(B);
    Array.Reverse(B);
    int sum = 0;

    for(int i =0; i < A.Length; i++)
    {
        sum += A[i] * B[i];
    }

    
    return sum;
}
}