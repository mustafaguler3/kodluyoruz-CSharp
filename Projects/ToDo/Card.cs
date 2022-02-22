using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo
{
    public class Card
    {
        public string title {get;set;}
        public string content {get;set;}
        public Member atananKisi {get;set;}
        public Size size {get;set;}

        public Card(string title,string content,Size size,State state){
            this.title = title;
            this.content = content;
            this.size = size;
        }

        public Card(string? title, string? content, Size size)
        {
            this.title = title;
            this.content = content;
            this.size = size;
        }

        public enum Size
        {
            XS = 1,
            S,

            M,
            L,
            XL
        }

        public enum State
        {
            TODO_LINE,
            IN_PROGRESS_LINE,
            DONE_LIST
        }
    }
}