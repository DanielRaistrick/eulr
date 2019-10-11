using System;
using System.Collections.Generic;
using System.Linq;

namespace edabit {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            bool test = isEmpty("");
            Console.WriteLine(test);
            bool test1 = isEmpty(" ");
            Console.WriteLine(test1);
            Console.WriteLine(FindLargestNum(new int[] { 1, 2, 3, 4, 5, 7 }));
            Console.WriteLine(differenceMaxMin(new int[] { 1, 2, 3, 4, 5, 7 }));
            Console.WriteLine(SumOfMultiplesOfThreeFiveBelowValue(1000));
            //Console.WriteLine(SumOfEvenFibonacciNumbersBelowValue(4000000));
            //Console.WriteLine(PrimeFactorCalculator(600851475143));
            //List<long> listLong = Generate(600851475143);
            //foreach(long v in listLong) {
            //    Console.WriteLine(v);
            //}
            //Console.WriteLine(DoubleLetters("soomeWord"));
            string whatever = OddishOrEvenish(4352);
            Console.WriteLine(whatever );
            Console.WriteLine(gcd(32,8));
            Console.WriteLine(FindDigitAmount(0));
        }

        public static int FindDigitAmount(int num) {
            //should have done it as per this comment
            //return num.ToString().Length;

            if (num == 0) {
                return 1;
            }
            int sum = 0;
            int counter = 0;
            while (num != 0) {
                sum += num % 10;
                num /= 10;
                counter++;
            }
            return counter;

        }

        public static int gcd(int n1, int n2) {
            
            int max = n2;
            int result = 0;
            if (n1 > n2) { 
                max = n1; 
            }

            for(int i = 1; i < max; i++) {
                if (n1 % i == 0 && n2 % i == 0) {
                    result = i;
                }
            }

            return result;

        }

        public static string OddishOrEvenish(int num) {
            int sum = 0;
            while (num != 0) {
                sum += num % 10;
                num /= 10;
            }
            return (sum % 2 != 0 ? "Oddish" : "evenish"); 
        }

        public static string RemoveFirstLast(string str) {
            if (str.Length <= 2) {
                return str;
            }

            str = str.Remove(str.Length - 1);
            str = str.Remove(0, 1);

            return str;
        }

        public static bool DoubleLetters(string word) {
            int wordLen = word.Length - 1;

            for (int i = 0; i < wordLen; i++) {                                
                if (word[i] == word[i + 1]) {
                    return true;
                }  
            }            
            return false;
        }


        public static bool isEmpty(string str) {
            return (str.Contains(" "));
        }

        public static string IsEvenOrOdd(int num) {
            return (num % 2 == 0) ?  "even" : "odd";
        }

        public static bool match(string s1, string s2) {
            return (s1.ToLower() == s2.ToLower());
        }

        public static bool IsPlural(string word) {
            int length = word.Length;

            return word.EndsWith("s");
        }

        public static object GetLastItem(object[] arr) {            
            return arr[arr.Length - 1];
        }

        public static int FindLargestNum(int[] arr) {
            return arr.Max();
        }

        public static int differenceMaxMin(int[] arr) {
            return arr.Max() - arr.Min();

        }

        public static int SumOfMultiplesOfThreeFiveBelowValue (int value) {

            int sum = 0;

            for(int i = 1; i < value; i++ ) {
                if (i % 3 == 0 || i % 5 == 0) {
                    sum += i;
                }                    
            }
            return sum;
        }

        public static double SumOfEvenFibonacciNumbersBelowValue(int value) {
            double fibNum = 0;
            double total = 0;
            double j = 1;
            double k = 0;
            for (int i = 1; i <= value; i ++) {
                fibNum = k + j;
                Console.WriteLine($"fibNum {fibNum} i {i}");
                if ((fibNum % 2) == 0 && (fibNum <= value)) {
                    total += fibNum;
                    Console.WriteLine($"fibNum {fibNum} i {i}");
                }
                k = j;
                j = fibNum;

                if (fibNum > value) {
                    Console.WriteLine($"fibNum {fibNum} i {i}");
                    break;
                }
            }
            return total;
        }

        public static double PrimeFactorCalculator(double value) {
            double primeNum = 0;


            for (double div = 2; div <= Math.Sqrt(value); div++)
                //for (decimal i = 2; i <= value; i++)
                {
                if(value % div == 0) {
                    primeNum = div;
                    Console.WriteLine(div);
                }
            }
            return primeNum;
        }

        public static List<long> Generate(long number) {
            var primes = new List<long>();

            for (int div = 2; div <= number; div++) {
                while (number % div == 0) {
                    primes.Add(div);
                    number = number / div;
                }
            }
            return primes;
        }
    }
}
