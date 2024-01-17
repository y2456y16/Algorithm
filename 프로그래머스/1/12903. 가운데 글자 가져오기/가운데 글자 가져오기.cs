using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int all = s.Length;
        
        if(s.Length%2 ==0)
        {
            answer = s.Substring(all/2-1,2);
        }
        else
        {
            answer = s.Substring(all/2,1);
        }
        
        return answer;
    }
}