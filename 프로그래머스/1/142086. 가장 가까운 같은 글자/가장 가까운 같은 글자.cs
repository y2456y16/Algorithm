using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        string[] temp = new string[s.Length];
        
        answer[0] = -1;
        
        for(int i=0; i<s.Length; i++)
        {
            int count=0;
            temp[i] = s.Substring(i,1);
            for(int j=0; j<i; j++)
            {
                if(temp[j] == temp[i])
                {
                    answer[i] = i-j;
                }
                else if(temp[j]!=temp[i] && answer[i]==0)
                {
                    answer[i] = -1;
                }
            }
        }
        
        return answer;
    }
}