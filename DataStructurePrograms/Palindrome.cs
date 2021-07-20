using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class Palindrome
    {
        public void ReadInput()
        {
            Dequeue<char> dequeue = new Dequeue<char>();
            bool palindrom = true;
            Console.Write(" Enter the word : ");
            string word = Console.ReadLine();
            string newword = word.ToLower();
            for (int i = 0; i < newword.Length; i++)
            {
                dequeue.AddFront(newword[i]);
            }
            while (dequeue.CheckEqual() == 1)
            {
                if (!(dequeue.RemoveFront().Equals(dequeue.RemoveRear())))
                {
                    palindrom = false;
                    break;
                }
            }
            if (palindrom)
                Console.WriteLine(" Word \""+word+"\" is a palindrome");
            else
                Console.WriteLine(" Word \"" + word + "\" is not a palindrome");
            
        }
    }
}
