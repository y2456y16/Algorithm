using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string temp = "";

        string[] words = s.Split(' ');
        
        int count =1;
        
        for(int i=0; i<words.GetLength(0); i++)
        {
            for(int j=1; j<=words[i].Length; j++)
            {
                
                if((j+1)%2==0)
                {
                    temp = words[i];
                    temp = temp.Substring(j-1,1);
                    answer += temp.ToUpper();
                }
                else
                {
                    temp = words[i];
                    temp = temp.Substring(j-1,1);
                    answer += temp.ToLower();
                }
            }
            
            if(i!=words.GetLength(0)-1)
            {
                answer += " ";
            }     
        }
        
        
        return answer;
    }
}