public class Solution {
    public long solution(long n) {
        long answer = 0;
        long count =1;
        
        while(count<=n && n>0)
        {
            if(n/count == count && n%count ==0)
            {
                return answer = (count+1)*(count+1);  
            }
            count++;
        }
        
        return answer = -1;
    }
}