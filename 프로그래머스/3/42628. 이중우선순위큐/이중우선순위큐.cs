
using System;
using System.Collections.Generic;

public class Solution {
    /*
    public int[] solution(string[] operations) {
        List<int> numbers = new List<int>(operations.Length);
        int[] answer = new int[2];
        
        for(int i=0; i<operations.Length; i++)
        {
            HeapSortData(numbers);
            string[] word = operations[i].Split(" ");
            switch(word[0][0])
            {
                case 'I':
                    numbers.Add(Int32.Parse(word[1]));
                    break;
                case 'D':
                    if(numbers.Count !=0)
                    {
                        if(Int32.Parse(word[1]) == 1)
                        {
                            numbers.Remove(numbers[numbers.Count-1]);
                        }
                        else
                        {
                            numbers.Remove(numbers[0]);
                        }
                    }
                    break;
            }
        }
        
        
        
        if(numbers.Count == 0)
        {
            answer[0] = 0;
            answer[1] = 0;
        }
        else if(numbers.Count ==1)
        {
            answer[0] = numbers[0];
            answer[1] = numbers[0];
        }
        else
        {
            answer[0] = numbers[numbers.Count-1];
            answer[1] = numbers[0];
        }
           
        return answer;
    }
    
    private void HeapSortData(List<int> numbers)
    {

        for (int i = (numbers.Count - 1) / 2; i >= 0; --i)
        {
            CalcHeap(numbers, i, numbers.Count);
        }
        for (int i = numbers.Count - 1; i > 0; --i)
        {
            SwapHeap(numbers, i, 0);
            CalcHeap(numbers, 0, i);
        }

    }

    
    private void CalcHeap(List<int> nArrData, int nRoot, int nMax)
    {
        while (nRoot < nMax)
        {
            int nChild = nRoot * 2 + 1;
            if (nChild + 1 < nMax && nArrData[nChild] < nArrData[nChild + 1])
                ++nChild; //오른쪽 노드

            if (nChild < nMax && nArrData[nRoot] < nArrData[nChild])
            {
                SwapHeap(nArrData, nRoot ,nChild);
                nRoot = nChild;
            }
            else
                break;
        }
    }
    private void SwapHeap(List<int> nArrData, int a, int b)
    {
        int temp = nArrData[a];
        nArrData[a] = nArrData[b];
        nArrData[b] = temp;
    }
    
    */
    
    public int[] solution(string[] operations) {
        PriorityQueue minHeap = new PriorityQueue();
        PriorityQueue maxHeap = new PriorityQueue();
        
        foreach(string operation in operations)
        {
            string[] currOperation = operation.Split(" ");
            string action = currOperation[0];
            int number = Int32.Parse(currOperation[1]);
            
            if (currOperation[0] == "I")
            {
                minHeap.Enqueue(-number);
                maxHeap.Enqueue(number);
                continue;
            }
            
            if (number == 1 && minHeap.Count > 0)
            {
                int currValue = maxHeap.Dequeue();
                minHeap.Remove(-currValue);
            }
            else if (number == -1 && minHeap.Count > 0)
            {
                int currValue = minHeap.Dequeue();
                maxHeap.Remove(-currValue);
            }
        }
        
        if (minHeap.Count == 0)
        {
            return new int[] {0, 0};
        }
        else
        {
            return new int[] {maxHeap.Dequeue(), -minHeap.Dequeue()};
        }
    }
}

public class PriorityQueue // MaxHeap
{
    private List<int> heap = new List<int>();

    public int Count => heap.Count;
    
    public void Enqueue(int data)
    {
        heap.Add(data);
        int now = heap.Count - 1; // 추가한 노드 위치 (트리 마지막 레벨 왼쪽)
        
        while (now > 0) // 순서 지정하기
        {
            int next = (now - 1) / 2; // 부모 노드 (트리)
            if (heap[now] < heap[next]) break;
            // 부모노드보다 추가한게 크면 Swap
            int temp = heap[now];
            heap[now] = heap[next];
            heap[next] = temp;
            now = next;
        }
    }
    
    public int Dequeue()
    {
        int ret = heap[0]; // return할 값 (트리 root에 max 저장해둔 형태)
        int lastIndex = heap.Count - 1;
        heap[0] = heap[lastIndex];
        heap.RemoveAt(lastIndex);
        lastIndex -= 1;
        int now = 0;
        
        while (true)
        {
            int left = 2 * now + 1;
            int right = 2 * now + 2;
            int next = now;
            
            if (left <= lastIndex && heap[next] < heap[left]) next = left; // 왼쪽보다 작으면 왼쪽으로 보내기
            if (right <= lastIndex && heap[next] < heap[right]) next = right; // 오른쪽보다 작으면 오른쪽으로 보내기 (여기서는 위에 now랑 left랑 비교해서 더 큰애랑 또 비교해서 갱신하게됨)
            if (next == now) break;
            
            int temp = heap[now];
            heap[now] = heap[next];
            heap[next] = temp;
            
            now = next;
        }
        
        return ret;
    }
    
    public void Remove(int value)
    {
        heap.Remove(value);
    }
}
