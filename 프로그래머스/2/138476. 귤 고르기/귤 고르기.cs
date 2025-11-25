using System;

public class Solution {
    public int solution(int k, int[] tangerine)
        {
            int answer = 0;
            //크기 순 정렬 
            Array.Sort(tangerine);

            int max = tangerine[tangerine.Length - 1];
            int min = tangerine[0];

            // 새로운 배열 만들어서 같은 숫자에 대한 개수가 들어있는 배열 만들기
            int[] count = new int[max - min + 1];
            foreach(var num in tangerine)
            {
                count[num - min]++;
            }

            //새로운 배열 뒤집기(내림차순)
            Array.Sort(count);
            Array.Reverse(count);

            int sum = 0;
            //포문으로 배열 0번째 부터 더해가며 k와 크기를 비교한 후,
            //만약 합한 값이 같거나 크면 그 즉시 포문 종료 후 인덱스 값 +1 반환
            for(int i=0; i< count.Length; i++)
            {
                sum += count[i];
                answer = i + 1;

                if (sum >= k)
                    break;
            }


            return answer;
        }
}