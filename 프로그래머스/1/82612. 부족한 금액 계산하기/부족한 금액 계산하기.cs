using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long total = 0;
        total += money;
        
        for(int i=1; i<=count; i++)
        {
            total -= i*price;
        }
        
        if(total>= 0)
        {
            return 0;
        }
        else
        {
            return total * -1;
        }
            
    }
}