using Marginalia.Extensions;
using Marginalia.Algorithms;
using System.Diagnostics;
using System.Drawing;

Point[] points = { new Point(3, 4), new Point(5, 11), new Point(12, 8), new Point(9, 5), new Point(5, 6) };

Console.WriteLine(MathAlgorithms.ShoelaceFormula(points));