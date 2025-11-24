public class Solution {
    public string solution(string s)
{
    string[] str = s.Split(' ');

    int[] num = new int[str.Length];

    for(int i =0; i<str.Length; i++)
    {
        num[i] = int.Parse(str[i]);
    }

    int min = num[0];
    int max = num[0];
    for(int i =0; i<num.Length; i++)
    {
        for(int j = i+1; j<num.Length; j++)
        {
            if (num[j] > max)
                max = num[j];
            if (num[j] < min)
                min = num[j];
        }
    }
    string answer = $"{min} {max}";
    return answer;
}
}