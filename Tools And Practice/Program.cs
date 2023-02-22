using Marginalia.Algorithms;
using Marginalia.Extensions;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;

Console.WriteLine(Ciphers.EncryptColumnarTransposition("THISISWIKIPEDIA", new List<int>{ 1, 4, 5, 3, 2, 6 }));
Console.WriteLine(Ciphers.DecryptColumnarTransposition("TWDIPSIHIIIKASE", new List<int> { 1, 4, 5, 3, 2, 6 }));

