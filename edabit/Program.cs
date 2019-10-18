using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

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
            Console.WriteLine(SumOfMultiplesOfThreeFiveBelowValue(1356));
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
            Console.WriteLine(Century(2135));
            Console.WriteLine(FindSmallestNum(new double[] { 1.05, 2, 3, 4, 5, 7 }));
            string noYellTest = NoYelling("What went wrong?????????");
            Console.WriteLine(noYellTest);
            int[] piratesTravels = new int[] { -1, -4 };
            Console.WriteLine(NumberOfDays(piratesTravels));
            //Console.ReadKey();
            Console.WriteLine(IsPrime(4));
            Console.WriteLine(RemoveSmallest(new int[] { 1, 2, 3, 4, 5 } ));
            Console.WriteLine(AlternatingCaps("whatever you want it to be"));
            //Console.WriteLine(SmallestMultiple());
            //double sumSquareDiff = SumSquareDifference();
            //Console.WriteLine(sumSquareDiff);
            //double massivePrime = FindPrime();
            //Console.WriteLine(massivePrime);
            //Console.WriteLine(largestProduct());
            //SpecialPythagoranTriplet();
            //double sumOfFirstMillPrimes = SumOfPrimesBelowMillion();
            //Console.WriteLine(sumOfFirstMillPrimes);
            //TriangleNumbers();
            Console.WriteLine(BigIntegerSum());
        }

        public static BigInteger BigIntegerSum() {

            string filename = "C:\\Dan\\input.txt";

            BigInteger result = new BigInteger();
            string line;
            StreamReader r = new StreamReader(filename);

            while ((line = r.ReadLine()) != null) {
                result += BigInteger.Parse(line);
            }

            r.Close();

            //List<BigInteger> longList = new List<BigInteger>() { BigInteger.Parse("37107287533902102798797998220837590246510135740250"),
            //                                BigInteger.Parse("46376937677490009712648124896970078050417018260538"),
            //                                BigInteger.Parse("74324986199524741059474233309513058123726617309629"),
            //                                BigInteger.Parse("91942213363574161572522430563301811072406154908250"),
            //                                BigInteger.Parse("23067588207539346171171980310421047513778063246676"),
            //                                BigInteger.Parse("89261670696623633820136378418383684178734361726757"),
            //                                BigInteger.Parse("28112879812849979408065481931592621691275889832738"),
            //                                BigInteger.Parse("44274228917432520321923589422876796487670272189318"),
            //                                BigInteger.Parse("47451445736001306439091167216856844588711603153276"),
            //                                BigInteger.Parse("70386486105843025439939619828917593665686757934951"),
            //                                BigInteger.Parse("62176457141856560629502157223196586755079324193331"),
            //                                BigInteger.Parse("64906352462741904929101432445813822663347944758178"),
            //                                BigInteger.Parse("92575867718337217661963751590579239728245598838407"),
            //                                BigInteger.Parse("58203565325359399008402633568948830189458628227828"),
            //                                BigInteger.Parse("80181199384826282014278194139940567587151170094390"),
            //                                BigInteger.Parse("35398664372827112653829987240784473053190104293586"),
            //                                BigInteger.Parse("86515506006295864861532075273371959191420517255829"),
            //                                BigInteger.Parse("71693888707715466499115593487603532921714970056938"),
            //                                BigInteger.Parse("54370070576826684624621495650076471787294438377604"),
            //                                BigInteger.Parse("53282654108756828443191190634694037855217779295145"),
            //                                BigInteger.Parse("36123272525000296071075082563815656710885258350721"),
            //                                BigInteger.Parse("45876576172410976447339110607218265236877223636045"),
            //                                BigInteger.Parse("17423706905851860660448207621209813287860733969412"),
            //                                BigInteger.Parse("81142660418086830619328460811191061556940512689692"),
            //                                BigInteger.Parse("51934325451728388641918047049293215058642563049483"),
            //                                BigInteger.Parse("62467221648435076201727918039944693004732956340691"),
            //                                BigInteger.Parse("15732444386908125794514089057706229429197107928209"),
            //                                BigInteger.Parse("55037687525678773091862540744969844508330393682126"),
            //                                BigInteger.Parse("18336384825330154686196124348767681297534375946515"),
            //                                BigInteger.Parse("80386287592878490201521685554828717201219257766954"),
            //                                BigInteger.Parse("78182833757993103614740356856449095527097864797581"),
            //                                BigInteger.Parse("16726320100436897842553539920931837441497806860984"),
            //                                BigInteger.Parse("48403098129077791799088218795327364475675590848030"),
            //                                BigInteger.Parse("87086987551392711854517078544161852424320693150332"),
            //                                BigInteger.Parse("59959406895756536782107074926966537676326235447210"),
            //                                BigInteger.Parse("69793950679652694742597709739166693763042633987085"),
            //                                BigInteger.Parse("41052684708299085211399427365734116182760315001271"),
            //                                BigInteger.Parse("65378607361501080857009149939512557028198746004375"),
            //                                BigInteger.Parse("35829035317434717326932123578154982629742552737307"),
            //                                BigInteger.Parse("94953759765105305946966067683156574377167401875275"),
            //                                BigInteger.Parse("88902802571733229619176668713819931811048770190271"),
            //                                BigInteger.Parse("25267680276078003013678680992525463401061632866526"),
            //                                BigInteger.Parse("36270218540497705585629946580636237993140746255962"),
            //                                BigInteger.Parse("24074486908231174977792365466257246923322810917141"),
            //                                BigInteger.Parse("91430288197103288597806669760892938638285025333403"),
            //                                BigInteger.Parse("34413065578016127815921815005561868836468420090470"),
            //                                BigInteger.Parse("23053081172816430487623791969842487255036638784583"),
            //                                BigInteger.Parse("11487696932154902810424020138335124462181441773470"),
            //                                BigInteger.Parse("63783299490636259666498587618221225225512486764533"),
            //                                BigInteger.Parse("67720186971698544312419572409913959008952310058822"),
            //                                BigInteger.Parse("95548255300263520781532296796249481641953868218774"),

            //};

            //BigInteger result;
            //foreach (var item in longList) {
            //    result = item + item;
            //}
            return result;
        }

        public static void TriangleNumbers() {
            int result = 0;
            int logCount = 0;
            List<int> divisorList = new List<int>();
            for (int i = 0; i <= 50000000; i++) {
                result += i;                
                divisorList.Clear();
                for (int j = 1; j <= result/2; j += 1) {
                    if ((result % j) == 0) {
                        divisorList.Add(j);
                        if (divisorList.Count() >= 500) {
                            Console.WriteLine($" 500 : {result}");
                        }                        
                    }
                }
            }
        }

        public static double SumOfPrimesBelowMillion() {
            
            bool primeFlag = false;
            double result = 0;
            for (double j = 1; j < 2000000; j++) {
                primeFlag = FindPrimeHelper(j);
                if (primeFlag) {
                    result += j;
                }
                
            }

            return result;
        }



        public static void SpecialPythagoranTriplet() {
            List<int> result = new List<int>();
            double c = 0;
            for (int a = 1; a < 1000; a++) {
                for (int b = 2; b < 1000; b++) {
                    c = Math.Sqrt(a * a + b * b);                    
                    if(a + b + c == 1000) {
                        Console.WriteLine($"a: {a} b: {b} c: {c} ");
                        Console.WriteLine($"answer: {a * b * c}");
                        break;
                    }
                }
            }            
        }


        public static double largestProduct() {
            
            
            List<double> totalsList = new List<double>();
            string sample = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            for (int i = 0; i < sample.Length-13; i++) {
                double result = 1;
                for (int j = 0; j <= 12; j++) {
                    int c = (int) Char.GetNumericValue(sample[i + j]);
                    result *= c;
                }
                
                totalsList.Add(result);

            }



            return totalsList.Max();
        }

        public static double FindPrime() {
            List<double> primeList = new List<double>();
            bool primeFlag = false;
            double result = 0;
            for (double j = 1; j < 200000000000; j++) {
                primeFlag = FindPrimeHelper(j);
                if (primeFlag) {
                    primeList.Add(j);
                }
                if(primeList.Count() >= 10001) {
                    result = j;
                    break;
                }                
            }

            return result;
        }

        public static bool FindPrimeHelper (double value) {
            // Test whether the parameter is a prime number.
            if(value <= 2) {
                if (value == 2) {
                    return true;
                }
                else {
                    return false;
                }
            }
            
            for (int i = 2; i <= Math.Sqrt(value); i += 1) {
                if ((value % i) == 0) {
                    return false;
                }
            }
            return true;
        }


        public static double SumSquareDifference() {
            double result = 0;
            double squared = 0;
            double summed = 0;
            for (double i = 1; i <=100 ; i++) {
                squared += (i * i);
            }

            for (int i = 0; i <= 100; i++) {
                summed += i;
            }
            summed = summed * summed;
            result = summed - squared;

            return result;
        }
        public static double SmallestMultiple() {
            double result = 0;
            bool bFlag = false;
            for (double i = 40; i < 2000000000000; i++) {
                for (double j = 1; j <= 20; j++) {
                    if (i % j == 0) {
                        bFlag = true;
                        if (j == 20) {
                            result = i;
                            bFlag = true;
                            break;
                        }
                    }else {
                        bFlag = false;
                        break;
                    }
                }
                if(bFlag == true) {
                    break;
                }
            }
            
            return result;
        }

        public static string AlternatingCaps(string str) {
            //str.ToLower();
            string intermediaryString = str;
            string returnString = "";
            
            for (int i = 0; i <= str.Length -1; i++) {
                string spaceString = " ";
                if ((str[i] == spaceString.ToCharArray()[0])) {
                    returnString += " ";
                    continue;
                }


                if (i == 0) {
                    returnString += Char.ToUpper(str[i]);
                    continue;
                }
                if(Char.IsWhiteSpace(returnString[i-1])){
                    returnString = (Char.IsUpper(returnString[i - 2])) ? returnString += Char.ToLower(intermediaryString[i]) : returnString += Char.ToUpper(intermediaryString[i]);
                }
                else {
                    returnString = (Char.IsUpper(returnString[i - 1])) ? returnString += Char.ToLower(intermediaryString[i]) : returnString += Char.ToUpper(intermediaryString[i]);
                }
                

            }              
            
            return returnString;

            //better way below
            //bool isUpper = true;
            //string returnStr = "";
            //foreach (char c in str) {
            //    if (isUpper && c != ' ') {
            //        returnStr += char.ToUpper(c);
            //        isUpper = false;
            //    }
            //    else if (!isUpper && c != ' ') {
            //        returnStr += char.ToLower(c);
            //        isUpper = true;
            //    }
            //    else {
            //        returnStr += " ";
            //    }
            //}
            //return returnStr;
        }

        public static int[] RemoveSmallest(int[] values) {
            if(values.Length == 0) {
                return values;
            }
            int min = values.Min();

            values = values.Where(x => x != min ).ToArray();
            
            return values;
        }

        public static bool RemoveSpecialCharacters(string str) {            
            return Regex.IsMatch(str, @"^\(\d{3}\) \d{3}\-\d{4}$");
        }

        public static string FormatNum(int num) {
            string numString = num.ToString("#,##0");
            return numString;
        }

        public static bool IsPrime(int value) {
            if (value <= 1) {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(value); i+=2) {
                if(value % i == 0) {
                    return false;
                }
            }
            return true;
        }

        public static int NumberOfDays(int[] coordinates) {
            int returnNum = 0;

            foreach (var item in coordinates) {
                returnNum += Math.Abs(item);
            }
            
            int extraRestNotRequired = returnNum % 5 == 0 ?  -1 : 0;
            int restDays = returnNum / 5;
            returnNum = returnNum  + restDays + extraRestNotRequired;
            
            return returnNum;

            //int travelDays = Math.Abs(coordinates[0] + coordinates[1]);
            //int restDays = (travelDays - 1) / 5;
            //return travelDays + restDays;
        }


        public static string NoYelling(string phrase) {
            if (phrase.EndsWith("??")) {
                char[] MyChar = { '?' };
                phrase = phrase.TrimEnd(MyChar);
                string questionMark = "?";
                phrase += questionMark;
            }
            return phrase;
        }

        public static double FindSmallestNum(double[] arr) {
            return arr.Min();
        }

        public static string Century(int year) {
            int zeroYearSum = 0;
            int counter = 0;

            year = year / 100;

            while (year != 0) {
                zeroYearSum += year % 10;
                year /= 10;
                counter++;
                if (counter >= 2) {
                    break;
                }
            }

            if(zeroYearSum != 0) {
                year++;
            }
            string suffix = getYearSuffix(year);
            return $"{year}{suffix} century";
        }

        static string getYearSuffix(int day) {
            switch (day) {
                case 1:
                case 21:
                case 31:
                    return "st";
                case 2:
                case 22:
                    return "nd";
                case 3:
                case 23:
                    return "rd";
                default:
                    return "th";
            }
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
