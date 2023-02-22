using System.Drawing;
using System.Numerics;

namespace Marginalia.Algorithms;

public static class MathAlgorithms
{
    public static int Mod(int a, int b)
    {
        int r = a % b;
        return r < 0 ? r + b : r;
    }

    public static int GCD(int firstNumber, int secondNumber)
    {
        while (firstNumber != 0 && secondNumber != 0)
        {
            if (firstNumber > secondNumber)
            {
                firstNumber %= secondNumber;
            }
            else
            {
                secondNumber %= firstNumber;
            }
        }

        return firstNumber | secondNumber;
    }

    public static int GCD(IEnumerable<int> enumerable)
    {
        int[] array = enumerable.ToArray();

        if (!array.Any())
        {
            return 0;
        }

        array = array.Distinct().ToArray();

        if (array.Length == 1)
        {
            return array[0];
        }

        for (int i = 1; i < array.Length; i++)
        {
            array[i] = GCD(array[i], array[i - 1]);
        }

        return array[^1];
    }

    public static int LCM(int firstNumber, int secondNumber)
    {
        return (firstNumber * secondNumber) / GCD(firstNumber, secondNumber);
    }

    public static int LCM(IEnumerable<int> enumerable)
    {
        int[] array = enumerable.ToArray();

        if (!array.Any())
        {
            return 0;
        }

        array = array.Distinct().ToArray();

        if (array.Length == 1)
        {
            return array[0];
        }

        for (int i = 1; i < array.Length; i++)
        {
            array[i] = LCM(array[i], array[i - 1]);
        }

        return array[^1];
    }

    public static double CountPI(double iterationsNumaber = 10_000_000_000)
    {
        double result = 3;
        double four = 4;

        for (double denom = 2; denom < iterationsNumaber; denom += 4)
        {
            result += four / (denom * (denom + 1) * (denom + 2)) - (four / ((denom + 2) * (denom + 3) * (denom + 4)));
        }

        return result;
    }

    public static double EuclideanDistance(double[] x, double[] y)
    {
        Array.Resize(ref y, Math.Max(y.Length, x.Length));
        Array.Resize(ref x, Math.Max(y.Length, x.Length));

        double result = 0;
        for (int i = 0; i < x.Length; i++)
        {
            result += Math.Pow(x[i] - y[i], 2);
        }

        return Math.Sqrt(result);
    }

    public static double ShoelaceFormula(IEnumerable<Point> points)
    {
        double res = 0;

        List<Point> list = new List<Point>(points.ToList());
        list.Add(list.First());
        
        for(int i = 1; i < list.Count; i++)
        {
            res += list[i - 1].X * list[i].Y - list[i - 1].Y * list[i].X;
        }

        return Math.Abs(res) / 2;
    }

    public static BigInteger Factorial(int number)
    {
        if(number <= 0)
        {
            return 1;
        }

        BigInteger res = 1;
        for(int i = 1; i <= number; i++)
        {
            res *= i;
        }

        return res;
    }

    public static BigInteger Combination(int n, int k)
    {
        BigInteger res = 1;
        for(int i = k + 1; i <= n; i++)
        {
            res *= i;
        }
        return res / Factorial(k - 1);
    }

    public static BigInteger Permution(int n, int k)
    {
        BigInteger res = 1;
        for (int i = k; i <= n; i++)
        {
            res *= i;
        }
        return res;
    }

    // taken from https://www.nayuki.io/page/fast-fibonacci-algorithms
    public static BigInteger Fibonacci(int n)
    {
        if (n < 0)
        {
            return 0;
        }
        BigInteger a = BigInteger.Zero;
        BigInteger b = BigInteger.One;
        for (int i = 31; i >= 0; i--)
        {
            BigInteger d = a * (b * 2 - a);
            BigInteger e = a * a + b * b;
            a = d;
            b = e;
            if ((((uint)n >> i) & 1) != 0)
            {
                BigInteger c = a + b;
                a = b;
                b = c;
            }
        }
        return a;
    }

    // (2n)! / (n + 1)!(n)!
    public static BigInteger Catalan(int n)
    {
        if (n < 0)
        {
            return 0;
        }

        BigInteger res = 1;
        for (int i = n + 1; i <= 2 * n; i++)
        {
            res *= i;
        }

        return res / Factorial(n + 1);
    }
}
