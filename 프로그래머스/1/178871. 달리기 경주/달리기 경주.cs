using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> answer = new Dictionary<string, int>();
        
        for(int i=0; i<players.Length; i++)
        {
            answer.Add(players[i], i);
        }
        
        foreach(var call in callings)
        {
            int rank = answer[call];
            string overtake = players[rank - 1];
            
            players[rank - 1] = call;
            players[rank] = overtake;
            
            answer[call] = rank - 1;
            answer[overtake] = rank;
        }
        
        return players;
    }

}