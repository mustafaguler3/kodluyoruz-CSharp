using System;

namespace Project
{
    class QuestionTwo
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Enter N number");
            int nNumber= int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter M number");
            int mNumber = int.Parse(Console.ReadLine());
            int[] array = new int[nNumber];
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine("Enter {0}. number ",i+1);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]%mNumber == 0)
                    System.Console.WriteLine(array[i]+" is able to divided by M number");
                else if (array[i]==mNumber)
                {
                    System.Console.WriteLine(array[i]+" is equal to M number");
                }
                else
                {
                    System.Console.WriteLine(array[i]+" is not able to divided by M number");
                }
            }



           





        }
    }
}