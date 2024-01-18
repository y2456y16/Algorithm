using System;

public class Solution {
    public int solution(int[] a, int[] b) {
        int answer = 0;
        
        if(a.Length > b.Length)
        {
            for(int i=0; i<b.Length; i++)
            {
                answer += (a[i] * b[i]);
            }        
        
        }
        else
        {
            for(int i=0; i<a.Length; i++)
            {
                answer += (a[i] * b[i]);
            }    
        }
        
        return answer;
    }
}