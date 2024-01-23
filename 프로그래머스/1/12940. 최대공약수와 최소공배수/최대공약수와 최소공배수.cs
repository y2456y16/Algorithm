public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        
        int LeastD = Div(n,m);
        int LeastM = LeastMulti(n,m);

        answer[0] = LeastD;
        answer[1] = LeastM;
        
        return answer;
    }
    
    public int Div(int a, int b)
    {
        
        if(a>b)
        {
            for(int i=a; i>0; i--)
            {
                if(a%i==0 && b%i==0)
                {
                    return i;
                }
            }
        }
        else
        {
            for(int i=b; i>0; i--)
            {
                if(a%i==0 && b%i==0)
                {
                    return i;
                }
            }
        }
        
        return 1;
        
    }
    
    public int LeastMulti(int numb1, int numb2)
    {
        if(numb1>numb2)
        {
            for(int i=1; i<=numb2; i++)
            {
                if((numb1*i)%numb2==0)
                {
                    return numb1*i;
                }
            }
        }
        else
        {
            for(int i=1; i<=numb1; i++)
            {
                if((numb2*i)%numb1==0)
                {
                    return numb2*i;
                }
            }        
            
        }
        
        return numb2*numb1;
    }
}
