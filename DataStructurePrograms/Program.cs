using System;

namespace DataStructurePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Data Structure Programs");
            bool alive = true;
            while (alive)
            {
                Console.WriteLine("\n 1.UnOrdered List");
                Console.WriteLine(" 2.Ordered List");
                Console.WriteLine(" 3.Balanced Parantheses");
                Console.WriteLine(" 4.Banking Cash Counter");
                Console.WriteLine(" 5.Palindrome");
                Console.WriteLine(" 0.Exit");

                Console.Write("\n Enter the the Option : ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        UnOrderedList unOrderedList = new UnOrderedList();
                        unOrderedList.ReadInput();
                        break;
                    case 2:
                        OrderedList OrderedList = new OrderedList();
                        OrderedList.ReadInput();
                        break;
                    case 3:
                        BalancedParantheses balancedParantheses = new BalancedParantheses();
                        balancedParantheses.ReadInput();
                        break;
                    case 4:
                        Bank bank = new Bank();
                        bank.ReadInput();
                        break;
                    case 5:
                        Palindrome palindrome = new Palindrome();
                        palindrome.ReadInput();
                        break;
                    case 0:
                        alive = false;
                        break;
                    default:
                        Console.WriteLine("\n Invail Option");
                        break;

                }
            }
        }
    }
}
