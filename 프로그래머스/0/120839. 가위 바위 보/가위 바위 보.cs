/*
풀이방법:
가위(2)를 이기려면 바위(0)를,
위(0)를 이기려면 보(5)를,
보(5)를 이기려면 가위(2)를 내야 함.

우선, 가위바위보 하나를 입력받으면 이기는 수를 반환하는 함수 만들기
문자열을 For문으로 인덱스 하나씩 돌면서 함수 호출 후 결과 값을 answer에 추가하기

 */
using System;

public class Solution
{
    public string solution(string rsp)
    {
        string answer = "";

        for (int i = 0; i < rsp.Length; i++)
        {
            answer+=Win(rsp[i]);
        }


        return answer;
    }

    public string Win(char input)
    {
        string result = "";
        switch (input)
        {
            case '2':
                result = "0";
                break;
            case '0':
                result = "5";
                break;
            case '5':
                result = "2";
                break;
        }
        return result;
    }
}