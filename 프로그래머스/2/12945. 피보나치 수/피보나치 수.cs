/* //처음에 작업했던 코드
public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        answer = fibonaci(n);

        return answer;
    }
    
    
    public int fibonaci(int n)
    {
        switch(n)
        {
            case 0:
                return 0;
            case 1:
                return 1;
            default:
                return fibonaci(n-1) + fibonaci(n-2);
        }
    }  
}
*/
public class Solution {
    public int solution(int n) {
        int answer = 0;
        int fist = 0;
        int second = 1;
        
        for(int i=2; i<=n; i++)
        {
            answer = (fist+second)%1234567;
            fist = second %1234567 ;
            second = answer ;
        }
        answer = answer;
        
        return answer;
    }
}