public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        foreach(char c in s)
        {
            if(c != ' ')
            {
                int temp = (int)c;
                if(temp>= 65 && temp <=90)
                {
                    for(int i=1; i<=n; i++)
                    {
                        temp++;
                        if(temp>90)
                        {
                            temp=65;
                        }
                    }
                }
                else if(temp>=97 && temp <=122)
                {
                    for(int i=1; i<=n; i++)
                    {
                        temp++;
                        if(temp>122)
                        {
                            temp=97;
                        }
                    }
                }

                answer += (char)temp;
            }
            else
            {
                answer += ' ';
            }
        }
        
        
        return answer;
    }
}