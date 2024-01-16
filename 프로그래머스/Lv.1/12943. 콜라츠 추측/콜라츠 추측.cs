public class Solution {
    public int solution(int num) {
        int answer = 0;
        int count=0;
        
        if(num==1)
            return answer =0;
        else
        {
            while(true)
            {
                if(num%2 == 0)
                {
                   num = num/2;
                }
                else if(num%2 == 1)
                {
                    num = num *3 +1;
                }
                count++;
        
                if(num ==1)
                {
                    answer=count;
                    break;
                }
                else if(count>=500)
                {
                    answer =-1;
                    break;
                }
            }
        }
    return answer;
    }
}