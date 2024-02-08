using System;
using System.Collections.Generic; //제네릭 사용시 필요


public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length ]; // 배열 원소 갯수를 안정하면 오류가 생긴다. 매우 중요
        
        //List<int> listInt = num_list;
         Stack<int> stackInt = new  Stack<int>();
      //  stackInt = num_list.ToList;
        // foreach(int i in listInt)
         //for(int i = 0; i<stackInt.count;i++) 
          for(int i = 0; i< num_list.Length ;i++) 
           {
               //answer = listInt.Pop();
             //  answer = stackInt.Pop();
              answer[i] = num_list[num_list.Length-1-i]; 
              //// Length는 대문자로 시작
              //// answer의 첫번째 == num_list.Length에서 -1, -i
              //// num_list.Length-1-i == 전체길이에서 -i를 하면 뒤 순번부터, -1은 answer 원소 갯수를 맞추기 위해
              
           }
        
        return answer;
    }
}