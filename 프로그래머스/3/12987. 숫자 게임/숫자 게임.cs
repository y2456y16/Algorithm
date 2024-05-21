using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] A, int[] B)
    {
        //두 배열을 정렬
        Array.Sort(A);
        Array.Sort(B);
 
        int indexB = 0;
        int score = 0;
 
        //현재 인덱스의 A 숫자보다 큰 B 숫자가 있다면 승점을 + 해주면 된다.
        for (int i = 0; i < A.Length; i++)
        {
            //현재 A팀 숫자보다 큰 숫자가 B 배열에 있는지 찾는다.
            while (indexB < B.Length && A[i] >= B[indexB])
                indexB++;
 
            //인덱스가 넘어가면 더 이상 이길 수 있는 숫자가 없는 것
            if (indexB == B.Length)
                break;
 
            score++;
            indexB++;
        }
 
        return score;

    }

}