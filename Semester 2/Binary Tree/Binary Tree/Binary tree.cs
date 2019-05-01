using System;
namespace Binary_Tree
{
    class Binary_tree
    {
        public Node Root;
        public int Height;

        public int Count;
        private int CountRucursive(Node val)
        {
            throw new NotImplementedException();
        }

        public void Insert(char val)
        {
            if (Root == null)
            {
                Root = new Node(val);
            }
            else
            {
                Insert(Root, val);
            }
        }

        public void Insert(Node cur, char val)
        {
            if (val >= cur.Value && cur.Rightchild == null)
            {
                cur.Rightchild = new Node(val);
                return;
            }

            if (val < cur.Value && cur.Leftchild == null)
            {
                cur.Leftchild = new Node(val);
                return;
            }

            if (val >= cur.Value)
            {
                Insert(cur.Rightchild, val);
            }

            else if (val < cur.Value)
            {
                Insert(cur.Leftchild, val);
            }
        }

        public void Remove(char val)
        {

            if (Root == null)
            {
                return;
            }
            else
            {
                Root = Remove(Root, val);
            }
        }

        private Node Remove(Node cur, char val)
        {



            if (cur == null) return cur;

            if (val < cur.Value)
                cur.Leftchild = Remove(cur.Leftchild, val);
            else if (val > cur.Value)
                cur.Rightchild = Remove(cur.Rightchild, val);

            else
            {
                if (cur.Leftchild == null)
                    return cur.Rightchild;
                else if (cur.Rightchild == null)
                    return cur.Leftchild;


                cur.Value = MinValue(cur.Rightchild);

                cur.Rightchild = Remove(cur.Rightchild, cur.Value);
            }
            return cur;


        }

        private char MinValue(Node yeet)
        {
            char minv = yeet.Value;
            while (yeet.Leftchild != null)
            {
                minv = yeet.Leftchild.Value;
                yeet = yeet.Leftchild;
            }
            return minv;
        }


        public bool Search(char value)
        {
            if (Root == null)
            {
                return false;
            }
            else
            {
                return Search(Root, value);
            }
        }


        private bool Search(Node cur, char val)
        {


            if (val == cur.Value)
            {
                return true;
            }
            else
            {
                if (val < cur.Value && cur.Leftchild != null)
                {
                    cur.Value = cur.Leftchild.Value;
                    return Search(cur.Leftchild, val);

                }

                else if (val > cur.Value && cur.Rightchild != null)
                {
                    cur.Value = cur.Rightchild.Value;
                    return Search(cur.Rightchild, val);

                }
                else
                { return false; }

            }

        }

        public void PreOrderPrint()
        {
            PreOrderPrint(Root);
        }


        private void PreOrderPrint(Node cur)
        {
            if (cur == null)
            {
                return;
            }

            Console.Write(cur.Value + ".");
            PreOrderPrint(cur.Leftchild);
            PreOrderPrint(cur.Rightchild);
        }

        public void InOrderPrint()
        {
            InOrderPrint(Root);
        }

        private void InOrderPrint(Node yeet)
        {
            if (yeet == null)
            {
                return;
            }
            InOrderPrint(yeet.Leftchild);

            Console.Write(yeet.Value + ".");
            InOrderPrint(yeet.Rightchild);


        }

        public void PostOrderPrint()
        {
            PostOrderPrint(Root);
        }

        public void PostOrderPrint(Node cur)
        {
            if (cur == null)
            {
                return;
            }
            PostOrderPrint(cur.Leftchild);


            PostOrderPrint(cur.Rightchild);
            Console.Write(cur.Value + ".");
        }

        public void Print()
        {
            BinaryTreePrinter.printNode(Root);
        }

        ////Extra Credit
        ///

        public void Balance()
        {

        }

    }


}
