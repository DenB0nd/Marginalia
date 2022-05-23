using Tools_And_Practice.Extensions;
using Tools_And_Practice.Algorithms;
using System.Diagnostics;

var a = new List<int> { 0, 1, 3, 4, 4, 7, 8, 8, 8, 9};

Console.WriteLine(a.BinarySearchUpperBound<int>(0));
Console.WriteLine(a.BinarySearchUpperBound<int>(1));
Console.WriteLine(a.BinarySearchUpperBound<int>(3));
Console.WriteLine(a.BinarySearchUpperBound<int>(4));
Console.WriteLine(a.BinarySearchUpperBound<int>(7));
Console.WriteLine(a.BinarySearchUpperBound<int>(8));
Console.WriteLine(a.BinarySearchUpperBound<int>(9));