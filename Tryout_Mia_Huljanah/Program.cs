using System;
using System.Collections.Generic;
using System.Linq;

namespace Tryout_Mia_Huljanah
{
    class Program
    {
        public static void Main(string[] args)
        {
            //NumberOne.hello();
            //NumberTwo.Birthday();
            //NumberThree.Len();
            // We have some word collection ...
            //var censoredWords = new List<string>() { "imperdiet", "dolor", "duo" };

            // and a paragraph.
            //var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";
            //NumberFour.Censor(censoredWords, paragraph);
            //NumberFive.IsOdd(4);
            //NumberFive.IsEven(8);
            //NumberSix.Grade(90);
            //NumberSix.Grade(40);
            //NumberSeven.CelciusToFahrenheit(0);
            //NumberSeven.FahrenheitToCelcius(50);
            //NumberSeven.CelciusToKelvin(100);
            //NumberSeven.KelvinToCelcius(375);
            //NumberSeven.KelvinToFahrenheit(375);
            //NumberSeven.FahrenheitToKelvin(12);
            //NumberEight.IsLeapYear(2020);
            //NumberEight.IsLeapYear(2019);
            //var jakarta = Tuple.Create("Jakarta", 7);
            //var bali = Tuple.Create("Bali", 8);
            //var london = Tuple.Create("London", 0);
            //var cairo = Tuple.Create("Cairo", 2);
            //var denver = Tuple.Create("Denver", -6);
            //var chicago = Tuple.Create("Chicago", -5);
            //NumberNine.TimezoneDiff(jakarta, bali);
            //NumberTen.Sum(1, 6);
            //NumberTen.Substract(6, 1);
            //NumberTen.Multiply(2, 6);
            //NumberTen.Divide(6, 2);
            //NumberEleven.Eleven();
            //NumberTwelve.uppercase();
            //NumberThirteen.CountWords();
            //NumberFourteen.IsPalindrom();
            //NumberFifteen.Mirror();
            //string[] fruits = { "Jeruk", "Apel", "Anggur", "Pepaya", "Pisang", "Kiwi", "Markisa" };
            //NumberSixteen.IndexFinder(fruits, "Apel");
            //NumberSeventeen.Looper();
            //NumberEighteen.FindMax();
            //NumberEighteen.FindMin();
            //NumberEighteen.FindAverage();
            //NumberNineteen.SortNumber();
            //NumberTwenty item = new NumberTwenty();
            //item.name = "Indomie Goreng";
            //item.price = 3500;
            //item.onSale = true;
            //Console.WriteLine(item.print());
        }
    }
    class NumberOne
    {
        public static void hello()
        {
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            Console.WriteLine($"Hello my name is {Name}");
        }
    }
    class NumberTwo
    {
        public static void Birthday()
        {
            DateTime Birthday1 = new DateTime(1997, 05, 31);
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, Birthday1.Month, Birthday1.Day);

            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            int days = (nextBirthday - today).Days;
            int remaining = days;
            Console.WriteLine($"Today is {today} and {remaining} days remaining to my next birthday.");
        }
    }
    class NumberThree
    {
        public static void Len()
        {
            string HW = "Hello World!";
            string HU = "Hello Universe!";
            int HWLength = HW.Length;
            int HULength = HU.Length;
            Console.WriteLine($"'Hello World!' have {HWLength} characters");
            Console.WriteLine($"'Hello Universe! have {HULength} characters");
        }
    }
    class NumberFour
    {
        public static void Censor(List<string> censor,string value)
        {
            for (int i=0; i < censor.Count; i++)
            {
                string k = "";
                for (int j =0; j < censor[i].Length; j++)
                {
                    k += "*";
                }
                value = value.Replace(censor[i], k);
            }
            Console.WriteLine(value);
        }
    }
    class NumberFive
    {
        public static void IsOdd(int num)
        {
            bool y;
            if (num % 2 != 0)
            {
                y = true;
            }
            else
            {
                y = false;
            }
            Console.WriteLine(y);
        }

        public static void IsEven(int num)
        {
            bool z;
            if (num % 2 == 0)
            {
                z = true;
            }
            else
            {
                z = false;
            }
            Console.WriteLine(z);
        }
    }
    class NumberSix
    {
        public static void Grade(int x)
        {
            string k = "";
            if (x >= 90)
            {
                k = "A";
            }
            else if (79 < x && x < 89)
            {
                k = "B";
            }
            else if (69 < x && x < 80)
            {
                k = "C";
            }
            else if (59 < x && x < 70)
            {
                k = "D";
            }
            else
            {
                k = "E";
            }
            Console.WriteLine(k);
        }
    }
    class NumberSeven
    {
        public static void CelciusToFahrenheit(double CF)
        {
            double F = 0;
            F = ((CF * 9) / 5) + 32;
            Console.WriteLine(F);
        }

        public static void FahrenheitToCelcius(double FC)
        {
            double C = 0;
            C = ((FC - 32) * 5) / 9;
            Console.WriteLine(C);
        }

        public static void CelciusToKelvin(double CK)
        {
            double K = 0;
            K = CK + 273.15;
            Console.WriteLine(K);
        }

        public static void KelvinToCelcius(double KC)
        {
            double C2 = 0;
            C2 = KC - 273.15;
            Console.WriteLine(C2);
        }

        public static void KelvinToFahrenheit(double KF)
        {
            double F2 = 0;
            F2 = ((KF - 273.15) * 9 / 5) + 32;
            Console.WriteLine(F2);
        }

        public static void FahrenheitToKelvin(double FK)
        {
            double K2 = 0;
            K2 = ((FK - 32) * 5 / 9) + 273.15;
            Console.WriteLine(K2);
        }
    }
    class NumberEight
    {
        public static void IsLeapYear(int year)
        {
            bool y = DateTime.IsLeapYear(year);
            Console.WriteLine(y);
        }
    }
    class NumberNine
    {
        public static void TimezoneDiff(Tuple<string, int>Ibukota1, Tuple<string, int>Ibukota2)
        {
            if(Ibukota1.Item2 > Ibukota2.Item2)
            {
                Console.WriteLine($"{Ibukota1.Item1} {Ibukota1.Item2-Ibukota2.Item2} hours ahead {Ibukota2.Item1}");
            }
            else if (Ibukota1.Item2 < Ibukota2.Item2)
            {
                Console.WriteLine($"{Ibukota1.Item1} {Ibukota2.Item2 - Ibukota1.Item2} hours behind {Ibukota2.Item1}");
            }
        }
    }
    class NumberTen
    {
        public static void Sum(int a, int b)
        {
            int c = 0;
            c = a + b;
            Console.WriteLine(c);
        }

        public static void Substract(int a, int b)
        {
            int d = 0;
            d = a - b;
            Console.WriteLine(d);
        }

        public static void Multiply(int a, int b)
        {
            int e = 0;
            e = a * b;
            Console.WriteLine(e);
        }

        public static void Divide(int a, int b)
        {
            int f = 0;
            f = a / b;
            Console.WriteLine(f);
        }
    }
    class NumberEleven
    {
        public static void Eleven()
        {
            int[] arr = new int[] { 1, 5, 8, 3 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }
    class NumberTwelve
    {
        public static void uppercase()
        {
            Console.WriteLine("Masukkan kalimat yang anda inginkan :");
            string args = Console.ReadLine();
            String Args = args.ToUpper();
            Console.WriteLine(Args);
        }
    }
    class NumberThirteen
    {
        public static void CountWords()
        {
            Console.WriteLine("Masukkan kata yang diinginkan : ");
            string str = Console.ReadLine();
            int intCount = 0;
            string[] split = str.Split(' ');
            foreach (string word in split)
            {
                intCount += 1;
            }
            Console.WriteLine(intCount);
        }
    }
    class NumberFourteen
    {
        public static void IsPalindrom()
        {
            Console.WriteLine("Masukkan kata yang anda inginkan;");
            string string1 = Console.ReadLine();
            char[] ch = string1.ToCharArray();
            Array.Reverse(ch);
            string rev = new string(ch);

            bool y = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(y);
        }
    }
    class NumberFifteen
    {
        public static void Mirror()
        {
            Console.WriteLine("Masukkan kata yang ada inginkan");
            string s = Console.ReadLine();
            char[] w = s.ToCharArray();
            string wr = String.Empty;
            for (int i = s.Length - 1; i > -1; i--)
            {
                wr += s[i];
            }
            Console.WriteLine(s + wr);
        }
    }
    class NumberSixteen
    {
        public static void IndexFinder(string[] fruit, string str)
        {
            Console.WriteLine(Array.IndexOf(fruit, str));
        }

    }
    class NumberSeventeen
    {
        public static void Looper()
        {
            for (int i = 1; i < 1001; i++)
            {
                if (i % 100 == 0 && i % 20 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("300. Baz");
                }
                else if (i % 20 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("40. Bar");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("5. Foo");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class NumberEighteen
    {
        public static void FindMax()
        {
            int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };
            Console.WriteLine(numbers.Max());
        }
        public static void FindMin()
        {
            int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };
            Console.WriteLine(numbers.Min());
        }
        public static void FindAverage()
        {
            int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };
            Console.WriteLine(numbers.Average());
        }
    }
    class NumberNineteen
    {
        public static void SortNumber()
        {
            int[] points = new int[] { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 45 };
            Array.Sort(points);
            foreach (int value in points)
            {
                Console.WriteLine(value);
            }
        }
    }
    class NumberTwenty
    {
        // PROPERTIES
        public string name { get; set; }
        public double price { get; set; }
        public bool onSale { get; set; }

        // METHODS
        public string print()
        {
            if (onSale == true)
            {
                price = 0.8 * price;
                return $"{name} {price}";
            }
            else
            {
                price = price;
                return $"{name} {price}";
            }

        }

        
    }
}
