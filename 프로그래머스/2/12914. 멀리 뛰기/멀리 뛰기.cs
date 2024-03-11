using System;
using System.Collections.Generic;

public class Solution {
    public long solution(int n) {
        List<long> howMany = new List<long>();
        
        howMany.Add(1);
        howMany.Add(2);
        
        for (int i = 2; i < n; i++)
        {
            howMany.Add((howMany[i - 2] + howMany[i - 1]) % 1234567);
        }
            
        return howMany[n - 1];
    }
}



