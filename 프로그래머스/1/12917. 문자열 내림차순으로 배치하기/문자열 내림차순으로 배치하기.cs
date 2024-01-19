using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int count =0;
        
        char[] arr = s.ToCharArray();
        

        
        Sort(arr);
        
        foreach(var text in arr)
        {
            answer += text;
        }
        
        
        return answer;
    }
    
    public void Sort(char[] arr)
    {
        for(int i=0; i<arr.GetLength(0); i++)
        {
            for(int j=0; j<arr.GetLength(0)-1; j++)
            {
                if((int)arr[j] <(int)arr[j+1])
                {
                    Swap(arr,j,j+1);
                }
                
            }
        }
    }
    
    public void Swap(char[] arr, int i, int j)
    {
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}