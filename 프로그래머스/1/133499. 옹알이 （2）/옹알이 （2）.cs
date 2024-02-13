using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string str = "";
        
        for(int i = 0; i < babbling.Length; i++)
        {
            babbling[i] = babbling[i].Replace("aya", "1");
            babbling[i] = babbling[i].Replace("ye", "2");
            babbling[i] = babbling[i].Replace("woo", "3");
            babbling[i] = babbling[i].Replace("ma", "4");
            
            babbling[i] = babbling[i].Replace("11", "x");
            babbling[i] = babbling[i].Replace("22", "x");
            babbling[i] = babbling[i].Replace("33", "x");
            babbling[i] = babbling[i].Replace("44", "x");
            
            str = babbling[i].Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "");
            
            if(str == "")
            {
                answer++;
            }
        }
        return answer;
    }
}