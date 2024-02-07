namespace System;

public static class SystemExtensions
{
    public static bool HasValue(this string input) => !string.IsNullOrEmpty(input);

    public static bool IsEmpty(this string input) => string.IsNullOrEmpty(input);
}
