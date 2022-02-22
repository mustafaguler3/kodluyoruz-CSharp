using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelephoneBook
{
    public class TelephoneContact : ITelephone
    {
        public List<User> users {get;set;}
        public TelephoneContact(){
            users = new List<User>();
            users.Add(new User("Mustafa",05342));
            users.Add(new User("Musa",05344));
            users.Add(new User("Hakan",05355));
            users.Add(new User("Ozan",05366));
            users.Add(new User("Kadir",05311));
        }

        public void delete(string name)
        {
            User username = users.Find(i=>i.Name==name);
            users.Remove(username);
        }

        public void list()
        {
            foreach(User u in users){
                Console.WriteLine(u.Name ," ",u.PhoneNumber);
            }
        }

        public void save(string name,long number)
        {
            users.Add(new User(name,number));
        }

        public string search(string name)
        {
            return users.SingleOrDefault(i=>i.Name==name).ToString();
        }

        public User update(string name)
        {
            User user = users.Find(i=>i.Name==name);
            user.Name = name;
            return user;
        }

        public List<User> search(long number)
        {
            return users.Where(i=>i.PhoneNumber==number).ToList();
        }
    }
}