using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer;
int length = numbers.Length;

// 정렬
Array.Sort(numbers);

//양수들 중 제일 큰 값 : 정렬된 배열에서 마지막, 마지막 -1 인덱스 값 가져와서 곱하기.
answer = numbers[length-1] * numbers[length - 2];

//음수들 중 제일 큰 값 : 정렬된 배열에서 첫 번째, 두 번째 인덱스 값 가져와서 곱하기.
//두 값 비교 후 리턴
if (answer > numbers[0] * numbers[1])
    return answer;
else
    return numbers[0] * numbers[1];
    }
}