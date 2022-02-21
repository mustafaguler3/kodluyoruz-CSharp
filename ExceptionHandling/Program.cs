using System;

namespace hatayonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
           //try
           //{
           //    Console.WriteLine("bir sayi giriniz:");
           //    int sayi = Convert.ToInt32(Console.ReadLine());
           //    Console.WriteLine("girmiş olduğunuz sayı:"+sayi);
           //}
           //catch(Exception ex)
           //{
           //    Console.WriteLine("Hata:"+ex.Message.ToString());
           //}
           //finally
           //{
           //    Console.WriteLine("işlem tamamlandı.");
           //}
           
           try
           {
               //int a = int.Parse(null);
               //int a = int.Parse("test");
               int a = int.Parse("-20000000000");
           }
           catch (ArgumentNullException ex)
           {
               Console.WriteLine("boş değer girdiniz");
               Console.WriteLine(ex);
           }
           catch (FormatException ex)
           {
               Console.WriteLine("veri tipi uygun degil");
               Console.WriteLine(ex);
           }    
           catch (OverflowException ex)
           {
               Console.WriteLine("çok kücük veya cok büyük deger girdiniz");
               Console.WriteLine(ex);
           }
           finally
           {
               Console.WriteLine("işlem başarı ile tamamlandı");
           }
           

        }
    }
}