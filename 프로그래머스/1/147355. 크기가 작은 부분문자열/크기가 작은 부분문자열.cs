using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        int plength = p.Length;
        string temp = "1";
        int temp1;
        int temp2;
        
        long temp3;
        long temp4;
        
        if(long.TryParse(p, out temp4))
        {}
        
        
        for(int i=0; i<t.Length-plength+1; i++)
        {
            temp = t.Substring(i,plength);
            if(long.TryParse(temp, out temp3))
            {
                if(temp3 <= temp4)
                    answer++;
            }            
            
        }
        return answer;
    }
}