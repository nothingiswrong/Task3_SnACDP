namespace Task;

public class BHeapPriorityQueue
{
    private int[] Elements;
    private int[] Priorities;

    public int Size
    {
        get => Elements.Length;
    }

    private int _top = 0;

    public void Insert(int x, int p)
    {
        if (_top == Size) throw new ArgumentOutOfRangeException("HeapOverflow");
        Elements[_top] = x;
        Priorities[_top++] = p;
        for (var i = _top - 1; i > 0; i = i/2 - 1)
        {
             
        }
    }

    public BHeapPriorityQueue(int size)
    {
        Elements = new int[size];
        Priorities = new int[size];
    }

    public int ExtractMax()
    {
        return 0;
    }

    public void Increase(int x, int p)
    {
    }
}