using Marginalia.Algorithms;
using Marginalia.Extensions;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;

Stopwatch stopwatch= Stopwatch.StartNew();
Random.Shared.NextAlphanumeric(1000000000);
stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);
stopwatch.Restart();
Random.Shared.NextAlphanumeric1(1000000000);
stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);
