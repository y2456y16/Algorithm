using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        string[] str = s.Split(" ");
        List<int> strToInt = new List<int>();
        
        
        foreach(var word in str)
        {
            strToInt.Add(int.Parse(word));
        }
        
        int least = strToInt[0];
        int Max = strToInt[0];
        
        foreach(var numb in strToInt)
        {
            if(numb>=Max)
            {
                Max = numb;
            }
            else if(numb <= least)
            {
                least = numb;
            }
        }
        return answer = least + " " + Max;
    }
}