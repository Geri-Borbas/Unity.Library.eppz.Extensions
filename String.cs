﻿//
// Copyright (c) 2017 Geri Borbás http://www.twitter.com/_eppz
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//  The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using UnityEngine;
using System.Collections.Generic;
using System.Text;
using System;


namespace EPPZ.Extensions
{


	public static class String_Extensions
	{


		// Mainly from http://stackoverflow.com/questions/3174152/isnulloremptyorwhitespace-problem-in-c-sharp

		public static bool IsNullOrWhiteSpace(this string value)
		{
			if (value != null)
			{
				for (int i = 0; i < value.Length; i++)
				{
					if (!char.IsWhiteSpace(value[i]))
					{
						return false;
					}
				}
			}
			return true;
		}

		public static bool IsNullOrEmptyOrWhiteSpace(this string value)
		{
			return string.IsNullOrEmpty(value) ||
				ReferenceEquals(value, null) ||
					string.IsNullOrEmpty(value.Trim());
		}

		public static string RemoveLastWord(this string value)
		{
			if (value == null) return ""; // Only if any

			string result = value;
			int index = value.LastIndexOf(" ");
			if (index > -1) result = value.Remove(index);
			return result;
		}

		public static string Reverse(this string value)
		{
    		char[] characters = value.ToCharArray();
	   		System.Array.Reverse(characters);
		    return new string(characters);
		}

		public static string MD5(this string value)
		{
			System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
			StringBuilder stringBuilder = new StringBuilder();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(value));
            for (int i = 0; i < hash.Length; i++)
            { stringBuilder.Append(hash[i].ToString("x2")); }
            return stringBuilder.ToString();
		}

		// From https://www.codeproject.com/Articles/1014073/Fastest-method-to-remove-all-whitespace-from-String

		public static string RemoveWhitespace(this string value)
		{ return string.Concat(value.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); }
	}
}