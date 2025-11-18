using System;
using System.Text;

public class Solution
    {
        public string solution(int n)
        {
            StringBuilder sb = new StringBuilder();
            if (n == 1000)
            {
                sb.Append(Converter(n / 1000));
                sb.Append(Converter(n % 1000 / 100));
                sb.Append(Converter(n % 1000 % 100 / 10));
                sb.Append(Converter(n % 1000 % 100 % 10 /1));
                return sb.ToString();
            }
            else if(n>=100 && n<1000)
            {
                sb.Append(Converter(n / 100));
                sb.Append(Converter(n % 100 / 10));
                sb.Append(Converter(n % 100 % 10 / 1));
                return sb.ToString();
            }
            else if (n >= 10 && n < 100)
            {
                sb.Append(Converter(n / 10));
                sb.Append(Converter(n % 10 / 1));
                return sb.ToString();

            }
            else
            {
                sb.Append(Converter(n / 1));
                return sb.ToString();
            }
        }

        public char Converter(int a)
        {
            return (char)(a+97);
        }}