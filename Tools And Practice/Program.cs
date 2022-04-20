using Tools_And_Practice.Extentions;
using Tools_And_Practice.Algorithms;


int[,] vs = new int[,] { { 0, 1, 2 }, { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 7 } };
int[,] r = null;

vs.GetRow(4).ToList().ForEach(s => global::System.Console.WriteLine(s));
vs.GetColumn(2).ToList().ForEach(s => global::System.Console.WriteLine(s));