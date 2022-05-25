using Marginalia.Extensions;
using Marginalia.Algorithms;
using System.Diagnostics;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Random.Shared.NextAlphanumeric(30));
}