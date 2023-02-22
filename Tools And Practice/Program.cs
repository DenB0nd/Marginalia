using Marginalia.Algorithms;
using Marginalia.Extensions;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;

Console.WriteLine(Ciphers.EncryptCaesarCipher("THEQUICKBROWNFOXJUMPSOVERTHELAZYDOG", key: 23));
Console.WriteLine(Ciphers.DecryptCaesarCipher("QEBNRFZHYOLTKCLUGRJMPLSBOQEBIXWVALD", key: 23));

Console.WriteLine((-2) % 27);
