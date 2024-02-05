using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "";
        int temp1 =0;
        int temp2 =0;
        
        for(int i=0; i<goal.Length; i++)
        {
            int count =0;
            
            for(int j=0; j<=temp1 && j<cards1.Length; j++)
            {
                if(goal[i] == cards1[j])
                {
                    count = 1;
                    temp1++;
                    break;
                }
            }
            
            for(int k=0; k<=temp2 && k<cards2.Length; k++)
            {
                if(goal[i] == cards2[k])
                {
                    count = 1;
                    temp2++;
                    break;
                }
            }
            
            
            if(count==0)
            {
                return answer = "No";
            }

        }
        return answer = "Yes";
    }
}