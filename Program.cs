
using System.Collections.Concurrent;

void SayHello(string name)
{
    Console.WriteLine($"Hello from thread to {name}");
}

var i = 0;
ConcurrentStack<int> mylist = new();
while(i < 10)
{
    var t = new Thread(() => mylist.Push(i));
    t.Start();
    // t.Join();
    i++;
}

foreach (var j in mylist)
{
    Console.WriteLine(j);
}


Thread.Sleep(1);
Console.WriteLine("Hello from main");

var dangerous = Console.ReadLine();

void dothing()
{
    System.Diagnostics.Process.Start(dangerous);
}
