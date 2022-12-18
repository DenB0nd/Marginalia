using Marginalia.Algorithms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;

Point[] points = { new Point(3, 4), new Point(5, 11), new Point(12, 8), new Point(9, 5), new Point(5, 6) };

Stopwatch sw = Stopwatch.StartNew();
BigInteger num = MathAlgorithms.Catalan(100000);
sw.Stop();
Console.WriteLine(num);
Console.WriteLine(sw.ElapsedMilliseconds);

