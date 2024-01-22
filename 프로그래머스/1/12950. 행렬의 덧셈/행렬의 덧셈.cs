public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int[,] answer = new int[,] {{}};
        int arr1x = arr1.GetLength(0);
        int arr1y =0;
        try{
            arr1y = arr1.GetLength(1);
        }catch
        {
            
        }
        
        int arr2x = arr2.GetLength(0);
        int arr2y =0;
        try
        {
            arr2y = arr2.GetLength(1);
        }
        catch
        {
            
        }
        
        
        
        if(arr1y!=0 && arr2y !=0)
        {
            answer = new int[arr1x, arr1y];
            
            for(int i=0; i<arr1.GetLength(0); i++)
            {
                for(int j=0; j<arr1.GetLength(1); j++)
                {
                    answer[i,j] = arr1[i,j] + arr2[i,j];
                }
            }

        }
        else
        {
            answer = new int[arr1x, arr1y];
            
            for(int i=0; i<arr1.GetLength(0); i++)
            {
                answer[i,0] = arr1[i,0] + arr2[i,0];
            }
        }
        
        return answer;
    }
}