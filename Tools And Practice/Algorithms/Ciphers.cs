using System.Globalization;
using System.Text;
using Marginalia.Extensions;

namespace Marginalia.Algorithms;


public static class Ciphers
{
    const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static string EncryptCaesar(string plainText, int key = 1, string alphabet = ALPHABET)
    {
        string cipherText = "";
        foreach (char ch in plainText)
        {
            cipherText += ALPHABET[MathAlgorithms.Mod(alphabet.IndexOf(ch) + key, alphabet.Length)];
        }
        return cipherText;
    }

    public static string DecryptCaesar(string cipherText, int key = 1, string alphabet = ALPHABET) =>
        EncryptCaesar(cipherText, -key, alphabet);

    public static string EncryptColumnarTransposition(string plainText, List<int> key)
    {
        string cipherText = "";

        for (int i = 1; i < key.Count() + 1; i++)
        {
            int index = key.IndexOf(i);
            if(index == -1)
            {
                continue;
            }

            while (index < plainText.Length)
            {
                cipherText += plainText[index];
                index += key.Count();
            }
        }

        return cipherText;
    }


    public static string DecryptColumnarTransposition(string cipherText, List<int> key)
    {
        char[] plainText = new char[cipherText.Length];

        int counter = 0;
        for (int i = 1; i < key.Count() + 1; i++)
        {
            int index = key.IndexOf(i);
            if (index == -1)
            {
                continue;
            }

            while (index < cipherText.Length)
            {
                plainText[index] = cipherText[counter];
                counter++;
                index += key.Count();
            }
        }

        return string.Join("",plainText);
    }

}