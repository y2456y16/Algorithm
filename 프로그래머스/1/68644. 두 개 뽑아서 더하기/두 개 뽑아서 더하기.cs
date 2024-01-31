using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer;
        int count=0;
        int[] temp = new int[numbers.Length * numbers.Length];
        
        Array.Sort(numbers);
        
        
        for(int i=0; i<numbers.Length-1; i++)
        {
            for(int j=i+1; j<numbers.Length; j++)
            {              
                temp[count] = numbers[i] + numbers[j];
                for(int k=0; k<count; k++)
                {
                    if(temp[k] == temp[count])
                    {
                        temp[count]=0;
                        count--;
                        break;
                    }
                }
                count++;
            }
            
        }

        answer = new int[count];
        
        for(int temp3 =0; temp3<count; temp3++)
        {
            answer[temp3] = temp[temp3];
        }
        
        Array.Sort(answer);
        return answer;
    }
}