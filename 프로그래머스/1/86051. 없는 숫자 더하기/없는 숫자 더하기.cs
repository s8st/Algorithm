using System;

public class Solution {
    public int solution(int[] numbers) {
        //int answer = -1;
        int answer = 0;
        int arrSum=0;
        int numbersSum= 0;
        int[] arrNumbers = {1,2,3,4,5,6,7,8,9};
      //  foreach(int i in numbers)
     //   {
     //       arrNumbers = i;
      //  }
        foreach(int x in numbers)
        {
            numbersSum += x;
        }
        foreach(int x in arrNumbers)
        {
             arrSum += x;
        }
        
        return answer = arrSum - numbersSum;
    }
}