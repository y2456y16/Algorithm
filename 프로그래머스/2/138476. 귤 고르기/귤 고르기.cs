using System;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        Array.Sort(tangerine);
        int[] possibleNumb = new int[tangerine[tangerine.Length-1]+1];
        
        
        int count = 0;
        int previousItem = tangerine[0];
        
        foreach(var item in tangerine)
        {
            if(item == previousItem)
            {
                possibleNumb[count]++;
            }
            else
            {
                previousItem = item;
                count++;
                possibleNumb[count]++;
            }
        }
        
        Array.Sort(possibleNumb);
        count = 0;
        
        for(int i=possibleNumb.Length-1; i>=0; i--)
        {
            answer += possibleNumb[i];
            count++;
            
            if(answer>=k)
            {
                answer = count;
                break;
            }
                
        }
        
        return answer;
        
    }
}