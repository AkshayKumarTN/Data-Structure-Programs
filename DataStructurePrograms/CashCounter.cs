using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    public class QueueNode<T>
    {
        public T value;
        public QueueNode<T> Next;
        public QueueNode(T value)
        {
            this.value = value;
            this.Next = null;
        }
    }
    class CashCounter<T>
    {
        public QueueNode<T> front;
        public QueueNode<T> rear;
        int amount = 1000;

        // Adding First......
        public void AddFirst(T value)
        {
            // Creating the new node with given Value..........
            QueueNode<T> newNode = new QueueNode<T>(value);

            if (front == null)
            {
                front = newNode;
            }
            else
            {
                rear = front;
                while (rear.Next != null)
                {
                    rear = rear.Next;
                }
                rear.Next = newNode;
            }
        }

        // Delete At First......
        public string DeleteFirst()
        {
            rear = front;
            if (rear == null)
            {
                Console.WriteLine("No element in the list");
            }
            else
            {
                front = front.Next;
            }
            return rear.value.ToString();
        }
       
        public void SelectChoice(LinkedList<BankAccount> banks)
        {
          
                string name = DeleteFirst();
                BankAccount account = null;
                foreach (BankAccount i in banks)
                {
                    if (i.accHolder.Equals(name))
                    {
                        account = i;
                    }
                }
                Console.WriteLine(" 1.Deposit\n 2.Withdraw");
                Console.Write("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write(" Enter amount to deposit : ");
                        int amt = Convert.ToInt32(Console.ReadLine());
                        UpdateChange(account, amt, banks, name, choice);
                        break;
                    case 2:
                        Console.Write(" Enter amount to withdraw : ");
                        int amt1 = Convert.ToInt32(Console.ReadLine());
                        if (account.amount > amt1 && account != null)
                        {
                            UpdateChange(account, amt1, banks, name, choice);

                        }
                        else
                        {
                            Console.WriteLine(" No Balance Available");
                        }
                        break;
                    
                }
            
        }
        public void UpdateChange(BankAccount bank, int amount, LinkedList<BankAccount> bankAccounts, string name, int choice)
        {
            if (bank == null)
            {
                BankAccount bank1 = new BankAccount(name, amount);
                bankAccounts.AddLast(bank1);
            }
            else if (choice == 1)
            {
                bank.amount = bank.amount + amount;
            }
            else
            {
                bank.amount = bank.amount - amount;
            }
        }
        public void DisplayList()
        {
            Console.WriteLine(" Queue \n");

            rear = front;
            // Checks if head is null............
            if (front == null)
            {
                Console.WriteLine("No element in the list");
            }
            // Else Print the Elements........ 
            else
            {
                int i = 0;
                Console.WriteLine("*******************************************************");
                while (rear != null)
                {
                    Console.WriteLine(" Persons" + (i + 1) + ": " + rear.value);
                    rear = rear.Next;
                    i++;
                }
                Console.WriteLine("*******************************************************");

            }
        }
    }
}
