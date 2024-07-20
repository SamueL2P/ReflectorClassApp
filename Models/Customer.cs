using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectorClassApp.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer()
        {
                
        }

        public Customer(int id , string name , string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
        public string PrintDetails(int id , string name , string address)
        {
            return $"ID : {id} \nName : {Name} \nAddress : {Address}";

        }



    }
}
