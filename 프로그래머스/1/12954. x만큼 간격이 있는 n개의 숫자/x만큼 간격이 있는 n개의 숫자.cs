public class Solution {
    public long[] solution(int x, int n) {
      //  long[] answer = new long[] {};
        
        // 2 * 1 = 2   2*2 = 4  2* = 6
       
       // for(int i=0;i <n;i++)
       // {
       //     answer[i] = x *(i+1);
       // }
        
     //     for(int i=0; i <n; i++)
     //   {
     //       answer[i] = x * (i+1);
     //   }
       
   //       for (int i = 0 ; i <  n ; i++)
 // {
     
     
  //    answer[i] = (long)x * ++i;

 // }
        
       // foreach(int i in n)
       // {
         //   answer.append(x);
                
        //}
        
    //    for (int i= 0; i < n;i++)
    //    {
    //        answer.append(x*++i);
     //   }
            
         
        //Solution0.cs(36,36): error CS0150: A constant value is expected
         // long[] answer = new long[n] {};
        long[] answer = new long[n];
            
            for(int i=0;i <n;i++)
        {
            answer[i] = (long)x *(i+1);
        }
        
        
        
        
        
        return answer;
    }
}