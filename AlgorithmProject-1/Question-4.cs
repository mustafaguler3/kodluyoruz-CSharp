using System;

namespace Project
{
    class QestionFour
    {
        static void Main(string[] args)
        {
            
        
            int numberOfletter = 0;
            System.Console.WriteLine("Enter a sentence ");
            string sentence = Console.ReadLine();
            string[] worb = sentence.Split(" ");
            System.Console.WriteLine("There Are {0} Words In The Given Sentence.",worb.Length);
            for (int i = 0; i < worb.Length; i++)
            {
                 char[] letterArray = worb[i].ToCharArray();
                numberOfletter+= letterArray.Length;
            }
            System.Console.WriteLine("There Are {0} Letters in the Given Sentence.",numberOfletter);



           





        }
    }
}