using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
//        return -1;
       long answer =0;
        long result =0;
        for(int i =0;i <= (long)count; i++)
        {
           // money -= price*i   ;
            // money = money - price*i   ;
           //  answer = (long)money - price * i;
            result +=  price * i;
        }
           //if(money == 0)
        if(money > result)
           {
            answer = 0;   
           }
            else
            {
                //answer = (long)money * -1;
               // answer = Math.Abs(money);
                //answer = money - result;
                answer = result- money ;
                
            }
        
        return answer;
    }
}