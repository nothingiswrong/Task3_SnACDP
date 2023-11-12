
using System.Threading.Channels;
using Task;

var bh = new BHeapPriorityQueue(10);
bh.Insert(5,1);
bh.Insert(10,3);
bh.Insert(3, 3);
bh.Insert(7,2);
Console.WriteLine(bh);
var max = bh.ExtractMax();
Console.WriteLine(bh);
bh.Increase(7,3);
Console.WriteLine(bh);
bh.Insert(1,0);
Console.WriteLine(bh);
bh.Increase(1, 3);
Console.WriteLine(bh);
