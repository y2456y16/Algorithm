using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int count = 0;
        int zeroCount =0;
        
        foreach(var number in lottos)
        {
            for(int i=0; i<win_nums.Length; i++)
            {
                if(number == win_nums[i])
                {
                    count++;
                }
            }
            
            if(number == 0)
            {
                zeroCount++;
            }
        }
        
        switch(count)
        {
            case 0:
                answer[1]=6;
                break;
            case 1:
                answer[1]=6;
                break;
            case 2:
                answer[1]=5;
                break;
            case 3:
                answer[1]=4;
                break;
            case 4:
                answer[1]=3;
                break;
            case 5:
                answer[1]=2;
                break;
            case 6:
                answer[1]=1;
                break;
        }
        
        switch(count+zeroCount)
        {
            case 0:
                answer[0]=6;
                break;
            case 1:
                answer[0]=6;
                break;
            case 2:
                answer[0]=5;
                break;
            case 3:
                answer[0]=4;
                break;
            case 4:
                answer[0]=3;
                break;
            case 5:
                answer[0]=2;
                break;
            case 6:
                answer[0]=1;
                break;
        }
        
        return answer;
    }
}