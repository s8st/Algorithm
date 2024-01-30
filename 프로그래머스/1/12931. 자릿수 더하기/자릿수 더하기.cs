using System;

public class Solution {
    public int solution(int n) {
        int answer=0;
       // foreach(int i in n){
       //     answer += i;
       // }
     //================================   
     //   for(int i=0;i<n.Length;i++)
     //   {
      //      answer += n[i];
      //  }
     //================================      
     
   //     string nStr = n.ToString();
   //      for(int i=0;i<nStr.Length;i++)
   //     {
   //       answer += nStr[i];
   //     }
        
      //================================     
           
     //   string nStr = n.ToString();
     //   foreach(char i in nStr)
     //   {
     //       answer += (int)i;
    //   }
      
        
        //================================     
        
        while(n>0)
        {
          answer += n%10;
          n=n/10   ;
        }
       
        
        return answer;
    }
}