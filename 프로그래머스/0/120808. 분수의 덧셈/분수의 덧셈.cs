using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        // numer1/ denom1 + numer2/ denom2
//분자: numer1 * denom2 + numer2 * denom1
int newNumer = numer1 * denom2 + numer2 * denom1;
//분모: denom1 * denom2
int newDenom = denom1 * denom2;
//둘 사이의 최대 공약수를 구하고 나눈 값을 반환하면 됨. -> 유클리드 호제법
/*
1. 두 자연수 a, b가 주어졌을 때, a % b = r이라고 하자. 만약 r = 0 이라면 b는 최대 공약수이다.
2.만약 r ! =0 이라면 a를 b로, b를 r로 바꿔 1의 과정을 반복
*/
int a = newNumer;
int b = newDenom;
while(b != 0)
{
    int r = a % b;
    a = b;
    b = r;
}

int gcd = a; // 왜 b가 아니라 a냐? while문에서 b의 값을 a로 넘겨줬기 때문.



int[] answer = new int[] {newNumer / gcd , newDenom / gcd };
return answer;
    }
}