using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelephoneBook
{
    public class User
    {
        public string Name {get;set;}
        public long PhoneNumber {get;set;}

        public User(string name,long PhoneNumber){
            this.Name = name;
            this.PhoneNumber = PhoneNumber;
        }

        

    }
}