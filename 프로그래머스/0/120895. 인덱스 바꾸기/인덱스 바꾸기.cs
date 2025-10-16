using System.Text;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        StringBuilder sb = new StringBuilder();
sb.Append(my_string);

char tem = sb[num2];
sb[num2] = sb[num1];
sb[num1] = tem;

return sb.ToString();
    }
}