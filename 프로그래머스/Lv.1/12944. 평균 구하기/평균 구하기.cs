public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        int sum=0;
        foreach(int i in arr)
        {
            sum += i;
            answer = (double)sum/arr.Length;
        }
        return answer;
    }
}