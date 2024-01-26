using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        string temp ="";
        int tempi = 0;
        
        foreach(char number in s)
        {
            if(int.TryParse(number.ToString(), out tempi))
            {
                
                answer = answer*10 + tempi;
            }
            else
            {
                temp += number;
                
                switch(temp)
                {
                    case "zero":
                        answer = answer *10 + 0;
                        temp = "";
                        break;
                    case "one":
                        answer = answer *10 + 1;
                        temp = "";
                        break;
                    case "two":
                        answer = answer *10 + 2;
                        temp = "";
                        break;
                    case "three":
                        answer = answer *10 + 3;
                        temp = "";
                        break;
                    case "four":
                        answer = answer *10 + 4;
                        temp = "";
                        break;
                    case "five":
                        answer = answer *10 + 5;
                        temp = "";
                        break;
                    case "six":
                        answer = answer *10 + 6;
                        temp = "";
                        break;
                    case "seven":
                        answer = answer *10 + 7;
                        temp = "";
                        break;
                    case "eight":
                        answer = answer *10 + 8;
                        temp = "";
                        break;
                    case "nine":
                        answer = answer *10 + 9;
                        temp = "";
                        break;
                    default:
                        break;
                }
                
            }
        }
        return answer;
    }
}