using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructurePrograms
{
    class UnOrderedList
    {
        LinkedList<string> wordList;
        string filePath = @"C:\Users\Admin\source\repos\DataStructurePrograms\DataStructurePrograms\TextFile.txt";
        public UnOrderedList()
        {
            
            string fileOfWords = File.ReadAllText(filePath);
            string[] words = fileOfWords.Split(' ');
            wordList = new LinkedList<string>(words);
        }
        public void ReadInput()
        {
            Console.Write(" List of Words : ");
            Display(wordList);
            Console.Write("Enter the word to be searched : ");
            string word = Console.ReadLine();
            if (wordList.Find(word) != null)
            {
                wordList.Remove(word);
            }
            else
                wordList.AddLast(word);
            Console.Write(" List of Words : ");
            Display(wordList);
            string newText = String.Join(' ', wordList);
            File.WriteAllText(filePath, newText);

        }
        private static void Display(LinkedList<string> wordList)
        {
            foreach (string word in wordList)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }



    }
}
