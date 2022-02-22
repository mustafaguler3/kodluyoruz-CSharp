using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook;

namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            TelephoneContact contact = new TelephoneContact();



            while (true)
            {
                Console.WriteLine("lütfen yapmak istediğiniz islemi seciniz :)\n1 - Yeni numara ekle\n2 - Varolan numarayı sil\n3 - Varolan numarayı guncelle\n4 - Rehberi listele\n5 - Rehberde arama yapamak");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Console.WriteLine("İsim girin:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Numara girin:");
                        long number = Convert.ToInt64(Console.ReadLine());
                        contact.save(name, number);
                        Console.WriteLine("Kayıt eklendi");
                        contact.list();
                        break;
                    case 2:
                        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                        string username = Console.ReadLine();
                        if (contact.search(username) != username)
                        {
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için      : (2)");
                            if(select == 1){
                                break;
                            }else if(select == 2){
                                contact.list();
                            }
                        }
                        else
                        {
                            contact.delete(username);
                            Console.WriteLine("user silindi:");
                        }

                        
                        break;
                    case 3:
                        Console.WriteLine("Güncellestirmek istediginiz kisinin adini yazınız");
                        string namee = Console.ReadLine();
                        if(contact.search(namee) != namee){
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Güncellemeyi sonlandırmak için    : (1)\n* Yeniden denemek için      : (2)");
                            int selecTwo = Convert.ToInt32(Console.ReadLine());
                            if(selecTwo == 1){
                                break;
                            }else if(selecTwo == 2){
                                contact.list();
                            }
                        }else {
                            contact.update(namee);
                            Console.WriteLine("güncelleme basarılı.");
                        }                        
                        
                        break;    
                    case 4:
                        contact.list();
                        break;
                    case 5:
                        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n**********************************************\nİsim veya soyisime göre arama yapmak için: (1)\nTelefon numarasına göre arama yapmak için: (2)");
                        int selectThree = Convert.ToInt32(Console.ReadLine());
                        if(selectThree == 1){
                            Console.WriteLine("Aramak istediginiz ismi yaziniz: ");
                            string searchname = Console.ReadLine();
                            if(contact.search(searchname) != null){
                                Console.WriteLine("Aradıgınız isim -> "+searchname);
                            }else {
                                Console.WriteLine("Böyle bir isim bulunamadı.");
                            }
                        }else if(selectThree == 2){
                            Console.WriteLine("Aranacak telefon numarasını giriniz: ");
                            long phone = Convert.ToInt64(Console.ReadLine());
                            if(contact.search(phone) != null){
                                Console.WriteLine("Aradıgınız numara -> "+phone);
                            }else {
                                Console.WriteLine("Böyle bir telefon numarası yoktur.");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Ekranda bulunmayan seçim yaptınız.");
                        break;    
                }
            }


        }
    }




}
