using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        //양의 정수 제곱근인지 어떻게 확인하지??
        // n = Math.Sqrt(x) 
        //int x;
        
    //    if(Math.Sqrt(n) == n)
   //     {
   //         answer = Math.Pow(n+1);
    //    }
    //    else 
    //    {
    //        answer = -1;
    //    }
     //       return answer;
        
         var r = Math.Sqrt(n);
        return (n % r == 0) ? (long)Math.Pow(r + 1, 2) : -1;
        
    }
}