public class Solution {
    public bool solution(string s) {
        int pResult =0;
        bool answer = true;
        
        if(s.Length==4 || s.Length==6)
        {
            if(int.TryParse(s, out pResult))
            {
                return answer = true;
            }
            else
            {
                return answer = false;
            }
        }
        else
        {
            return answer = false;
        }            

    }
}