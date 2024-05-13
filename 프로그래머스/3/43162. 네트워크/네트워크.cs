using System;
using System.Collections.Generic;

public class Solution {
    public Dictionary<int, List<int>> network = new Dictionary<int, List<int>>();
    public List<int> addList = new List<int>();

    public int solution(int n, int[,] computers)
    {
        for (int i = 0; i < n; i++)
        {
            addList.Add(i);
        }
        DFS(computers, 0, 0);
        return network.Keys.Count;
    }

    void DFS(int[,] computers, int x, int key)
    {
        for (int y = key; y < computers.GetLength(0); y++)
        {
            if (!addList.Contains(y)) continue;
            if (computers[x, y] == 1) 
            {
                if (!network.ContainsKey(key)) network.Add(key, new List<int>());
                network[key].Add(y);
                addList.Remove(y);
                if (x != y) DFS(computers, y, key);
            }
        }
        if(x==key && addList.Count != 0) DFS(computers, addList[0], addList[0]);
    }
}