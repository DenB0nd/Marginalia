using Tools_And_Practice.Extentions;
using Tools_And_Practice.Algorithms;
using System.Diagnostics;

List<int> vs = new List<int>(2);

vs.Add(0);
vs.Add(1);
vs.Add(2);
vs.Add(3);
vs.Add(4);

Console.WriteLine(vs.ConvertToString());

vs.Insert(7, 7);
Console.WriteLine(vs[7]);