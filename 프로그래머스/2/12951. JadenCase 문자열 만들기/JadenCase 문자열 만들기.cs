public class Solution {
    public string solution(string s)
{
    string answer = "";
    //공백에 따른 문자열 분리
    string[] str = s.Split(' ');


   for(int i =0; i< str.Length; i++)
    {
        string text = str[i];
        

        if(text.Length>0)
        {
            char a = text[0];

            if (a >= 97)
                a = (char)(a - 32);

            str[i] = a + text.Substring(1).ToLower();
        }

        if (i == str.Length-1)
        {
            answer += str[i];
            continue;
        }
        answer += str[i] + " ";

    }
    return answer;
}
}