using System;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[strings.Length];
        
        Array.Sort(strings, (a, b) =>
        {
            int c = a[n].CompareTo(b[n]);
            if (c == 0) { return a.CompareTo(b); }
            return c;
        });
        
        answer = strings;
        
        return answer;
    }
    
}