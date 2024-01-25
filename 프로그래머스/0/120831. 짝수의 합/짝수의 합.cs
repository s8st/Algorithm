using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
      //  for(int i=0;i<=n;i++)
       // foreach(int i in n)
     //   {
         //   if(n%2==0)
         //   {answer += n;}
     //   }
        
           for(int i=0;i<=n;i++)
     
        {
            if(i%2==0)
            {answer += i;}
        }
        
        return answer;
    }
}