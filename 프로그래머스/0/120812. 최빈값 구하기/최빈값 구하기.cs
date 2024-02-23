// [출처] [ 212. 최빈값 구하기 ]|작성자 거북이
// https://blog.naver.com/abcdxsky/223219533687
///////////////
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int[] arr = new int[1000];
       
        foreach(int n in array)
        {
            // array 원소를 인덱스로 사용..?
            ++arr[n];
        }
        
        // Max 최대값?
        int max = arr.Max();
        // Array에서 IndexOf는 첫번째 인자가 있는 곳의 번호를 알려줌
        int max_idx = Array.IndexOf(arr, max);
        
      //  Console.WriteLine("{0} {1}", max, max_idx);
        answer = max_idx;
       
        // 최빈값이 여러 개일 때 
        for(int i = 0; i < arr.Length; ++i)
        {
            // 최빈값이 여러 개면 -1인데... 이 부분은 어렵다
            if(max_idx != i && arr[max_idx] == arr[i])
            {
                answer = -1;
            }
        }
        return answer;
    }
}
