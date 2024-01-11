public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        for(int i=0; i<arr.GetLength(0); i++)
        {
            answer += arr[i];
        }
        answer = answer/arr.GetLength(0);
        return answer;
    }
}