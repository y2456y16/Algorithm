public class Solution {
    public int[] solution(int[] arr) {
        int[] answer;
        int checkNumb =0;
        int checkWhere =0;
        
        
        if(arr.Length ==1)
        {
            answer = new int[arr.Length];
            answer[0] = -1;
            return answer;
        }
        else
        {
            checkNumb = arr[0];
            checkWhere = 0;
            
            answer = new int[arr.Length-1];
            
            for(int i=0; i<arr.Length; i++)
            {
                if(checkNumb > arr[i])
                {
                    checkNumb = arr[i];
                    checkWhere = i;
                }
            }
            
            int count=0;
            
            for(int j=0; j<answer.Length; j++)
            {
                if(checkWhere == j)
                {
                    answer[j] = arr[j+1];
                    count++;
                }
                else
                {
                    answer[j] = arr[j+count];
                }
                
            }
        }
        
        
        
        return answer;
    }
}