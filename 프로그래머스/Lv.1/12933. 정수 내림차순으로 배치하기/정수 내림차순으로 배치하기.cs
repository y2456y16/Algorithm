using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        long[] solve;
        long temp=n;
        int count=0;
        
        while(temp>0)
        {
            temp = temp/10;
            count++;
        }
        
        solve = new long[count];
        
        for(int i=0; i<count; i++)
        {
            solve[i] = n%10;
            n = n/10;
        }
        
        Sort(solve);
        
        for(int j=0; j<count; j++)
        {
            answer += solve[j] * (long)Math.Pow(10,count-1-j);
        }
        
        return answer;
    }

    public void Sort(long[] a)
    {
        int count =0;
        while(count<a.GetLength(0)-1)
        {
            for(int i=0; i<a.Length-1; i++)
            {
                if(a[i] < a[i+1])
                {
                    Swap(a,i,i+1);
                }
            }
            count++;
        }
    }
    
    public void Swap(long[] arr, int i, int j)
    {
        long temp = arr[j];
        arr[j] = arr[i];
        arr[i] = temp;
    }
}