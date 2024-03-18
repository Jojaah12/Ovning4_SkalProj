using System;
using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        /// 
        static Stack<string> theStack = new Stack<string>();
        static Queue<string> theQueue = new Queue<string>();
        static List<string> theList = new List<string>();
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        /// 

        //1. The list's capacity increases when the number of elements exceeds the current capacity of the underlying array.
        //2. The capacity of the list doubles each time it needs to increase.
        //3. The capacity doesn't increase at the same rate as elements are added because increasing the capacity every time
        //an element is added would be inefficient in terms of memory management and performance.
        //4. No, the capacity doesn't decrease when elements are removed from the list. It remains the same unless you
        //explicitly call the TrimExcess() method to reduce the capacity.
        //5.Custom arrays are advantageous when you require precise memory control or know the exact collection size
        //upfront, avoiding dynamic resizing overhead and additional list functionalities.
        static void ExamineList()
        {
            while (true)
            {
                Console.WriteLine("Enter '+' to add an item or '-' to remove an item from the list (or '0' to return to the main menu):");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter valid input.");
                    continue;
                }

                char nav = input[0];
                string value = input.Substring(1).Trim(); // Trim whitespace from the value

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine($"Added '{value}' to the list.");
                        break;
                    case '-':
                        if (theList.Remove(value))
                            Console.WriteLine($"Removed '{value}' from the list.");
                        else
                            Console.WriteLine($"'{value}' not found in the list.");
                        break;
                    case '0':
                        return; // Return to the main menu
                    default:
                        Console.WriteLine("Please use only '+' or '-' to add or remove items.");
                        break;
                }

                Console.WriteLine($"List count: {theList.Count}, Capacity: {theList.Capacity}");
            }
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            while (true)
            {
                Console.WriteLine("Enter '+' to enqueue an item, '-' to dequeue an item, or '0' to return to the main menu:");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter valid input.");
                    continue;
                }

                char nav = input[0];
                string value = input.Substring(1).Trim(); // Trim whitespace from the value

                switch (nav)
                {
                    case '+':
                        theQueue.Enqueue(value);
                        Console.WriteLine($"Enqueued '{value}' to the queue.");
                        break;
                    case '-':
                        if (theQueue.Count > 0)
                            Console.WriteLine($"Dequeued '{theQueue.Dequeue()}' from the queue.");
                        else
                            Console.WriteLine("Queue is empty, cannot dequeue.");
                        break;
                    case '0':
                        return; // Return to the main menu
                    default:
                        Console.WriteLine("Please use only '+' or '-' to enqueue or dequeue items.");
                        break;
                }

                Console.WriteLine($"Queue count: {theQueue.Count}");
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            while (true)
            {
                Console.WriteLine("Enter '+' to push an item, '-' to pop an item, or '0' to return to the main menu:");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter valid input.");
                    continue;
                }

                char nav = input[0];
                string value = input.Substring(1).Trim(); // Trim whitespace from the value

                switch (nav)
                {
                    case '+':
                        theStack.Push(value);
                        Console.WriteLine($"Pushed '{value}' onto the stack.");
                        break;
                    case '-':
                        if (theStack.Count > 0)
                            Console.WriteLine($"Popped '{theStack.Pop()}' from the stack.");
                        else
                            Console.WriteLine("Stack is empty, cannot pop.");
                        break;
                    case '0':
                        return; // Return to the main menu
                    default:
                        Console.WriteLine("Please use only '+' or '-' to push or pop items.");
                        break;
                }

                Console.WriteLine($"Stack count: {theStack.Count}");
            }
        }

        //1. Using a stack isn't smart for simulating a ICA queue because it serves
        //the last person who joins first, contrary to the expected First In, First Out (FIFO) order

        static void ReverseText()
        {
            Console.WriteLine("\nEnter a string to reverse:");

            string input = Console.ReadLine();

            Stack<char> charStack = new Stack<char>();

            // Push each char onto the stack
            foreach (char c in input)
            {
                charStack.Push(c);
            }

            // Pop each char from the stack to reverse the order
            Console.WriteLine("\nReversed string:");

            while (charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            Console.WriteLine("Enter a string containing parentheses to check:");

            string input = Console.ReadLine();

            if (IsValidParentheses(input))
            {
                Console.WriteLine("Parentheses are correctly matched.");
            }
            else
            {
                Console.WriteLine("Parentheses are not correctly matched.");
            }

        }
        static bool IsValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') || (c == ']' && top != '[') || (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

    }
}

 