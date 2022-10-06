using System;

namespace cs_work
{
    class Program
    {
        public static int[] L = new int[] { 1, 2, -1, 5, -1, -1, -1 };
        public static int[] R = new int[] { 3, 4, -1, 6, -1, -1, -1 };
        public static string[] Node = new string[] { "Mavis", "Gertrude", "Cactus", "Regina", "Hubert", "Norville", "Thor" };

        private static void postTraversal(int Current)
        {
            if (L[Current] != -1)
            {
                postTraversal(L[Current]);
            }
            if (R[Current] != -1)
            {
                postTraversal(R[Current]);
            }
            Console.WriteLine(Node[Current]);
        }
        private static void preTraversal(int Current)
        {
            Console.WriteLine(Node[Current]);
            if (L[Current] != -1)
            {
                preTraversal(L[Current]);
            }
            if (R[Current] != -1)
            {
                preTraversal(R[Current]);
            }
        }
        private static void inTraversal(int Current)
        {
            if (L[Current] != -1)
            {
                inTraversal(L[Current]);
            }
            Console.WriteLine(Node[Current]);
            if (R[Current] != -1)
            {
                inTraversal(R[Current]);
            }
        }
        static void Main(string[] args)
        {
            // while true to allow for multiple traversals
            while (true)
            {
                Console.WriteLine("Enter a traversal type: ");
                string traversal = Console.ReadLine();
                Console.Clear();
                if (traversal.ToLower() == "post" || traversal == "3")
                {
                    Console.Clear();
                    Console.WriteLine("POST TRAVERSAL");
                    postTraversal(0);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (traversal.ToLower() == "pre" || traversal == "1")
                {
                    Console.Clear();
                    Console.WriteLine("PRE TRAVERSAL");
                    preTraversal(0);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (traversal.ToLower() == "in" || traversal == "2")
                {
                    Console.Clear();
                    Console.WriteLine("IN-ORDER TRAVERSAL");
                    inTraversal(0);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (traversal == "0")
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid traversal type");
                    Console.ResetColor();
                }
            }
        }
    }
}


// What is meant by a recursive routine?
/*
The recursive routine is a function that calls itself.
The function calls itself until it reaches a stopping condition.
The stopping condition is a condition that stops the function from calling itself again
*/



// What is meant by a recursive definition?
/*
It defines itself in terms of itself.
*/



// What are the key components of a recursive routine?
/*
The method is a recursive method because it calls itself.
The method must have a base case that does not call the method again.
The method must call itself with a different argument.
*/



// State a disadvantage of using recursion instead of iteration.
/*
It is slower than iteration.
*/



// State an advantage of using recursion instead of iteration.
/*
It is more efficient to use recursion than iteration.
It is easier to understand the code.
It is more flexible.
It is more concise.
It is more elegant.
*/