using System;

public class Solution
{
    public string solution(string[] survey, int[] choices)
    {
        
        string answer = "";
        string[,] keys = new string[4, 2]
        {
            {"R", "T" }, {"C", "F" }, {"J","M"}, {"A","N"}
        };
        int[,] values = new int[4, 2];

        for (int i = 0; i < survey.Length; i++)
        {
            string sSurvey = "";
            int choice = 0;

            if (choices[i] > 4) // 동의
            {
                sSurvey = survey[i][1].ToString(); //survey의 두번째 캐릭터를 sServey에 저장
                choice = (-1) * (4 - choices[i]); // choice에 양수(1,2,3 중 하나)를 저장
            }
            else // 비동의 또는 모르겠음
            {
                sSurvey = survey[i][0].ToString(); // survey의 첫번째 캐릭터를 sServey에 저장
                choice = 4 - choices[i]; // choice에 양수(0,1,2,3 중 하나)를 저장
            }
            
            for (int j = 0; j < 4; j++) // 첫번째 인덱스
            {
                for (int k = 0; k < 2; k++) // 두번째 인덱스
                {
                    if (keys[j, k] == sSurvey) // key배열의 요소와 sServey에 들어온 캐릭터가 일치하면
                    {
                        values[j, k] += choice; // 해당 인덱스 value배열 위치에 choice값 추가 
                    }
                }
            }
        }

        for (int i = 0; i < 4; i++)
        {
            if (values[i, 0] >= values[i, 1])
                answer += keys[i, 0];
            else if (values[i, 0] < values[i, 1])
                answer += keys[i, 1];
        }
        return answer;
    }
}