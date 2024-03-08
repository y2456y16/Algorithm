using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr) {
        int answer = 0;
        
        Array.Sort(arr);
        int least = arr[0];
        int count = 1;
        int checkCount = 0;
        
        while(true)
        {
            int total = least * count;
            
            foreach(var number in arr)
            {
                if(total%number==0)
                    checkCount++;
            }
            
            if(checkCount == arr.Length)
            {
                answer = total;
                break;
            }
            
            checkCount = 0;
            count++;
        }
        return answer;
    }
}