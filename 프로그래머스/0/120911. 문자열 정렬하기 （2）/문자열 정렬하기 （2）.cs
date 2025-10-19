using System.Text;

public class Solution {
    public string solution(string my_string)
        {
            StringBuilder sb = new StringBuilder();

            //대문자 -> 소문자로 치환
            foreach (var str in my_string)
            {
                //대문자일 경우
                if (str - 'Z' <= 0)
                {
                    sb.Append((char)(str + 32));
                }
                else
                {
                    sb.Append(str);
                }
            }
            

            //치환된 문자열 정렬
            for(int i =0; i<sb.Length-1; i++)
            {
                for(int j= i+1; j<sb.Length;j++)
                {
                    if(sb[i] > sb[j])
                    {
                        char temp = sb[i];
                        sb[i] = sb[j];
                        sb[j] = temp;
                    }
                }
            }

            return sb.ToString();
        }
    }