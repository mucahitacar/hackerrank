using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //GradingQuestion();
            //CountApplesAndOrangesQuestion();
            //KangarooQuestion();
            //SolutionQuestion();
            //plusMinusQuestion();
            //miniMaxSumQuestion();
            //fac(2);
            //timeConversionQuestion();
            //findMedianQuestion();
            //lonelyintegerQuestion();
            //diagonalDifferenceQuestion();
            //countingSortQuestion();
            flippingMatrixQuestion();
        }
        #region 
        private static void GradingQuestion()
        {
            var gradingStudentsResult = gradingStudents(new List<int> { 73, 67, 38, 33 });
            foreach (var item in gradingStudentsResult)
            {
                Console.WriteLine(item);
            }
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> newList = new List<int>();
            var temp = 0;
            foreach (var item in grades)
            {
                temp = item;
                if (item >= 38)
                {
                    int value = (int)Math.Round(item / 5.0) * 5;
                    if (value - item >= 0)
                        newList.Add(value);
                    else
                        newList.Add(item);
                }
                else
                    newList.Add(item);
            }
            return newList;
        }

        static void CountApplesAndOrangesQuestion()
        {
            countApplesAndOranges(7, 11, 5, 15, new List<int> { -2, 2, 1 }, new List<int> { 5, -5 });
        }
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int samStart = s;
            int samEnd = t;
            int appleT = a;
            int orangeT = b;
            var apple = apples;
            var orange = oranges;
            var appleCount = 0;
            var orangeCount = 0;

            List<int> sumApple = new List<int>();
            List<int> sumOrange = new List<int>();
            foreach (int item in apple)
            {
                if (item + appleT >= s && item + appleT <= t)
                    appleCount++;
            }

            foreach (int item in orange)
            {
                if (item + orangeT >= s && item + orangeT <= t)
                    orangeCount++;
            }
            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }

        static void KangarooQuestion()
        {
            Console.WriteLine(kangaroo(0, 2, 5, 3));
        }
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            while (x1 < x2)
            {
                x1 += v1;
                x2 += v2;

            }
            if (x1 == x2)
                return "YES";
            else
                return "NO";
        }

        static void SolutionQuestion()
        {
            int[] solution3 = solution(new int[] { -9, -7, 5, 7, 9 });
            foreach (var item in solution3)
            {
                Console.WriteLine(item);
            }

        }
        static int[] solution(int[] arr)
        {
            var max = 0;
            int[] maxArr = new int[2];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int y = i; y < arr.Length; y++)
                {
                    if (y != i)
                    {
                        if (arr[i] * arr[y] > max)
                        {
                            max = arr[i] * arr[y];
                            maxArr[0] = arr[i];
                            maxArr[1] = arr[y];
                        }
                        else if (arr[i] * arr[y] == max)
                        {
                            if ((arr[i] + arr[y]) > (maxArr[0] + maxArr[1]))
                            {
                                maxArr[0] = arr[i];
                                maxArr[1] = arr[y];
                            }
                        }
                    }
                }
            }
            return maxArr;
        }

        static void plusMinusQuestion()
        {
            plusMinus(new List<int> { 1, 1, 0, -1, -1 });
        }
        public static void plusMinus(List<int> arr)
        {
            Console.WriteLine(decimal.Round(arr.Where(i => i > 0).Count() / (decimal)arr.Count, 6));
            Console.WriteLine(decimal.Round((decimal)arr.Where(i => i < 0).Count() / (decimal)arr.Count, 6));
            Console.WriteLine(decimal.Round(arr.Where(i => i == 0).Count() / (decimal)arr.Count, 6));

        }

        static void miniMaxSumQuestion()
        {
            miniMaxSum(new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 });
        }
        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            List<ulong> longList = new List<ulong>();
            foreach (var item in arr)
            {
                longList.Add((ulong)item);
            }
            ulong toplam = 0;
            foreach (var item in longList)
            {
                toplam += item;
            }
            //Console.WriteLine(arr.First()+" "+ arr.Last());
            Console.WriteLine((toplam - (ulong)arr.Last()) + " " + (toplam - (ulong)arr.First()));
        }

        public static void fac2(int n)
        {
            long maxPrime = -1;

            while (n % 2 == 0)
            {
                maxPrime = 2;
                n = n / 2;
            }

            while (n % 3 == 0)
            {
                maxPrime = 3;
                n = n / 3;
            }

            for (int i = 5; i <= Math.Sqrt(n); i += 6)
            {
                while (n % i == 0)
                {
                    maxPrime = i;
                    n = n / i;
                }
                while (n % (i + 2) == 0)
                {
                    maxPrime = i + 2;
                    n = n / (i + 2);
                }
            }

            if (n > 4)
                maxPrime = n;

            Console.WriteLine(maxPrime);
        }
        public static void fac(int n)
        {
            long max = 0;
            int[] maxArr = new int[n];
            var str = "48705898309458093485";

            long[] asd = new long[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                asd[i] = Convert.ToInt64(str[i].ToString());
            }
            //int[] result = asd.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();

            long carpim = 1;
            for (int y = 0; y < asd.Length; y++)
            {
                for (int i = y; i < n + y; i++)
                {
                    carpim *= asd[i];
                }

                if (carpim > max)
                {
                    max = carpim;
                }
                carpim = 1;
            }
            Console.WriteLine(max);

        }

        static void timeConversionQuestion()
        {
            timeConversion("07:05:45PM");
        }
        public static string timeConversion(string s)
        {
            DateTime date = new DateTime();
            var dateTime = Convert.ToDateTime(s).TimeOfDay.ToString();
            return dateTime;
        }

        static void findMedianQuestion()
        {
            findMedian(new List<int> { 0, 4, 5, 1, 3 });
        }
        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            int value = arr[arr.Count / 2];
            //Console.WriteLine(value);
            return value;
        }

        static void lonelyintegerQuestion()
        {
            lonelyinteger(new List<int> { 0, 0, 5, 5, 3 });
        }
        public static int lonelyinteger(List<int> a)
        {
            IEnumerable<IGrouping<int, int>> groupBy = a.GroupBy(i => i);
            int key = groupBy.Where(g => g.Count() == 1).FirstOrDefault().Key;
            return key;
        }

        static void diagonalDifferenceQuestion()
        {
            diagonalDifference(new List<List<int>> { new List<int> { 5, 2, 3 }, new List<int> { 1, 2, 3 }, new List<int> { 1, 2, 3 } });
        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            var sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i][i];
            }
            var sum2 = 0;
            var y = arr.Count-1;
            for (int i = 0; i < arr.Count; i++)
            {
                sum2 += arr[y][i];
                y--;
            }
            //Console.WriteLine(sum - sum2);
            return Math.Abs(sum - sum2);
        }

        #endregion

        static void countingSortQuestion()
        {
            countingSort(new List<int> { 1, 2, 3, 4 });
        }
        public static List<int> countingSort(List<int> arr)
        {
            var array = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                array.Add(0);
            }
            for (int i = 0; i < arr.Count; i++)
            {
                array[arr[i]]++;
            }
            //Console.WriteLine(array);
            return array;
        }

        static void flippingMatrixQuestion()
        {
            flippingMatrix(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3, 4}});
        }
        public static int flippingMatrix(List<List<int>> matrix)//todo
        {
            int n = matrix.Count/2;
            var top = 0;
            var max = 0;
            for (int i = 0; i < matrix.Count; i++)
            {
                var topA = 0;
                var topB = 0;
                for (int y = 0; y < matrix.Count/2; y++)
                {
                    topA += matrix[i][y];

                }
                for (int y = matrix.Count/2; y < matrix.Count; y++)
                {
                    topB += matrix[i][y];
                }
                if(topB>topA)
                    for (int x = 0; x < matrix.Count; x++)
                    {
                        var temp = matrix[matrix.Count];
                        matrix[i][x] = matrix[i][matrix.Count];

                    }
            }
            return 0;
        }
    }
}
