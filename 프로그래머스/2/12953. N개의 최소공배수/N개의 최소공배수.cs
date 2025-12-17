public class Solution {
    public int solution(int[] arr) {
    int answer = arr[0];

    //차근차근 한줄씩 최소공배수 구하기
    for (int i = 0; i < arr.Length-1; i++)
    {
        answer = answer / GCD(answer, arr[i + 1]) * arr[i + 1];
    }

    return answer;
}
public int GCD(int a, int b)
{
    while (b != 0)
    {
        int temp = a % b;
        a = b;
        b = temp;
    }
    return a;
}
}