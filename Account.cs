using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Account
    {
        private int accountNumber=0;
        private string accountName;
        private double balance;
        private Address address;
        static int count = 1;

        public Account(string accountName, double balance, Address address)
        {
            accountNumber = count++;
            this.accountNumber = accountNumber;

            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }
        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
            
        }

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public void Withdraw(double amount)
        {
            if (balance > amount)
            {
                Console.WriteLine(amount + " TK Withdraw succesfully.");
            }
            else
            {
                Console.WriteLine("You don't have enough blance.");
            }
        }
        public void Deposite(double amount)
        {
            this.balance =  this.balance + amount;
            Console.WriteLine("Your current balance is: " + this.balance);
        }
        public void Transfer(Account recceiver, double amount)
        {
            if (balance > amount)
            {
                Console.WriteLine("Transfer succesfull. ");
            }
            else
            {
                Console.WriteLine("You don't have enough balance for Transfer.");
            }
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine(" Account Name: "+ this.accountName, " Balance: " + this.balance);
            Console.WriteLine(this.address.GetAddress());
        }
    }
}
