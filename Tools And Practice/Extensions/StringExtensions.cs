﻿namespace Marginalia.Extensions;

public static class StringExtensions
{
    public static string ReverseString(this string text)
    {
        ArgumentNullException.ThrowIfNull(text);
        return new string(text.Reverse().ToArray());
    }
}
