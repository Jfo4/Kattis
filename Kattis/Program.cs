using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            /// FizzBuzz
            ///
            //string[] fbArray = new string[4] { "Null", "Fizz", "Buzz", "FizzBuzz" };
            ////Console.WriteLine(fbArray[0]);
            //string FizzBuzz = Console.ReadLine();
            //string[] FizzBuzzParts = FizzBuzz.Split(' ');
            //int X = Convert.ToInt16(FizzBuzzParts[0]);
            //int Y = Convert.ToInt16(FizzBuzzParts[1]);
            //int N = Convert.ToInt16(FizzBuzzParts[2]);
            ////Console.WriteLine("X: {0}, Y: {1}, N: {2}", X, Y, N);
            //for (int i = 1; i <= N; i++)
            //{
            //    int fbCheck = 0;
            //    if (i % X == 0)
            //        fbCheck++;
            //    if (i % Y == 0)
            //        fbCheck += 2;
            //    string msg = (fbCheck > 0) ? fbArray[fbCheck] : Convert.ToString(i, 10);
            //    Console.WriteLine(msg);
            //    //Console.WriteLine("i: {0}, X: {1}, Y: {2}", i, i % X, i % Y);
            //    Console.ReadLine();
            //}

            /// Hissing Microphone
            /// 
            //Console.WriteLine(Console.ReadLine().Contains("ss") ? "Hiss" : "No Hiss");
            //Console.ReadKey();

            /// Triple Texting
            /// 
            //var words = Console.ReadLine();
            //var wordLen = words.Length / 3;
            //var word1 = words.Substring(0, wordLen);
            //var word2 = words.Substring(wordLen, wordLen);
            //var word3 = words.Substring(2 * wordLen, wordLen);
            ////Console.WriteLine($"{word1} {word2} {word3}");
            //var test1 = word1 == word2;
            //var test2 = word2 == word3;
            //var test3 = word1 == word3;
            //if (test1 || test3)
            //{
            //    Console.WriteLine($"{word1}");
            //}
            //else
            //if (test2)
            //{
            //    Console.WriteLine($"{word2}");
            //}
            //Console.ReadKey();

            /// Quick Brown Fox
            /// 
            //var rows = Int32.Parse(Console.ReadLine());
            //var allLetters = "abcdefghijklmnopqrstuvwxyz";
            //while (rows > 0)
            //{
            //    var line = Console.ReadLine();
            //    string missingLetters = "";
            //    for (int i = 0; i < allLetters.Length; i++)
            //    {
            //        string currentChar = allLetters.Substring(i, 1);
            //        if (!line.ToLower().Contains(currentChar))
            //            missingLetters += currentChar;
            //    }
            //    if (missingLetters.Length > 0)
            //        Console.WriteLine($"missing {missingLetters}");
            //    else
            //        Console.WriteLine("pangram");
            //    rows--;
            //}
            //Console.ReadKey();

            /// Set!
            /// 
            //3DTG 3DOP 2DSG
            //1SOP 1DTG 2OTR
            //3DOR 3STG 2DSP
            //3SSP 3OTG 1DTP
            //var setGrid = "3DTG3DOP2DSG1SOP1DTG2OTR3DOR3STG2DSP3SSP3OTG1DTP";
            //
            //string setGrid = "";
            //for (int i = 0; i < 4; i++)
            //{
            //    setGrid += Console.ReadLine().Replace(" ", "");
            //}
            //var solutions = 0;
            //int pattern;
            //for (int card1 = 1; card1 <= 10; card1++)
            //{
            //    for (int card2 = card1 + 1; card2 <= 11; card2++)
            //    {
            //        for (int card3 = card2 + 1; card3 <= 12; card3++)
            //        {
            //            var card1prop = setGrid.Substring((card1 - 1) * 4, 4);
            //            var card2prop = setGrid.Substring((card2 - 1) * 4, 4);
            //            var card3prop = setGrid.Substring((card3 - 1) * 4, 4);
            //            pattern = 0;
            //            for (int i = 0; i < 4; i++)
            //            {
            //                if ((card1prop.Substring(i, 1) == card2prop.Substring(i, 1)) &&
            //                    (card2prop.Substring(i, 1) == card3prop.Substring(i, 1)))
            //                    pattern += (int)Math.Pow(2, i);
            //                if ((card1prop.Substring(i, 1) != card2prop.Substring(i, 1)) &&
            //                   (card1prop.Substring(i, 1) != card3prop.Substring(i, 1)) &&
            //                   (card2prop.Substring(i, 1) != card3prop.Substring(i, 1)))
            //                    pattern += (int)Math.Pow(2, i);
            //                if (pattern == 15) // 1 + 2 + 4 + 8
            //                {
            //                    Console.WriteLine($"{card1} {card2} {card3}");
            //                    pattern = 0;
            //                    solutions++;
            //                }
            //            }
            //        }
            //    }
            //}
            //if (solutions == 0)
            //    Console.WriteLine("no sets");
            //Console.ReadKey();

            /// Stuck In A Time Loop
            ///
            //var limit = Int32.Parse(Console.ReadLine());
            //for (int i = 0; i < limit; i++)
            //{
            //    Console.WriteLine($"{i + 1} Abracadabra");
            //}
            //Console.ReadKey();
        }
    }
}
