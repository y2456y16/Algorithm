using System;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        
        for(int i=0; i<number.GetLength(0); i++)
        {
            for(int j=i; j<number.GetLength(0); j++)
            {
                for(int k=j; k<number.GetLength(0); k++)
                {
                    if(i!=j && i!=k && j!=k)
                    {
                        if(number[i]+number[j]+number[k] == 0)
                            answer++;
                    }
                }
            }
        }
        return answer;
    }
}