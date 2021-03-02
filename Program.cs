using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("23/i", "44", "Dhaka", "Bangladesh");
            Account account1 = new Account("Billah", 11000, address1);
            Account account2 = new Account("Fakruddin", 5000, new Address("7/p", "57", "Khulna", "Bangladesh"));
            account2.ShowAccountInformation();
            account1.ShowAccountInformation();
            
            
            account1.Withdraw(500);
            account1.Deposite(1000);
            account1.Transfer(account2, 500);

            
            account2.ShowAccountInformation();




            Bank ourBank = new Bank("Bangladesh Krishi bank", 5);
            ourBank.AddAccount(new Account("Shahrukh", 4000, new Address("45/t", "41", "Chattagram","Bangladesh")));
            ourBank.AddAccount(new Account("Salman", 7000, new Address("46/t", "43", "Khulna", "Bangladesh")));
            ourBank.AddAccount(new Account("AAmir", 9000, new Address("4/t", "42", "Sylhet", "Bangladesh")));
            ourBank.PrintAccountDetail();
            ourBank.DeleteAccount(3);
            ourBank.Transaction(2, 5000, 3);
            ourBank.PrintAccountDetail();
        }
    }
}
