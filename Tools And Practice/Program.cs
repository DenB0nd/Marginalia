using Tools_And_Practice.Extensions;
using Tools_And_Practice.Algorithms;
using System.Diagnostics;

var a = new List<int?> { 1, 2, 2, 2, null, 3, 4, 5 };
var b = new List<int?> { 1, 1, 2, 2, 3, 3, 3, 4, 4 };

var result = a.IntersectWithDuplicates(b);

string str = "qwerty";
Console.WriteLine($"1{str.ReverseString()}1");