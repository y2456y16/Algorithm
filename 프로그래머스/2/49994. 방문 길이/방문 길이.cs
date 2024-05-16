using System;
using System.Collections.Generic;
public class Solution
{
    public int solution(string dirs)
    {
        int answer = 0;

        bool[,,,] visit = new bool[11, 11, 11, 11];

        Queue<Pos> q = new Queue<Pos>();
        q.Enqueue(new Pos(5, 5));
        visit[5, 5, 5, 5] = true;

        for (int i = 0; i < dirs.Length; i++)
        {
            Pos now = q.Dequeue();
            int nextY = now.PosY;
            int nextX = now.PosX;

            switch (dirs[i])
            {
                case 'U':
                    nextY--;
                    break;
                case 'D':
                    nextY++;
                    break;
                case 'R':
                    nextX++;
                    break;
                case 'L':
                    nextX--;
                    break;
            }

            if (nextY < 0 || nextY > 10 || nextX < 0 || nextX > 10)
            {
                q.Enqueue(now);
                continue;
            }

            if (visit[nextY, nextX, now.PosY, now.PosX] == true || visit[now.PosY, now.PosX, nextY, nextX] == true)
            {
                q.Enqueue(new Pos(nextY, nextX));
                continue;
            }
            visit[now.PosY, now.PosX, nextY, nextX] = true;
            visit[nextY, nextX, now.PosY, now.PosX] = true;

            answer++;
            q.Enqueue(new Pos(nextY, nextX));
        }

        return answer;
    }
}
class Pos
{
    public int PosY;
    public int PosX;

    public Pos(int y, int x)
    {
        PosY = y;
        PosX = x;
    }
}