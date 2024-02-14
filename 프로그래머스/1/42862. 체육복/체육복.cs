using System;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = n;
        int count = 0;
        
        Array.Sort(lost);
        Array.Sort(reserve);
        
        foreach (int lostNumb in lost)
        {
            foreach (int reserveNumb in reserve)
            {
                if (lostNumb == reserveNumb)
                {
                    lost = lost.Where(x => x != lostNumb).ToArray();
                    reserve = reserve.Where(x => x != reserveNumb).ToArray();
                    break;
                }
            }
        }
        
        foreach(var number in lost)
        {
            for(int i=0; i<reserve.Length; i++)
            {
                if(reserve[i]!=0 && reserve[i]==number+1 || reserve[i]!=0 && reserve[i]==number-1)
                {
                    reserve[i]=0;
                    count++;
                    break;
                }
            }
        }
        
        return answer-lost.Length+count;
    }
}