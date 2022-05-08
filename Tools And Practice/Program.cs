using Tools_And_Practice.Extentions;
using Tools_And_Practice.Algorithms;
using System.Diagnostics;

var a = new List<int> { 1, 2, 2, 2, 3, 3, 4, 5 };
var b = new List<int> { 1, 1, 2, 2, 3, 3, 3, 4, 4 };

Stopwatch stopwatch = Stopwatch.StartNew();
var result = a.IntersectWithDuplicates(b);
stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);
stopwatch.Start();


Console.WriteLine(result.ConvertToString());
Console.WriteLine(a.ConvertToString());
Console.WriteLine(b.ConvertToString());

stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);