public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        int total =0;
        
        //2016년 1월 1일이 금요일 이기에
        total += 3;
        
        for(int i=1; i<a; i++)
        {
            switch(i)
            {
                case 1:
                    total += 31;
                    break;
                case 2:
                    total += 29;
                    break;
                case 3:
                    total += 31;
                    break;
                case 4:
                    total += 30;
                    break;
                case 5:
                    total += 31;
                    break;
                case 6:
                    total += 30;
                    break;
                case 7:
                    total += 31;
                    break;
                case 8:
                    total += 31;
                    break;
                case 9:
                    total += 30;
                    break;
                case 10:
                    total += 31;
                    break;
                case 11:
                    total += 30;
                    break;
            }
        }
        
        total += b;
        total = total%7;
        
        switch(total)
        {
            case 0:
                answer = "MON";
                break;
            case 1:
                answer = "TUE";
                break;
            case 2:
                answer = "WED";
                break;
            case 3:
                answer = "THU";
                break;
            case 4:
                answer = "FRI";
                break;
            case 5:
                answer = "SAT";
                break;
            case 6:
                answer = "SUN";
                break;
        }
        
        return answer;
    }
}