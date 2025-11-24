public class Solution
{
    public string solution(string s)
    {
        string[] str = s.Split(' ');

        int min = int.MaxValue;
        int max = int.MinValue;

        foreach(var a in str)
        {
            int num = int.Parse(a);

            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }
        return $"{min} {max}";
    }
}