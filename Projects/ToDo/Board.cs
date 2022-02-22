using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo
{
    public class Board
    {
        public List<Card> Cards {get;set;}

        public Board(){
            Cards = new List<Card>();
            Cards.Add(new Card("A","Güzel",Card.Size.M,Card.State.TODO_LINE));
            Cards.Add(new Card("B","Hoş",Card.Size.S,Card.State.TODO_LINE));
            Cards.Add(new Card("C","Harika",Card.Size.XL,Card.State.TODO_LINE));
        }

        public void List(){
            foreach(Card c in Cards){
                Console.WriteLine("Baslik :"+c.title + "\nAtanan Kişi:"+c.atananKisi+"\nİçerik : "+c.content+ "\nBüyüklük: "+c.size);
            }
        }

        public void Add(Card card){
            Cards.Add(card);
        }

        public void Delete(string title){
            Card card =  Cards.SingleOrDefault(i=>i.title==title);
            Cards.Remove(card);
        }

        public Card GetCard(string title){
            return Cards.SingleOrDefault(i=>i.title==title);
        }

    }
}