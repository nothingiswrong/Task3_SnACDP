using System.Diagnostics;
using System.Net.Quic;

namespace Task;

public static class Tests
{
    public static Dictionary<long, long> PassTestsForBheapInsert()
    {
        var queue = new BHeapPriorityQueue(100000);
        var sw = new Stopwatch();
        var metrics = new Dictionary<long, long>();
        int v, p;
        var rnd = new Random();
        for (int i = 0; i < 95000; i += 5000)
        {
            v = rnd.Next();
            p = rnd.Next();
            sw.Start();
            queue.Insert(v, p);
            sw.Stop();
            metrics.Add(i, sw.ElapsedTicks);

            for (int j = 0; j < 5000; j++)
            {
                queue.Insert(rnd.Next(), rnd.Next());
            }
        }

        Console.WriteLine(queue.Size);
        for (int i = 0; i < 4980; i++)
        {
            queue.Insert(rnd.Next(), rnd.Next());
        }

        sw.Start();
        queue.Insert(rnd.Next(), rnd.Next());
        sw.Stop();
        metrics.Add(99999, sw.ElapsedTicks);
        Console.WriteLine(queue.Size);
        return metrics;
    }


    public static Dictionary<long, long> PassTestsForArrayInsert()
    {
        var queue = new ArrayPriorityQueue(100000);
        var sw = new Stopwatch();
        var metrics = new Dictionary<long, long>();
        int v, p;
        var rnd = new Random();
        for (int i = 0; i < 95000; i += 5000)
        {
            v = rnd.Next();
            p = rnd.Next();
            sw.Start();
            queue.Insert(v, p);
            sw.Stop();
            metrics.Add(i, sw.ElapsedTicks);

            for (int j = 0; j < 5000; j++)
            {
                queue.Insert(rnd.Next(), rnd.Next());
            }
        }

        Console.WriteLine(queue.Size);
        for (int i = 0; i < 4980; i++)
        {
            queue.Insert(rnd.Next(), rnd.Next());
        }

        sw.Start();
        queue.Insert(rnd.Next(), rnd.Next());
        sw.Stop();
        metrics.Add(99999, sw.ElapsedTicks);
        Console.WriteLine(queue.Size);
        return metrics;
    }

    public static Dictionary<long, long> PassTestsForArrayExtractMax()
    {
        var queue = new ArrayPriorityQueue(100000);
        var sw = new Stopwatch();
        var metrics = new Dictionary<long, long>();
        int v, p;
        var rnd = new Random();
        for (int i = 0; i < 95000; i += 5000)
        {
            v = rnd.Next();
            p = rnd.Next();
            queue.Insert(v, p);
            sw.Start();
            queue.ExtractMax();
            sw.Stop();
            metrics.Add(i, sw.ElapsedTicks);

            for (int j = 0; j < 5000; j++)
            {
                queue.Insert(rnd.Next(), rnd.Next());
            }
        }

        Console.WriteLine(queue.Size);
        for (int i = 0; i < 4980; i++)
        {
            queue.Insert(rnd.Next(), rnd.Next());
        }

        queue.Insert(rnd.Next(), rnd.Next());
        sw.Start();
        queue.ExtractMax();
        sw.Stop();
        metrics.Add(99999, sw.ElapsedTicks);
        Console.WriteLine(queue.Size);
        return metrics;
    }

    public static Dictionary<long, long> PassTestsForArrayIncrease()
    {
        var queue = new ArrayPriorityQueue(100000);
        var sw = new Stopwatch();
        var metrics = new Dictionary<long, long>();
        int v, p;
        var rnd = new Random();
        for (int i = 0; i < 95000; i += 5000)
        {
            v = rnd.Next();
            p = rnd.Next();
            queue.Insert(v, p);
            sw.Start();
            queue.Increase(v, p);
            sw.Stop();
            metrics.Add(i, sw.ElapsedTicks);

            for (int j = 0; j < 5000; j++)
            {
                queue.Insert(rnd.Next(), rnd.Next());
            }
        }

        Console.WriteLine(queue.Size);
        for (int i = 0; i < 4980; i++)
        {
            queue.Insert(rnd.Next(), rnd.Next());
        }

        queue.Insert(rnd.Next(), rnd.Next());
        sw.Start();
        queue.Increase(rnd.Next(), rnd.Next());
        sw.Stop();
        metrics.Add(99999, sw.ElapsedTicks);
        Console.WriteLine(queue.Size);
        return metrics;
    }

    public static Dictionary<long, long> PassTestsForBHeapIncrease()
    {
        var queue = new BHeapPriorityQueue(100000);
        var sw = new Stopwatch();
        var metrics = new Dictionary<long, long>();
        int v, p;
        var rnd = new Random();
        for (int i = 0; i < 95000; i += 5000)
        {
            v = rnd.Next();
            p = rnd.Next();
            queue.Insert(v, p);
            sw.Start();
            queue.Increase(v, p);
            sw.Stop();
            metrics.Add(i, sw.ElapsedTicks);

            for (int j = 0; j < 5000; j++)
            {
                queue.Insert(rnd.Next(), rnd.Next());
            }
        }

        Console.WriteLine(queue.Size);
        for (int i = 0; i < 4980; i++)
        {
            queue.Insert(rnd.Next(), rnd.Next());
        }

        queue.Insert(rnd.Next(), rnd.Next());
        sw.Start();
        queue.Increase(rnd.Next(), rnd.Next());
        sw.Stop();
        metrics.Add(99999, sw.ElapsedTicks);
        Console.WriteLine(queue.Size);
        return metrics;
    }

    public static Dictionary<long, long> PassTestsForBHeapExtractMax()
    {
        var queue = new BHeapPriorityQueue(100000);
        var sw = new Stopwatch();
        var metrics = new Dictionary<long, long>();
        int v, p;
        var rnd = new Random();
        for (int i = 0; i < 95000; i += 5000)
        {
            v = rnd.Next();
            p = rnd.Next();
            queue.Insert(v, p);
            sw.Start();
            queue.ExtractMax();
            sw.Stop();
            metrics.Add(i, sw.ElapsedTicks);

            for (int j = 0; j < 5000; j++)
            {
                queue.Insert(rnd.Next(), rnd.Next());
            }
        }

        Console.WriteLine(queue.Size);
        for (int i = 0; i < 4980; i++)
        {
            queue.Insert(rnd.Next(), rnd.Next());
        }

        queue.Insert(rnd.Next(), rnd.Next());
        sw.Start();
        queue.ExtractMax();
        sw.Stop();
        metrics.Add(99999, sw.ElapsedTicks);
        Console.WriteLine(queue.Size);
        return metrics;
    }
}