public class Solution {
    public bool solution(string s) {
       
       {

    bool answer;

    //숫자 tryParse
    //문자열길이?? split? 

    int num;
    bool isNum = int.TryParse(s, out num);


    // string[] sArr = s.Split("");

    //if (sArr.Length == 4 | sArr.Length == 6)
    if (s.Length == 4 | s.Length == 6)
    {
        if (isNum == true)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }


    }
    else
    {
        answer = false;

    }

    return answer;
}
    }
}