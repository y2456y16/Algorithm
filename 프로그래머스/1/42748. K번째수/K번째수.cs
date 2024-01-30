using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        
        for(int numb=0; numb<answer.Length; numb++)
        {
            int i = commands[numb,0];
            int j = commands[numb,1];
            int k = commands[numb,2];
            
            int[] temp = new int[j-i+1];
            int count =0;
            
            for(int index=i-1; index<j; index++)
            {
                temp[count] = array[index];
                count++;
            }
            
            Array.Sort(temp);
            
            answer[numb] = temp[k-1];
            
        }        
        
        return answer;
    }
}