using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    public class BankAccount
    {
        public string accHolder;
        public int amount;
        public BankAccount(string accHolder, int amount)
        {
            this.accHolder = accHolder;
            this.amount = amount;
        }
    }
    class Bank
    {
        public void ReadInput()
        {
            BankAccount account;
            LinkedList<BankAccount> bankAccountsList = new LinkedList<BankAccount>();
            CashCounter<string> cashCounter = new CashCounter<string>();
            Console.Write(" Enter the Number Persons : ");
            int numberOfPersons = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*******************************************************");

            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.Write(" Enter account holder name : ");
                string name = Console.ReadLine();
                Console.Write(" Enter amount : ");
                int amount = Convert.ToInt32(Console.ReadLine());
                account = new BankAccount(name, amount);
                bankAccountsList.AddLast(account);
                cashCounter.AddFirst(name);

            }
            
            
            cashCounter.DisplayList();
            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine("\n Persons"+(i+1)+": ");
                cashCounter.SelectChoice(bankAccountsList);
            }
            Console.WriteLine("*******************************************************");
            Console.WriteLine(" Bank Account Details \n");

            foreach (BankAccount i in bankAccountsList)
            {
                Console.WriteLine(" Account Holder Name:{0}   Balance:{1}", i.accHolder, i.amount);
            }
        }
    }
}
