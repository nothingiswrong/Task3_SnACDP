using System.Data.SqlTypes;

namespace Task;

public class ArrayPriorityQueue
{
    private int[] Elements;
    private int[] Priorities;
    private int _top = -1;

    public int Max { get; set; } = int.MinValue; 
    public int Size
    {
        get => Elements.Length;
    }

    public ArrayPriorityQueue(int size)
    {
        Elements = new int[size];
        Priorities = new int[size];
    }

    public void Insert(int x, int p)
    {
        if (_top + 1 == Size) throw new ArgumentOutOfRangeException("HeapOverflow");
        Elements[++_top] = x;
        Priorities[_top] = p;
        Max = Math.Max(Max, x);
    }

    public int ExtractMax()
    {
        int max = Max;
        for (int i = 0; i < _top; i++)
        {
            if (Elements[i] == Max)
            {
                for (int j = i + 1; j <= _top; j++)
                {
                    Elements[j - 1] = Elements[j];
                }
                _top--;
            }
        }

        Max = Elements[0];
        for (int i = 0; i <= _top; i++)
        {
            Max = Math.Max(Max, Elements[i]);
        }
        return max;
    }

    public void Increase(int x, int p)
    {
        for (int i = 0; i < _top; i++)
        {
            if (Elements[i] == x)
            {
                Priorities[i] += p;
            }
        }
    }
}