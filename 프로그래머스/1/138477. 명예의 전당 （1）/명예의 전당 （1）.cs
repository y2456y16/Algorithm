using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> check = new List<int>();
        
        for(int i = 0; i < score.Length; i++)
        {
            if(check.Count == k)
            {
                if(check[0] > score[i])
                {
                    answer[i] = check[0];
                    continue;
                }
                check.RemoveAt(0);
            }
            
            check.Add(score[i]);
            check.Sort();
            answer[i] = check[0];
        }
        return answer;
    }
}