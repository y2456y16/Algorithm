using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int[] weight = new int[number + 1];
        for(int i = 1; i <= number; i++)
        {
            for(int j = 1; j*j <= i; j++)
            {
                if (i % j == 0)
                {
                    if (i / j == j)
                    {
                        weight[i]++;
                    }
                    else
                    {
                        weight[i] += 2;
                    }
                }
            }
        }
        
        for(int i = 1; i <= number; i++)
        {
            if(weight[i] > limit)
                answer += power;
            else
                answer += weight[i];
        }
        
        return answer;
    }
}