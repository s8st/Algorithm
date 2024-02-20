using System;
using System.Collections.Generic;    // List<T>는 제네릭 컬렉션이므로 작성해야함



public class Solution {
    public int[] solution(int n) {
        // int[] answer = new int[] {};
      //  int[] answer = new int[n-1];
        
     //   int[] odd = new int[] {};
        //홀수 구하기부터
    //   for(int i;i<n.Length;i++)
   //    {
   //     if(n % 2 ==1)
    //    {
    //        odd = n[i];
     //   }
        
    //   }
     //   answer = odd;
        
      //  return answer;
        
        
        
        
        
        int[] answer = new int[] {};
        List<int> temp = new List<int>();    // 리스트로 선언
        
        for(int i = 1; i <= n; i++) {
            if(i % 2 == 1) { temp.Add(i); }
        }

        temp.Sort();    // 오름차순 정렬
        answer = temp.ToArray();
        return answer;
        // [출처] [프로그래머스 C#] 코딩테스트 입문: 짝수는 싫어요|작성자 유디
        //유디님 감사합니다


        
        
        
    }
}