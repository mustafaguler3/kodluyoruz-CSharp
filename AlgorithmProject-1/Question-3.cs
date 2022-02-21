using System;

namespace Project
{
    class QuestionThree
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Enter a N number.");
            int nNumber = int.Parse(Console.ReadLine());
            string[] array = new string[nNumber];
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine("Enter {0}. worb.",i+1);
                array[i] = Console.ReadLine();
            }
            System.Console.WriteLine("Reverse Spelling of Words Separately Within Themselves ");
            for (int i = 0; i < array.Length; i++)
            {
                char[] textArray = array[i].ToCharArray();
                Array.Reverse(textArray);
                string returnText = new string(textArray);
                System.Console.WriteLine(returnText);
            }
            System.Console.WriteLine("Reverse Order of Given List");
            Array.Reverse(array);
            foreach (var item in array)
            {
                System.Console.WriteLine(item);
            }



           





        }
    }
}