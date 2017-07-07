# eppz.Extensions 
> part of [**Unity.Library.eppz**](https://github.com/eppz/Unity.Library.eppz)
[![Build Status](https://travis-ci.org/eppz/Unity.Library.eppz.Extensions.png?branch=master)](https://travis-ci.org/eppz/Unity.Library.eppz.Extensions.png)

## `String_Extensions`

* Some string utility for the everyday.
    + `RemoveLastWord()`
        + Removes the last word (the last remaining part after the last space occured) of the string. Like, `"A multi-worded sentence.".RemoveLastWord()` gives you `"A multi-worded"`.
    + `IsNullOrWhiteSpace()` and `IsNullOrEmptyOrWhiteSpace()`
        + Adds `String.IsNullOrWhiteSpace()` string extensions that is only introduced in .NET 4. See test cases in [`Editor/Test/String.cs`](Editor/Test/String.cs) for more.

## License

> Licensed under the [MIT license](http://en.wikipedia.org/wiki/MIT_License).
