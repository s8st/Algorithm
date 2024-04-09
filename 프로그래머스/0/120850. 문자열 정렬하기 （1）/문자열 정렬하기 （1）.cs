using System;

public class Solution {
    public int[] solution(string my_string) {
        
        
        int j = 0;
        for(int i = 0; i < my_string.Length; i++)
        {
            if(Char.IsDigit(my_string[i])==true)
                j++;
        }
        
        int[] answer = new int[j];
        int k = 0;
        for(int i = 0; i < my_string.Length; i++)
        {
            if(Char.IsDigit(my_string[i]))
            {
                answer[k] = int.Parse(my_string[i].ToString());
                k++;
            }
        }

        Array.Sort(answer);



        
        return answer;
    }
}