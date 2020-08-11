using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeProject
{
    class BinaryTreee
    {
        private Node root;
        public BinaryTreee()
        {
            root = null;
        }
        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();
        }
        public void Display(Node p,int level)
        {
            int i;
            if (p == null)
                return;
            Display(p.rChild, level + 1);
            Console.WriteLine();

            for (i = 0; i < level; i++)
                Console.Write("    ");
            Console.Write(p.info);


            Display(p.lChild, level + 1);
            
        }
        public void CreateTree()
        {
            root = new Node('p');
            root.lChild = new Node('q');
            root.rChild = new Node('r');
            root.lChild.lChild = new Node('s');
            root.lChild.rChild = new Node('t');
            root.rChild.lChild = new Node('u');
            root.rChild.rChild = new Node('v'); 
        }

        public void Preorder()
        {
            Preorder(root);
            Console.WriteLine();
        }
        public void Preorder(Node p)
        {
            if (p == null)
                return;
            Console.Write(p.info + "  ");
            Preorder(p.lChild);
            Preorder(p.rChild);
        }
        public void Inorder()
        {
            Inorder(root);
            Console.WriteLine();
        }
        public void Inorder(Node p)
        {
            if (p == null)
                return;
            Inorder(p.lChild);
            Console.Write(p.info + "  ");
            Inorder(p.rChild);
        }
        public void Postorder()
        {
            Postorder(root);
            Console.WriteLine();
        }
        public void Postorder(Node p)
        {
            if (p == null)
                return;
            Postorder(p.lChild);
            Postorder(p.lChild);
            Console.Write(p.info + "  ");
        }

        public void LevelOrder()
        {
            if(root == null)
            {
                Console.WriteLine("queue is empty ");
                return;
            }
            Queue<Node> qu = new Queue<Node>();
            qu.Enqueue(root);

            Node p;
            while (qu.Count != 0)
            {
                p = qu.Dequeue();
                Console.Write(p.info + " ");
                if (p.lChild != null)
                    qu.Enqueue(p.lChild);
                if (p.rChild != null)
                    qu.Enqueue(p.rChild);
            }
            Console.WriteLine();
        }
        public int Hight()
        {
            return Hight(root);
        }
        public int Hight(Node P)
        {
            if (P == null)
                return 0;
            int hl = Hight(P.lChild);
            int hr = Hight(P.rChild);

            if (hl > hr)
                return 1 + hl;
            else
                return 1 + hr;
        }
    }
}
