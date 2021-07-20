using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class BalancedParantheses
    {
        public void ReadInput()
        {
            
            StackAndStackMethods<char> stack = new StackAndStackMethods<char>();
            int checkBalanced = 0;
            string equation = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
            Console.WriteLine("\n Equation : "+equation);

            for (int i = 0; i < equation.Length; i++)
            {
                if (equation[i].Equals('('))
                {
                    stack.Push(equation[i]);
                }
                else if (equation[i].Equals(')'))
                {
                    checkBalanced = stack.pop();
                    if (checkBalanced == 1)
                    {
                        break;
                    }
                }
            }
            if (stack.CheckTop() == 1)
            {
                Console.WriteLine(" Equation is balanced");
            }
            else if (stack.CheckTop() == 0 && checkBalanced == 0)
            {
                Console.WriteLine(" Equation is unbalanced");
            }
        }
    }
    
}
