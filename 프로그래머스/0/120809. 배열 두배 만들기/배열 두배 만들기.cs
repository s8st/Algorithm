using System;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
       // int[] result = new int[] {};
        
      //  foreach(int i in numbers)
        for(int i=0;i<numbers.Length;i++)
        {
            //answer[i] = answer[++i]*2;
          //  answer[i] = answer[i]*2;
         //   answer[i] *=2;
              // answer[i] = numbers[i] *2;
            // answer[i] = numbers[i] *2;
            numbers[i] = numbers[i] *2;
            
            
        }
        
        return answer = numbers;
    }
}