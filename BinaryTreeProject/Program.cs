using System;

namespace BinaryTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreee bt = new BinaryTreee();
            bt.CreateTree();
            bt.Display();

            Console.WriteLine("preorder :");
            bt.Preorder();
            Console.WriteLine("");

            Console.WriteLine("inorder :");
            bt.Inorder();
            Console.WriteLine("");

            Console.WriteLine("postorder :");
            bt.Postorder();
            Console.WriteLine("");

            Console.WriteLine("level order :");
            bt.LevelOrder();
            Console.WriteLine("");

            Console.WriteLine("Hight of the tree is " + bt.Hight());
        }
    }
}
