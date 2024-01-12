public class Solution {
    public int solution(int n) {
        int answer = 0;
        int count =0;
        int[] yaksu = new int[3000];
        
        
        for(int i=1; i<=n; i++)
        {
            if(n%i ==0)
            {
                yaksu[count] = i;
                answer += yaksu[count];
                count++;
            }
        }

        
        return answer;
    }
}