using System;
namespace Binary_Tree
{
    class Binary_tree
    {
        public Node Root;
        public int Height;

        public int Count;
        private int CountRecursive(Node val)
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
        private void Insert(Node yeet, char val)
        {
            if (val >= yeet.Value && yeet.Rightchild == null)
            {
                yeet.Rightchild = new Node(val);
                return;
            }
            else if (val < yeet.Value && yeet.Leftchild == null)
            {
                yeet.Leftchild = new Node(val);
                return;
            }
            if (val >= yeet.Value)
            {
                Insert(yeet.Rightchild, val);
            }
            else if (val < yeet.Value)
            {
                Insert(yeet.Leftchild, val);
            }
        }
        public bool Remove(char val)
        {
            throw new NotImplementedException();
        }
        private bool Remove(Node val, char value)
        {
            throw new NotImplementedException();
        }
        public bool Search(char val)
        {
            if (Root == null)
            {
                return false;
            }
            else
            {
                return Search(Root, val);
            }
        }
        private bool Search(Node cur, char value)
        {
            if (value == cur.Value)
            {
                return true;
            }
            else
            {


                if (value < cur.Value && cur.Leftchild != null)
                {
                    cur.Value = cur.Leftchild.Value;
                    return Search(cur.Leftchild, value);

                }
                else if (value > cur.Value && cur.Rightchild != null)
                {
                    cur.Value = cur.Rightchild.Value;
                    return Search(cur.Rightchild, value);
                }

                else
                {
                    return false;
                }
            }
        }
        public void Balance()
        {

        }
        public void preOrderPrint()
        {

        }
        private void PreOrderPrint(Node val)
        {

        }
        public void InOrderPrint()
        {

        }
        private void InOrderPrint(Node val)
        {

        }
        public void PostOrderPrint()
        {

        }
        private void PostOrderPrint(Node val)
        {

        }
        public void print()
        {
            BinaryTreePrinter.printNode(Root);
        }

    }


}
