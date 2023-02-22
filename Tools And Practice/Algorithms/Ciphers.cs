namespace Marginalia.Algorithms
{
   
    public static class Ciphers
    {
        const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string EncryptCaesarCipher(string plainText, int key = 1, string alphabet = ALPHABET)
        {
            string result = "";
            foreach(char ch in plainText)
            {
                result += ALPHABET[MathAlgorithms.Mod(alphabet.IndexOf(ch) + key,alphabet.Length)];
            }
            return result;
        }

        public static string DecryptCaesarCipher(string plainText, int key = 1, string alphabet = ALPHABET) =>
            EncryptCaesarCipher(plainText, -key, alphabet);
    }
}
