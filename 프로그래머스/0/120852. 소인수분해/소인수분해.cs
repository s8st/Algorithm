using System;
using System.Linq;
using System.Collections.Generic;


public class Solution {
    public int[] solution(int n) {
        
        int[] answer = new int[] {};
        
         

        List<int> arr = new List<int>();            
        for(var i=2; i<= n; i++)
        {
            while(n % i==0)
            {
                arr.Add(i);
                n = n / i;
            }
        }

        if(n != 1) arr.Add(n);

      
        return answer = arr.Distinct().ToArray();
        
      
    }
}