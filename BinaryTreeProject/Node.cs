using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeProject
{
    class Node
    {
        public Node rChild;
        public char info;
        public Node lChild;

        public Node(char ch)
        {
            rChild = null;
            info = ch;
            lChild = null;
        }
    }
}
