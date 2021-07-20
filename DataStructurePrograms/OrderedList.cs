using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructurePrograms
{
    class OrderedList
    {
        public LinkedList<string> numberList;
        string filePath = @"C:\Users\Admin\source\repos\DataStructurePrograms\DataStructurePrograms\NumberFile.txt";
        
        public OrderedList()
        {
            string numbers= File.ReadAllText(filePath);
            string[] number = numbers.Split(',');
            numberList = new LinkedList<string>(number);
        }

        public void ReadInput()
        {
            Console.Write(" List of Words : ");
            Display(numberList);
            Console.Write("Enter the word to be searched : ");
            string number = Console.ReadLine();
            if (numberList.Find(number) != null)
            {
                numberList.Remove(number);
            }
            else
                AddNumber(number, numberList);
            
            Console.WriteLine(" List of Numbers : ");
            Display(numberList);
            string newText = String.Join(',', numberList);
            File.WriteAllText(filePath, newText);

        }
        public static LinkedList<string> AddNumber(string number, LinkedList<string> numberList)
        {
            
            foreach (string item in numberList)
            {
                if (int.Parse(item) > int.Parse(number))
                {
                    numberList.AddBefore(numberList.Find(item),number);
                    break;
                }
            }
            return numberList;
            
        }
        private static void Display(LinkedList<string> numberList)
        {
            foreach (string number in numberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

    }
}
