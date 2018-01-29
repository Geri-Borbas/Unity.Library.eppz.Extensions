	//
// Copyright (c) 2017 Geri Borbás http://www.twitter.com/_eppz
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//  The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using UnityEngine;
using UnityEditor;

using NUnit.Framework;


namespace EPPZ.Extensions.Editor.Test
{


	[TestFixture]
	public class String
	{


		string _null;


		[SetUp]
		public void Setup()
		{
			_null = null;
		}

		[TearDown]
		public void TearDown()
		{

		}

		[Test]
		public void IsNullOrWhiteSpace()
		{
			Assert.IsTrue(_null.IsNullOrWhiteSpace());
			Assert.IsTrue("      ".IsNullOrWhiteSpace());
			Assert.IsTrue("      \n     ".IsNullOrWhiteSpace());
			Assert.IsTrue("\n".IsNullOrWhiteSpace());
			Assert.IsTrue("\t".IsNullOrWhiteSpace());
			Assert.IsTrue("\r".IsNullOrWhiteSpace());
			Assert.IsTrue("\x20".IsNullOrWhiteSpace());
			Assert.IsTrue(" ".IsNullOrWhiteSpace());
			Assert.IsTrue("".IsNullOrWhiteSpace());

			Assert.IsFalse("String".IsNullOrEmptyOrWhiteSpace());
		}

		[Test]
		public void IsNullOrEmptyOrWhiteSpace()
		{
			Assert.IsTrue(_null.IsNullOrEmptyOrWhiteSpace());
			Assert.IsTrue("      ".IsNullOrEmptyOrWhiteSpace());
			Assert.IsTrue("      \n     ".IsNullOrEmptyOrWhiteSpace());
			Assert.IsTrue("\n".IsNullOrEmptyOrWhiteSpace());
			Assert.IsTrue("\t".IsNullOrEmptyOrWhiteSpace());
			Assert.IsTrue("\r".IsNullOrEmptyOrWhiteSpace());
			Assert.IsTrue("\x20".IsNullOrEmptyOrWhiteSpace());
			Assert.IsTrue(" ".IsNullOrEmptyOrWhiteSpace());
			Assert.IsTrue("".IsNullOrEmptyOrWhiteSpace());

			Assert.IsFalse("String".IsNullOrEmptyOrWhiteSpace());			
		}

		[Test]
		public void RemoveLastWord()
		{
			Assert.AreEqual(
				"A multi-worded sentence.".RemoveLastWord(),
				"A multi-worded"
				);

			Assert.AreEqual(
				"Word".RemoveLastWord(),
				"Word"
				);

			Assert.AreEqual(
				"".RemoveLastWord(),
				""
				);
		}

		[Test]
		public void Reverse()
		{
			Assert.AreEqual(
				"A multi-worded sentence.".Reverse(),
				".ecnetnes dedrow-itlum A"
				);

			Assert.AreEqual(
				"Word".Reverse(),
				"droW"
				);

			Assert.AreEqual(
				"".Reverse(),
				""
				);
		}

		[Test]
		public void MD5()
		{
			Assert.AreEqual(
				"A multi-worded sentence.".MD5(),
				"8451b8aaacdab7f8906c5cf4d05a10a2"
				);

			Assert.AreEqual(
				"Word".MD5(),
				"07a094a210794e74a0e5e1a1457a92ee"
				);

			Assert.AreEqual(
				"".MD5(),
				"d41d8cd98f00b204e9800998ecf8427e"
				);
		}

		[Test]
		public void RemoveWhitespace()
		{
			Assert.AreEqual(
				"A   multi-worded,   \n multi-lined   \n sentence.".RemoveWhitespace(),
				"Amulti-worded,multi-linedsentence."
				);

			Assert.AreEqual(
				"A  multi-worded   sentence.".RemoveWhitespace(),
				"Amulti-wordedsentence."
				);

			Assert.AreEqual(
				"A multi-worded sentence.".RemoveWhitespace(),
				"Amulti-wordedsentence."
				);

			Assert.AreEqual(
				"Word".RemoveWhitespace(),
				"Word"
				);

			Assert.AreEqual(
				"".RemoveWhitespace(),
				""
				);
		}
	}
}
