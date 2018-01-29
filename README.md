# eppz.Extensions [![Build Status](https://travis-ci.org/eppz/Unity.Test.eppz.png?branch=master)](https://travis-ci.org/eppz/Unity.Test.eppz)
> part of [**Unity.Library.eppz**](https://github.com/eppz/Unity.Library.eppz)

## `String_Extensions`

* Some string utility for the everyday.

    + `RemoveLastWord()`
        + Removes the last word (the last remaining part after the last space occured) of the string. Like, `"A multi-worded sentence.".RemoveLastWord()` gives you `"A multi-worded"`.
    + `IsNullOrWhiteSpace()` and `IsNullOrEmptyOrWhiteSpace()`
        + Adds `String.IsNullOrWhiteSpace()` string extensions that is only introduced in .NET 4. See test cases in [`Editor/Test/String.cs`](Editor/Test/String.cs) for more.
    + `Reverse()`
        + Reverse a string using `System.Array.Reverse()`.
    + `MD5()`
        + Create and MD5 hash string (!) using `System.Security.Cryptography.MD5` and `System.Text.StringBuilder`.
    + `RemoveWhitespace()`
        + Remove every white space character from string (space, tabs, new lines, etc.) using `System.StringSplitOptions.RemoveEmptyEntries`.

## License

> Licensed under the [MIT license](http://en.wikipedia.org/wiki/MIT_License).
