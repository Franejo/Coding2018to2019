using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Node
    {
        public char Value { get; set; }
        public Node Leftchild { get; set; }
        public Node Rightchild { get; set; }
        public int Height
        {
            get
            {
                int leftTreeheight = 0;
                int rightTreeheight = 0;
                if(Leftchild !=null)
                {
                    leftTreeheight = Leftchild.Height + 1;
                }
                if (leftTreeheight > rightTreeheight)
                {
                    return leftTreeheight;
                }
                else
                    return rightTreeheight;
            }
        }

        public Node(char val)
        {
            Value = val;
        }
    }
}
