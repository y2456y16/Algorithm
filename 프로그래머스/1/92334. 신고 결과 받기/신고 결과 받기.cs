using System;
using System.Collections;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string[] id_list, string[] report, int k) 
    {
        int[] answer = new int[id_list.Length];

        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

        for (int i = 0; i < report.Length; i++)//전체 신고 내용 반복 호출
        {
            string[] str = report[i].Split(' ');//신고 문구 구분

            string give = str[0];//주는 자
            string take = str[1];//신고 받는 자

            if (!dic.ContainsKey(take))//키를 가지고 있지 않다면
            {
                List<string> list = new List<string>();
                list.Add(give);
                dic.Add(take, list);
                continue;
            }

            if (!dic[take].Contains(give))//리스트에 해당 값이 없다면
            {
                dic[take].Add(give);
            }
        }

        for (int i = 0; i < id_list.Length; i++)
        {
            foreach (KeyValuePair<string, List<string>> item in dic)
            {
                if (item.Value.Contains(id_list[i]))
                {
                    if (item.Value.Count >= k)
                    {
                        answer[i] = ++answer[i];
                    }
                }                
            }
        }

        return answer;
    }
}