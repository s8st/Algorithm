using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        
      //  int[] answer = new int[] {};
        
        // 공통 분모로 만들기?
        // 분수를 더하기
        // 기약분수로 만들기, 최대공약수를 먼저 구하기
        // 최대공약수?
        /////////////////////////////////
        
    //    int denom3 = denom1 * denom2;
    //    int numer3 = 0;
        
        
      //  if(denom1 < denom2)
      //  {            numer3 = (denom3 / denom2)*numer1;        }
     //   else        {            numer3 = (denom3 / denom1)*numer2;        }
        
      //answer[0] = numer3;
      //answer[1] = denom3;
       // answer += numer3;
       // answer += denom3;
        //Solution0.cs(29,9): error CS0019: Operator `+=' cannot be applied to operands of type `int[]' and `int'
        //Solution0.cs(30,9): error CS0019: Operator `+=' cannot be applied to operands of type `int[]' and `int'
        
         //answer = numer3;
         //answer = denom3;
        //Solution0.cs(34,19): error CS0029: Cannot implicitly convert type `int' to `int[]'
        //Solution0.cs(35,19): error CS0029: Cannot implicitly convert type `int' to `int[]'
        
       //  answer = answer[0]{numer3};
        // answer = answer[1]{denom3};
        //Solution0.cs(39,27): error CS1525: Unexpected symbol `{'
        //Solution0.cs(39,35): error CS1002: ; expected
        //Solution0.cs(40,27): error CS1525: Unexpected symbol `{'
        //Solution0.cs(40,35): error CS1002: ; expected
        
        
         //answer = (int[])numer3;
         //answer = (int[])denom3;
        //Solution0.cs(47,26): error CS0030: Cannot convert type `int' to `int[]'
        //Solution0.cs(48,26): error CS0030: Cannot convert type `int' to `int[]'
        
        
    //    answer[] += {numer3,denom3};
          
        
       // return answer ={numer3,denom3};
     //    return answer;
        
    //}   
        
        ///////////////////////////////////////////////////////////////////////////////
           int[] answer = new int[] { (numer1 * denom2) + (numer2 * denom1), denom1 * denom2 };
        int gcd = GCD(answer[0], answer[1]);
        return new int[] { answer[0] / gcd, answer[1] / gcd };
    }
    
    int GCD(int num1, int num2)
    {
        if (num2 == 0) return num1;
        else return GCD(num2, num1 % num2);
    }
    
   // return answer;
// [출처] LV.0 분수의 덧셈|작성자 UMRHI


    
        
        
        
    
}