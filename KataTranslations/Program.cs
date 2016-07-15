using System;
using Kata.Algorithms;

namespace Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                tree.Insert(rnd.Next(100));
            }
            Console.WriteLine("Inorder Traversal : ");
            tree.Inorder(tree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal : ");
            tree.Preorder(tree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal : ");
            tree.Postorder(tree.ReturnRoot());
            Console.WriteLine(" ");
            Console.ReadLine();

        }
    }
}
