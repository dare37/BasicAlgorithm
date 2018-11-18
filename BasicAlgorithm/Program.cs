using System;

namespace BasicAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.
            Console.WriteLine("1. Write a C# Sharp program to compute the sum \nof the two given integer values. If the two values are the \nsame, then return triple their sum.");
            Console.WriteLine(ReturnSum(3, 5));
            Console.WriteLine();
            #endregion

            #region 2.
            Console.WriteLine("6. Remove specific char.");
            Console.WriteLine(RemoveChar("Python", 2));
            Console.WriteLine();
            #endregion

            #region 3.
            Console.WriteLine("Repeat 4 times first 2 chars.");
            RemoveAndRepeat4Times("test");
            Console.WriteLine();
            #endregion

            #region 4.
            Console.WriteLine("Add last char to first and last spot.");
            AddLastCharToFirstAndLastSpot("1");
            Console.WriteLine();
            #endregion

            #region 5.
            Console.WriteLine("True if starts with 2 same chars");
            string test = "DAr";
            if (test.StartsWith("da", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine(true);
            }
            Console.WriteLine();
            #endregion

            #region 6.
            Console.WriteLine("");
            FindLargerValue(19, 30);
            Console.WriteLine();
            #endregion

            #region 7.
            Console.WriteLine("");
            CheckIfLastDigitIsSame(2344, 1244);
            Console.WriteLine();
            #endregion

            #region 8.
            Console.WriteLine("");
            ConvertLast3CharsToUpper("darko");
            Console.WriteLine();
            #endregion

            #region 9.
            Console.WriteLine("");
            CopyNTimes("darko", 4);
            Console.WriteLine();
            #endregion

            #region 10.
            Console.WriteLine("");
            Last3CharsCopy("Pyr", 4);
            Console.WriteLine();
            #endregion

            #region 11.
            Console.WriteLine("");
            CountStringAA("tetaaNjiaaa");
            Console.WriteLine();
            #endregion

            #region 12.
            Console.WriteLine("");
            RandomizeChars("DarkoSkaljak");
            Console.WriteLine();
            #endregion

            #region 13.
            Console.WriteLine("");
            DeleteEveryOtherChar("DarkoS");
            Console.WriteLine();
            #endregion

            #region 14.
            Console.WriteLine("");
            MakeStringFrom("abcd");
            Console.WriteLine();
            #endregion

            #region 15.
            Console.WriteLine("");
            CompareLast2CharsToOther("abhabfabasdfab");
            Console.WriteLine();
            #endregion

            #region 16.
            Console.WriteLine("");
            int[] arrayOfInts = { 1, 4, 5, 6, 2, 1, 2, 3, 5 };
            CheckForSequenceAppearance(arrayOfInts);
            Console.WriteLine();
            #endregion

            #region 17.
            Console.WriteLine("");
            ExcessStringRemoval("xxHxix", "x");
            Console.WriteLine();
            #endregion

            #region 18.
            Console.WriteLine("");
            SpecificIndexesStringCreation("JavaScript");
            Console.WriteLine();
            #endregion

            #region 19.
            Console.WriteLine("");
            int[] arrayOfInts2 = { 1, 4, 5, 2, 6, 5, 5, 4, 5, 6 };
            CountTwoFivesInArrayOfInts(arrayOfInts2);
            Console.WriteLine();
            #endregion

            #region 20.
            Console.WriteLine("");
            BitWiseOr(21);
            Console.WriteLine();
            #endregion

            #region 21.
            Console.WriteLine("");
            Check58(6, 14);
            Check58(4, 5);
            Check58(10, 13);
            Check58(17, 33);
            Check58(13, 33);
            Console.WriteLine();
            #endregion

            #region 21.
            Console.WriteLine("69.");
            MoveLast2ToStartOfAGivenString("aljaksk");
            Console.WriteLine();
            #endregion

            #region 22.
            Console.WriteLine("");
            int[] arr1 = { 1, 2, 3, 4, 5 };
            LeftToRightArray(arr1);
            Console.WriteLine();
            #endregion

            #region 23.
            Console.WriteLine("94.");
            int[] arr2 = { 2, 4, 56, 67, 2, 4, 23 };
            PopulateArrayWithMaxiumValueOnly(arr2);
            Console.WriteLine();
            #endregion

            #region 24.
            //Console.WriteLine(" ");
            //int[] aar1 = { 2, 4, 4, 5 };
            //int[] aar2 = { 6, 7, 8,9 };
            //int[] combinedArr = new int[aar1.Length + aar2.Length];
            //Array.Copy(aar1, combinedArr, aar1.Length);
            //Array.Copy(aar2, combinedArr,aar1.Length, aar2.Length);
            //foreach (var item in combinedArr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //int[] array = { 1, 2, 3 };
            //int[] array2 = { 4, 5, 6 };

            //// ... Destination array.
            //int[] final = new int[array.Length + array2.Length];

            //Buffer.BlockCopy(array, 0, final, 0, array.Length * sizeof(int));
            //Buffer.BlockCopy(array2, 0, final, array.Length * sizeof(int), array.Length * sizeof(int));

            //foreach (var item in final)
            //{
            //    Console.WriteLine(item);
            //};
            Console.WriteLine();
            Console.WriteLine("104. ");
            int[] niz1 = { 1, 2, 3 };
            int[] niz2 = { 4, 5, 6 };

            TwoArraysIntoOne(niz1, niz2);
            Console.WriteLine();
            #endregion

            #region 25.
            Console.WriteLine("");
            int[] proba = { 1,5,
 2, 3, 5, 6, 7, 3 };
            int summ = 0;
            for (int i = 0; i < proba.Length; i++)
            {
                if (proba[i] == 5 && proba[i + 1] == 6)
                {
                    i++;
                    continue;
                }
                summ += proba[i];
            }
            Console.WriteLine(summ);
            Console.WriteLine();
            #endregion

            #region 26.
            Console.WriteLine(" ");
            int[] test37 = { 3, 5, 1, 5, 3, 5, 7, 5, 1, 5 };
            //int count = 0;
            //if (test37[test37.Length - 1] == 5 && test37[test37.Length - 2] != 5)
            //{
            //    count++;
            //}
            //for (int i = 0; i < test37.Length - 1; i++)
            //{
            //    if (test37[i] == 5 && test37[i + 1] != 5)
            //    {
            //        count++;
            //    }
            //}
            //if (count == 5)
            //{
            //    Console.WriteLine("ima 5 clanova");

            //}
            bool flag = false;
            int count = 0;
            for (int i = 0; i < test37.Length; i++)
            {
                if (test37[i] == 5 && !flag)
                {
                    count++;
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            if (count == 5)
            {
                Console.WriteLine(true);
            }
            Console.WriteLine();
            #endregion

            #region 26.
            Console.WriteLine("124");
            int[] a = { 1, 2, 3, 4, 1,2, 3 };
            int broj = 3;
            int broj2 = broj;
            for (int i = 0; i < broj2; i++)
            {
                if (a[i] == a[a.Length - broj])
                {
                    broj--;
                    continue;
                }
                else
                {
                    return;
                }
            }
            Console.WriteLine();
            #endregion

            Console.ReadKey();
        }

        private static int[] TwoArraysIntoOne(int[] niz1, int[] niz2)
        {
            //var lista = niz1.ToList();
            //var lista2 = niz2.ToList();
            //lista.AddRange(lista2);

            //return lista.ToArray();

            //int[] outputArray = new int[niz1.Length + niz2.Length];
            //Array.Copy(niz1, outputArray, niz1.Length);
            //Array.Copy(niz2, 0, outputArray, niz1.Length, niz2.Length);
            //return outputArray;

            int[] outputArray = new int[niz1.Length + niz2.Length];
            Buffer.BlockCopy(niz1, 0, outputArray, 0, niz1.Length * sizeof(int));
            Buffer.BlockCopy(niz2, 0, outputArray, niz1.Length * sizeof(int), niz2.Length * sizeof(int));
            return outputArray;
        }

        private static void PopulateArrayWithMaxiumValueOnly(int[] arr2)
        {
            int[] outArr = new int[arr2.Length];
            int max = 0;
            foreach (var item in arr2)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            for (int i = 0; i < outArr.Length; i++)
            {
                outArr[i] = max;
            }
            foreach (var item in outArr)
            {
                Console.Write(item + " ");
            }
        }

        private static void LeftToRightArray(int[] arr1)
        {
            int backward = arr1.Length - 1;
            int[] arrOut = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arrOut[i] = arr1[backward];
                backward--;
            }
            foreach (var item in arrOut)
            {
                Console.WriteLine(item);
            }
        }

        private static void MoveLast2ToStartOfAGivenString(string v)
        {
            Console.WriteLine((v.Substring(v.Length - 2, 2) + v.Substring(0, v.Length - 2)));
        }

        private static int Check58(int x, int y)
        {
            if (x > 13 && y > 13)
            {
                return 0;
            }
            else if (x > 13 && y <= 13)
            {
                return y;
            }
            else if (x <= 13 && y > 13)
            {
                return x;
            }
            return x > y ? x : y;
        }

        public static bool Test(int x, int y, int z, bool flag)
        {
            return flag ? x <= y && y <= z : x < y && y < z;
        }

        private static void CountTwoFivesInArrayOfInts(int[] arrayOfInts2)
        {
            int count = 0;
            for (int i = 0; i < arrayOfInts2.Length - 1; i++)
            {
                if ((arrayOfInts2[i] == 5 && arrayOfInts2[i + 1] == 5) || arrayOfInts2[i] == 5 && arrayOfInts2[i + 1] == 6)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private static void BitWiseOr(int v)
        {
            if (v % 3 == 0 ^ v % 7 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine();
        }

        private static string SpecificIndexesStringCreation(string v)
        {
            string outputString = "";
            for (int i = 0; i < v.Length;)
            {
                if (i % 2 == 0)
                {
                    outputString += v[i];
                    i++;
                }
                else if (i % 2 != 0)
                {
                    outputString += v[i];
                    i += 3;
                }
            }
            Console.WriteLine(outputString);
            return outputString;
        }

        private static string ExcessStringRemoval(string v1, string v2)
        {
            //int startLetter = v1[0];
            //int endLetter = v1[v1.Length - 1];
            //string outputString = "";
            //for (int i = 1; i < v1.Length - 1; i++)
            //{
            //    if (v1[i] == v2[0])
            //    {
            //        outputString += string.Empty;
            //    }
            //    else
            //    {
            //        outputString += v1[i];
            //    }
            //}
            //Console.WriteLine(v1.Substring(0, 1) + outputString + v1.Substring(v1.Length - 1));
            for (int i = 1; i < v1.Length - 1; i++)
            {
                if (v1[i] == v2[0])
                {
                    v1 = v1.Remove(i, 1);
                }
            }
            Console.WriteLine(v1);
            return v1;
        }

        private static void CheckForSequenceAppearance(int[] arrayOfInts)
        {
            bool found = false;
            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                if (arrayOfInts[i] == 1)
                {
                    if (arrayOfInts[i + 1] == 2)
                    {
                        if (arrayOfInts[i + 2] == 3)
                        {
                            found = true;
                        }
                    }
                }
            }
            Console.WriteLine(found);
        }

        private static void CompareLast2CharsToOther(string v)
        {
            string last2Chars = v.Substring(v.Length - 2);
            int count = 0;

            for (int i = 0; i < v.Length - 2; i++)
            {
                if (v.Substring(i, 2).Equals(last2Chars))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private static void MakeStringFrom(string v)
        {
            string outStr = string.Empty;
            for (int i = 0; i < v.Length; i++)
            {
                outStr += v.Substring(0, i + 1);
            }
            Console.WriteLine(outStr);
        }

        private static void DeleteEveryOtherChar(string v)
        {
            string outputString = string.Empty;
            for (int i = 1; i < v.Length; i += 2)
            {
                outputString += v[i];
            }
            Console.WriteLine(v.Substring(0, 1) + outputString);
        }

        private static void RandomizeChars(string v)
        {
            Random random = new Random(1);
            string randomOut = string.Empty;
            for (int i = 1; i < v.Length - 1; i++)
            {
                randomOut += v[random.Next(i + 1, v.Length - 1)];
            }
            Console.WriteLine(v.Substring(0, 1) + randomOut);
        }

        private static void CountStringAA(string v)
        {
            int count = 0;
            for (int i = 0; i < v.Length - 1; i++)
            {
                if (v[i] == v[i + 1])
                {
                    count++;
                }

            }
            Console.WriteLine(count);
        }

        private static void Last3CharsCopy(string v1, int v2)
        {
            string outStr = string.Empty;
            while (v2 > 0)
            {
                if (v1.Length < 3)
                {
                    outStr += v1;
                    v2--;
                }
                else
                {
                    outStr += v1.Substring(0, 3);
                    v2--;
                }
            }
            Console.WriteLine(outStr);
        }

        private static string CopyNTimes(string v1, int v2)
        {
            string v3 = string.Empty;
            while (v2 > 0)
            {
                v3 += v1;
                v2--;
            }
            return v1;
        }

        private static void ConvertLast3CharsToUpper(string v)
        {
            string returning = "";
            if (v.Length < 4)
            {
                returning = v.ToUpper();
            }
            else
            {
                for (int i = v.Length - 3; i < v.Length; i++)
                {
                    returning += v[i].ToString().ToUpper();
                }

            }
            Console.WriteLine(v.Substring(0, 2) + returning);
        }

        private static void CheckIfLastDigitIsSame(int v1, int v2)
        {
            int count = 0;
            string converter1 = v1.ToString();
            string converter2 = v2.ToString();
            for (int i = converter1.Length - 1; i >= converter1.Length - 2; i--)
            {
                for (int j = i; j == i; j--)
                {
                    if (converter1[i] == converter2[j])
                    {
                        count++;
                    }
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Brojevi su isti.");
            }
            else
            {
                Console.WriteLine("Brojevi su razliciti");
            }

        }

        private static int FindLargerValue(int v1, int v2)
        {
            if (v1 >= 20 && v1 <= 30)
            {
                return v1;
            }
            else if (v2 >= 20 && v2 <= 30)
            {
                return v2;
            }
            else
            {
                return 0;
            }
        }

        private static void AddLastCharToFirstAndLastSpot(string v)
        {
            string lastLetter = v[v.Length - 1].ToString();
            Console.WriteLine(lastLetter + v + lastLetter);
        }

        private static void RemoveAndRepeat4Times(string v)
        {
            if (v.Length < 2)
            {
                Console.WriteLine(v);
            }
            else
            {
                int repeater = 4;
                while (repeater > 0)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Console.Write(v[i]);
                    }
                    Console.Write(" ");
                    repeater--;
                }
            }
        }

        private static string RemoveChar(string v1, int v2)
        {
            string newString = v1.Remove(v2, 1);
            return newString;
        }

        private static int ReturnSum(int v1, int v2)
        {
            int sum = 0;
            if (v1 == v2)
            {
                sum = (v1 + v2) * 3;
            }
            else
            {
                sum = v1 + v2;
            }
            return sum;
        }
    }
}
