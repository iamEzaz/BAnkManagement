using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;
        
        

        public Bank(string bankName,int size)
        {
            this.bankName = bankName;
            myBank  = new Account[size];
        }

        public string BankName
        {
            set { this.BankName = value; }
            get { return this.BankName; }
        }
        public Account[] MyBank
        {
            set { this.myBank = value; }
            get { return this.myBank; }
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }
        public void DeleteAccount(int accountNo)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].AccountNumber == accountNo)
                {
                    myBank[i] = null;
                    Console.WriteLine("Account no: " + accountNo + " deleted");
                    break;
                }
            }
        }
        public void Transaction(int transactionType,double amount,int accountNo)
        {
            if (transactionType == 1)
            {
                Console.WriteLine(amount + " TK Deposited in A/C: " + accountNo);
            }
            else if (transactionType == 2)
            {
                Console.WriteLine(amount + " TK Withdraw from: A/C: " + accountNo);
            }
            else if (transactionType == 3)
            {
                Console.WriteLine(amount + " TK Transferfrom from: A/C: " + accountNo);
            }
        }
        public void PrintAccountDetail()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].ShowAccountInformation();
            }
        }

    }
}
