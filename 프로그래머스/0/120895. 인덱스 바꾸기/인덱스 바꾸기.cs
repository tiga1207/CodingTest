using System.Text;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        StringBuilder sb = new StringBuilder(my_string);

sb[num2] = my_string[num1];
sb[num1] = my_string[num2];

return sb.ToString();
    }
}