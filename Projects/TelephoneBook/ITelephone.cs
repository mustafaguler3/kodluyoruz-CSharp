using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelephoneBook
{
    public interface ITelephone
    {
        void save(string name,long number);
        void delete(string name);
        User update(string name);
        void list();
        string search(string name);
        List<User> search(long number);
    }
}