using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        
        
        while(s!="1")
        {
            int eraseZeroCount = 0;
            int leftCount =0;
            
            for(int i=0; i<s.Length; i++)
            {
                if(s[i]=='0')
                {
                    eraseZeroCount++;
                }
                else if(s[i]=='1')
                {
                    leftCount++;
                }
            }
            
            s = leftCount.ToString();

            int from = 10;
            int to = 2;
 
            s = Convert.ToString(Convert.ToInt32(s, from), to);
            
            answer[0]++;
            answer[1] += eraseZeroCount;
  
        }

        return answer;
    }
}