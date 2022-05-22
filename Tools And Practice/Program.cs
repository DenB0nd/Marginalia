using Tools_And_Practice.Extensions;
using Tools_And_Practice.Algorithms;
using System.Diagnostics;

var a = new List<double> { 2, 3, 3};
var b = new List<double> { 1, 1};

var result = MathAlgorithms.EuclideanDistance(a.ToArray(), b.ToArray());
Console.WriteLine(result);
Console.WriteLine($"1{a}1");