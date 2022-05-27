using Marginalia.Extensions;
using Marginalia.Algorithms;
using System.Diagnostics;

Console.WriteLine(Math.Round(0.5));
Console.WriteLine(Math.Round(1.5));
Console.WriteLine(Math.Round(2.5));
Console.WriteLine(Math.Round(3.5));
Console.WriteLine(Math.Round(4.5));
Console.WriteLine(Math.Round(5.5));

Console.WriteLine();

for(double i = 0.5; i < 6; i++)
{
    Console.WriteLine(Math.Round(i));
}