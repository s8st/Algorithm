using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
      
        for(int j = 1; j <= n; j++)
         {
            int a = 0;
            for(int i = 1; i <= j; i++)
        {
            if(j % i == 0)
                a++;
        }
            if(a >= 3)
                answer++;
        }
        
        return answer;
    }
}