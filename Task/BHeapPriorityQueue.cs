using System.Text;

namespace Task;

public class BHeapPriorityQueue
{
    private int[] Elements;
    private int[] Priorities;

    public int Size
    {
        get => _top;
    }

    private int _top = -1;

    public void Insert(int x, int p)
    {
        if (_top == Elements.Length) throw new ArgumentOutOfRangeException("HeapOverflow");
        Elements[++_top] = x;
        Priorities[_top] = p;
        HeapifyUp(_top);
    }

    public BHeapPriorityQueue(int size)
    {
        Elements = new int[size];
        Priorities = new int[size];
    }

    private void HeapifyUp(int ind)
    {
        for (var i = ind; i > 0 && Priorities[i] > Priorities[(i + 1) / 2 - 1]; i = (i + 1) / 2 - 1)
        {
            (Priorities[(i + 1) / 2 - 1], Priorities[i]) = (Priorities[i], Priorities[(i + 1) / 2 - 1]);
            (Elements[(i + 1) / 2 - 1], Elements[i]) = (Elements[i], Elements[(i + 1) / 2 - 1]);
        }
    }

    private void HeapifyDown(int ind)
    {
        int i = ind;
        while (i < _top)
        {
            int leftInd = 2 * i + 1;
            int rightInd = 2 * i + 2;
            int largInd = i;
            
            if (leftInd <= _top && Priorities[leftInd] > Priorities[i])
            {
                largInd = leftInd;
            }

            if (rightInd <= _top && Priorities[rightInd] > Priorities[largInd])
            {
                largInd = rightInd;
            }

            if (largInd == i) return;
            (Elements[largInd], Elements[i]) = (Elements[i], Elements[largInd]);
            (Priorities[largInd], Priorities[i]) = (Priorities[i], Priorities[largInd]);
            
            i = largInd;
        }
    }

    public int ExtractMax()
    {
        var max = Elements[0];
        (Elements[0], Elements[_top]) = (Elements[_top], Elements[0]);
        (Priorities[0], Priorities[_top]) = (Priorities[_top], Priorities[0]);
        _top--;
        HeapifyDown(0);
        return max;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var el in Elements)
        {
            sb.Append($"{el}, ");
        }

        return sb.ToString();
    }

    public void Increase(int x, int p)
    {
        for (int i = 0; i <= _top; i++)
        {
            if (Elements[i] == x)
            {
                Priorities[i] += p;
                HeapifyUp(i);
                break;
            }
        }
    }
}