using System;

public class Solution {
    public int solution(int balls, int share) {
        
          int answer = 1;
        int div = 1;
        int multyCnt = 1;
        while(multyCnt <= share || div <= share)
        {
            if(0 == answer % div && div <= share)
            {
                Console.WriteLine("{0} / {1} = {2}", answer, div, answer / div);
                answer /= div;
                ++div;
            }
            else
            {
                Console.WriteLine("{0} * {1} = {2}", answer, balls, answer * (balls));
                answer *= balls--;                
                ++multyCnt;
            }
        }



        
        return answer;
    }
}