public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        
        if(a==b)
            return answer = a;
        else if(b>a)
        {
            for(int i=a; i<=b; i++)
            {
                answer += i;
            }
            return answer;
        }
        else if(a>b)
        {
            for(int i=b; i<=a; i++)
            {
                answer += i;
            }
            return answer;
        }
        
        return answer;
    }
}