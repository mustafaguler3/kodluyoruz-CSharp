using System;

namespace Odevler
{
    class Sorubir
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Enter positive number : ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                System.Console.WriteLine("Please enter {0}. number",i+1);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]%2 == 0)
                    System.Console.WriteLine("even number is  "+array[i]);
                else
                    System.Console.WriteLine(array[i]+" is not even.");
            }



           





        }
    }
}