using Marginalia.Algorithms;
using Marginalia.Extensions;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;

List<int> l1 = null;
var l2 = new List<int>() { };
var l3 = new List<int>() { 1 };
var l4 = new List<int>() { 1, 2, 3, 4, 5};
var l5 = new List<int>() { 1, 2, 3, 5, 4 };
var l6 = new List<int>() { 2, 1, 3, 4, 5 };
var l7 = new List<int>() { 2, 2, 3, 4, 5 };
var l8 = new List<int>() { 2, 2, 3, 5, 5 };

Console.WriteLine(l2.IsSorted());
Console.WriteLine(l3.IsSorted());
Console.WriteLine(l4.IsSorted());
Console.WriteLine(l5.IsSorted());
Console.WriteLine(l5.IsSorted());
Console.WriteLine(l7.IsSorted());
Console.WriteLine(l8.IsSorted());

