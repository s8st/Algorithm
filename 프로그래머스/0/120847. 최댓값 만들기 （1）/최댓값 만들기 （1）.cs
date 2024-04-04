using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        
         Array.Sort(numbers);
        int a = numbers.Length;
  
        answer = numbers[a-1] * numbers[a-2];
        
        return answer;
    }
}



