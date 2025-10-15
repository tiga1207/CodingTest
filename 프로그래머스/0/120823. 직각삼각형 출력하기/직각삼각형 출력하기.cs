using System;

/*
풀이방법:
n을 입력 받았을 경우, 행은 총 n개이며 n번째 행은 n개의 "*"을 출력해야 함.
n번째까지 루프를 돌아야 하며, 실행 당 i +1 개의 "*"을 출력해야 함.
*/
public class Example
{
    public static void Main()
{
    String[] s;

    Console.Clear();
    s = Console.ReadLine().Split(' ');

    int n = Int32.Parse(s[0]);

    for(int i = 0; i<n; i++)
    {
        for(int j= 0; j<i+1; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
}