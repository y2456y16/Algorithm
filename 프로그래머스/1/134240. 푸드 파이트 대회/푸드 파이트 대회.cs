using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        
        
        for(int i=1; i<food.Length; i++)
        {
            if(food[i]==1)
            {
                continue;
            }
            else
            {
                for(int j=1; j<=food[i]/2; j++)
                {
                    answer += i;
                }
            }
        }

        answer +=0;
        
        for(int k=food.Length-1; k>=1; k--)
        {
            if(food[k]==1)
            {
                continue;
            }
            else
            {
                for(int l=1; l<=food[k]/2; l++)
                {
                    answer += k;
                }
            }
        }
        
        
        return answer;
    }
}