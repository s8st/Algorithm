using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        // 7의 배수
        // 7로 나눈 나머지가 있다면 +1
        // quotient  remainder
        
        int quotient = n / 7 ;
        int remainder = n% 7;
        
        if(remainder == 0)
        {
             return quotient;
        }
        else if(remainder != 0)
        {
            quotient++; 
        }
        answer = quotient;
        return answer;
    }
}