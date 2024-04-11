using System;
using System.Text.RegularExpressions;




public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        
        // answer = my_string.Where(x => char.IsNumber(x)).Sum(x => Int32.Parse(x.ToString());
        
        string result = Regex.Replace(my_string, @"[A-Za-z]", "");
        
        for(int i = 0; i < result.Length; i++)
        {
            answer += result[i] - '0';
        }



        
        return answer;
    }
}