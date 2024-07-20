using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectorClassApp.Models
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string Name { get; set; }

        public void Deposit(double amount)
        {
            //logic 
        }

        public void Withdraw(double amount) { 
            //logic
        
        }

        public Account(int accountNumber, string name)
        {
            AccountNumber = accountNumber;
            Name = name;
        }

        

    }
}
