using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] prices) {
          
        int[] answer = new int[prices.Length];

        Queue<int> queue = new Queue<int>(prices);
   
        
        for(int i=0; i<prices.Length; i++)
        {
            int time=0;                                         //시간
            int temp = queue.Dequeue();                         //현재 가격
            
            for(int j=i+1; j<prices.Length; j++)
            {
                time++;                                        
                
                if(temp > prices[j] || j == prices.Length-1)    
                {
                    answer[i] = time;
                    break;    
                }
            }
        }
        return answer;
    }
}