using System;

public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        
        int number = phone_number.Length;
        
        for(int i=0; i<phone_number.Length; i++)
        {
            if(i>phone_number.Length-5)
            {
                answer += phone_number.Substring(i,1);
            }
            else
            {
                answer += "*";
            }
        }
        
        return answer;
    }
}