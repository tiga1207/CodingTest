public class Solution {
    public int solution(int n)
        {
            int num = 1234567;

            int a = 0, b = 1;

            for(int i=0;i<n; i++)
            {
                int temp = (a + b) % num;

                a = b;
                b = temp;

            }
            return a;
        }
}