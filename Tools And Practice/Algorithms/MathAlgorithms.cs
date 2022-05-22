namespace Tools_And_Practice.Algorithms;

public static class MathAlgorithms
{
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
}
