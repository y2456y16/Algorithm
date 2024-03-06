using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        bool checkFind = false;
        
        int total = brown + yellow;
        
        for(int i=1; i<=total; i++)
        {
            if(total%i==0)
            {
                int width = i;
                int height = total/i;
                
                for(int j=1; j<=yellow; j++)
                {
                    if(yellow%j==0)
                    {
                        int ywidth = j;
                        int yheight = yellow/j;
                        
                        if(ywidth == width-2 && yheight == height-2)
                        {
                            answer[0] = (width>height)? width : height;
                            answer[1] = (width<=height)? width : height;
                            checkFind = true;
                            break;
                        }
                        else if(ywidth == height-2 && yheight == width-2)
                        {
                            answer[0] = (width>height)? width : height;
                            answer[1] = (width<=height)? width : height;
                            checkFind = true;
                            break;
                        }
                    }
                    
                }
            }
            if(checkFind==true)
                break;
        }
        return answer;
    }
}