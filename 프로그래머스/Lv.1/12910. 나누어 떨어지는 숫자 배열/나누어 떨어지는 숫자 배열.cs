public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer;
        int countLength =0;
        int count=0;
        
        for(int j=0; j<arr.Length; j++)
        {
            if(arr[j]%divisor ==0)
            {
                countLength++;
            }
            
            if(j==arr.Length-1 && countLength==0)
            {
                answer = new int[1];
                answer[countLength]=-1;
                return answer;
            }
        }
        
        answer = new int[countLength];
        
        for(int i=0; i<arr.Length; i++)
        {
            if(arr[i]%divisor ==0)
            {
                answer[count] = arr[i];
                count++;
            }
            
            if(i==arr.Length-1 && count==0)
            {
                answer[count]=-1;
            }
        }
        
        Sort(answer);
        
        return answer;
    }
    
    public void Sort(int[] number)
    {
        int count=1;
        
        for(int i=0; i<number.Length-1; i++)
        {
            for(int j=count; j<number.Length; j++)
            {
                if(number[i] > number[j])
                {
                    Swap(number, i,j);
                }
            }
            count++;
        }
    }
    
    public void Swap(int[] number, int check, int check2)
    {
        int temp = number[check];
        number[check] = number[check2];
        number[check2] = temp;
    }
}