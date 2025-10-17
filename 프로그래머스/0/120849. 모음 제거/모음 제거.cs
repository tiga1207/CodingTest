using System;
using System.Text;

public class Solution {
    public string solution(string my_string) {
         StringBuilder sb = new StringBuilder();
 string mo = "aeiou";
 int result = 1;

 for(int i =0; i< my_string.Length; i++)
 {
     for(int j =0; j<mo.Length; j++)
     {
         if (my_string[i] == mo[j])
             result *= 0;
     }

     if (result == 1)
         sb.Append(my_string[i]);
     result = 1;

 }

 return sb.ToString();
    }
}