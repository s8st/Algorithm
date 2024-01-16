using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer=0;
        int i =0;
         foreach (int x in numbers)
         answer += x;
        return answer/numbers.Length;
    }
}