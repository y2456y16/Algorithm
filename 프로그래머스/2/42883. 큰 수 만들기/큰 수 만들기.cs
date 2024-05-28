using System;
using System.Text;
public class Solution {
    public string solution(string number, int k) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        
        int n=number.Length-k;
        
        //자리수 만큼 반복 
        for(int i=0, last=-1; i<n; i++) 
        {
            char max = '0'; 
            // idx 다음 인덱스부터 k+i와 작거나 같을 때 까지 반복한다. 
            for(int j=last+1; j<=k+i; j++)
            {
                //비교해서 max값 넣어주기
                if(max<number[j])
                {
                    max = number[j];
                    last = j;
                }
            }
            sb.Append(max); //StringBuilder에 추가한다.
        }
        
        answer = sb.ToString(); 
        
        return answer;
    }
}