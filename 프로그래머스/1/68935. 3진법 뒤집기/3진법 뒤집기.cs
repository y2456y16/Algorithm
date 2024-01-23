using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        int temp = n;
        int total =0;
        int count =0;
        
        while(temp>0)
        {
            count++;
            temp = temp/3;            
        }
        
        int[] arr = new int[count];
        total = n;
        
        
        for(int i=count-1; i>=0; i--)
        {
            arr[i] = total%3;
            total = total/3;         
        }
        
        
        
        for(int k=0; k<count/2; k++)
        {
            int temp2 = arr[count-1-k];
            arr[count-1-k] = arr[k];
            arr[k] = temp2;
        }

        
        for(int j=0; j<count; j++)
        {
            answer += arr[j]*(int)Math.Pow(3,(count-j-1));
        }
        
        return answer;
    }

}