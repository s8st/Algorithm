using System;
using System.Linq;
//using System.Collections.Generic;




public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        var arr = s.Split(" ").ToList();

        while(arr.Contains("Z"))
        {
            arr.RemoveRange(arr.IndexOf("Z")-1, 2);
        }
        
        
        return answer =  arr.Sum(x=> Convert.ToInt32(x));
    }
}