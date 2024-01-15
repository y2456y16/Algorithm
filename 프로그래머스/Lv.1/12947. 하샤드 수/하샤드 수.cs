public class Solution {
    public bool solution(int x) {
        bool answer = true;
        
        int[] hashad;
        int temp = x;
        int count =0;
        int total =0;
        
        while(temp >0)
        {
            temp = temp/10;
            count++;
        }
        
        hashad = new int[count];
        temp = x;
        
        for(int i=0; i<count; i++)
        {
            hashad[i] = temp%10;
            total += temp%10;
            temp = temp/10;  
        }
        
        if(x % total == 0)
        {
            return answer = true;
        }
        else
        {
            return answer = false;
        }
        
    }
}