   /*
   풀이방법:
   str2[0]번째 char와 str1의 char과 비교하여 동일하지 않을 경우 continue 동일할 경우 아래 코드 실행,
   해당하는 str1의 인덱스 부터 str2의 길이 만큼 나열한 문자열이 일치하는지 확인,
   동일할 경우 return 1 반환, 없으면 2 반환

    */
using System;

public class Solution
{
    public int solution(string str1, string str2)
    {
        int count = str2.Length;
        string test = "";
        for (int i = 0; i <= str1.Length - count; i++)
        {
            //str1의 i번째 문자와 str2의 첫 문자가 일치하지 않을 경우 넘어가기
            if (str1[i] != str2[0]) continue;

            //str1[i] ~ str[i+count]까지의 문자열이 str2와 일치하는지 확인 필요.
            //따라서 str1의 i~i+count까지의 문자열을 test에 복사
            for (int j = i; j < i+count; j++)
                test += str1[j];

            //Console.WriteLine($"test : {test}, str2 : {str2}");
            if (test == str2) return 1;
            else test = "";
        }
        return 2;
    }
}
