using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void QuestionThree()
        {

            string vowels = "";

            string sentence = Console.ReadLine();
            string cSentence = sentence.Replace(" ", "");
            var chrArr = cSentence.ToCharArray();

            foreach (var item in chrArr)
            {
                if (item == 'a' || item == 'e' || item == 'i' || item == 'ı' || item == 'o' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü')
                {
                    vowels += item;
                }
            }

            foreach (var item in vowels)
                System.Console.WriteLine(item);
        }
        static void QuestionTwo()
        {
            int[] nums = nNumbers(20);
            Array.Sort(nums);

            int max = 0;
            int min = 0;

            int maxAvg = 0;
            int minAvg = 0;
            for (int i = 0; i < 3; i++)
            {
                min += nums[i];
                max += nums[nums.Length - 1 - i];
            }
            minAvg = min / 3;
            maxAvg = max / 3;

            System.Console.WriteLine($"Ortalamaların toplamı :{maxAvg + minAvg}");
        }
        static void QuestionOne()
        {
            ArrayList prime = new();
            ArrayList noPrime = new();

            for (int i = 0; i < 20; i++)
            {
                System.Console.WriteLine($"{i + 1}-num");
                int num = int.Parse(Console.ReadLine());
                if (num  < 0)
                {
                    System.Console.WriteLine("Enter positive number : ");
                    i--;
                    continue;
                }

                if (num .AsalSayıMı())
                    prime.Add(num );

                else
                    noPrime.Add(num );

            }
            prime.Sort();
            prime.Reverse();
            noPrime.Sort();
            noPrime.Reverse();
            System.Console.WriteLine("Prime");
            foreach (var item in prime)
                System.Console.Write(item + "-");

            System.Console.WriteLine(" ");
            System.Console.WriteLine("Not prime");
            foreach (var item in noPrime)
                System.Console.Write(item + "-");
        }

        public static int[] nNumbers(int n)
        {
            List<int> listOfnumbers = new();
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"{i + 1}-number ");
                int num = int.Parse(Console.ReadLine());

                listOfnumbers.Add(snum);
            }

            return listOfnumbers.ToArray();
        }
    }
static class Extension
    {
        public static bool isPrime(this int n)
        {
            if (n == 2)
            {
                return true;
            }
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {

                if (n % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }


    
}