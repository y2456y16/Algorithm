public class Solution
{
    public int[] solution(long n)
    {
        int[] answer;
        long temp = n;
        int count = 0;

        while (temp > 0)
        {
            temp = temp / 10;
            count++;
        }
        
        answer = new int[count];


        for (int i = 0; i < count; i++)
        {
            long temp2 = (n % 10);
            
            answer[i] = (int)temp2;
            n = n / 10;
        }

        return answer;
    }
}