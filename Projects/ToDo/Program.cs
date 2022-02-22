using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo;

namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {

            Board board = new Board();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :\n*******************************************\n(1) Board Listelemek\n(2) Board'a Kart Eklemek\n(3) Board'dan Kart Silmek\n(4) Kart Taşımak");

            int select = Convert.ToInt32(Console.ReadLine());
            
            switch(select){
                case 1:
                    board.List();
                    break;
                case 2:
                    Console.WriteLine("Başlık Giriniz");
                    string title = Console.ReadLine();   
                    Console.WriteLine("İçerik Giriniz ");
                    string content = Console.ReadLine();
                    Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
                    int size = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kişi Seçiniz");   
                    int id = Convert.ToInt32(Console.ReadLine());
                    Card card = new Card(title,content, (Card.Size)size,new Member(id));

                    board.Add(card);
                    System.Console.WriteLine("Card eklendi."); 
                    break;
                case 3:
                    Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız:");
                    string deleteTitle = Console.ReadLine();
                    if(board.GetCard(deleteTitle) !=null){
                        board.Delete(deleteTitle);
                        Console.WriteLine("card silindi.");
                    }else{
                        Console.WriteLine("card silinemedi.");
                    }
                    break;
                case 4:
                    
                    break;            
            }

        }
    }
  
  
  
        
}
