using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        
        int[] choice = new int[] {0,1,2,3,4,5,6,7,8,9};
        
        for(int i=0; i<numbers.GetLength(0); i++)
        {
           for(int j=0; j<choice.GetLength(0); j++)
           {
               if(choice[j] == numbers[i])
               {
                   choice[j] =0;
               }
           }
        }
        
        foreach (int a in choice)
        {
            answer += a;
        }
        
        return answer;
    }
}