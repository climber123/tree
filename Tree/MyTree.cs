using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Tree
{
    public class Node
    {
        public int Value;
        public Node Left;
        public Node Right;
    }
    public class MyTree
    {
        //public static int sum;
        private Node root;
        private static Random rnd = new Random();
        static Font MyFont = new Font("Arial", 12);
        static Pen MyPen = new Pen(Color.Black, 2);
        List<int> list = new List<int>();
        
      
        public  void Random(int lvl, double pNN = 0.8)
        {
            root = GenerateSubTree(lvl, pNN);
        }

        private  Node GenerateSubTree(int lvl, double pNN)
        {
            if (lvl == 0 )
                return null;
            if (rnd.NextDouble() > pNN)
                return null;
            Node p = new Node();
            
            p.Value = rnd.Next(1, 10);
            list.Add(p.Value);
            p.Right = GenerateSubTree(lvl - 1, pNN);
            p.Left = GenerateSubTree(lvl - 1, pNN);
            return p;
        }
        /*public bool IsSimpleEl()
        {
            int k = 0;
            for (int i = 0; i < list.Count; i++)      
            {
                k = FindSimple(root, list[i], 0);
                if (k > 1)
                    return true;
            }
            return false;
        }*/

        public bool IsThereSimple1()
        {
            return IsThereSimple(root);
        }
        private bool IsThereSimple(Node node)
        {
            /*
            bool c = false;   
            int k = FindSimple(root, node.Value, 0);
            if (k > 1)
                c =  true;
            else
            if (c == false)
            {
                if (node.Left != null)
                    c = IsThereSimple(node.Left);
                
                if (node.Right != null)
                    c = IsThereSimple(node.Right);
            }

            return c;

            */
            if (FindSimple(root, node.Value) > 1)
                return true;
            return IsThereSimple(node.Left) || IsThereSimple(node.Right);
        }

        public int Counter(int s)
        {
            return FindSimple(root, s);
        }

        private int FindSimple(Node node, int s)
        {
            if (node == null)
                return 0;
            return FindSimple(node.Left, s) + FindSimple(node.Right, s) + (node.Value == s ? 1 : 0);

        }
        private int FindSimple(Node node, int s, int c)
        {
            
            if (node.Value == s)
                c++;
            if (node.Left != null)
            {
                /*if (node.Left.Value == s)
                    c++;
                else*/
                    c = FindSimple(node.Left, s, c);
            }
            if (node.Right != null)
            {
                /*if (node.Right.Value == s)
                    c++;
                else*/
                    c = FindSimple(node.Right, s, c);
            }
            return c;

        }

        public int Sum(int lc)
        {
            if (root != null)
                return FindSum(root, lc);
            else
                return 0;
        }
        private int FindSum(Node p,int lvl)
        {
            if (p == null)
                return 0;
            if (lvl != 1)
            {
                 return FindSum(p.Left, lvl - 1) + FindSum(p.Right, lvl - 1);
            }
            else
            {
                return p.Value;
            }  
        }
 
        public void Draw(Graphics g, int left, int right, int y, int step)
        {
            Draw(root, g, left, right, y, step);
        }
        private  void Draw(Node p, Graphics g, int l, int r, int y, int dy)
        {
            
            if (p == null)
                return;
            int d = 15;
            int x = (l + r) / 2;
            
           
            if (p.Left != null)
                g.DrawLine(MyPen, x+15, y+15, (l + x) / 2 + 15, y+dy+15);
            if (p.Right != null)
                g.DrawLine(MyPen, x+15, y+15, (r + x) / 2 + 15, y+dy+15);

            g.FillEllipse(Brushes.Red, x, y, 2 * d, 2 * d);
            g.DrawEllipse(MyPen, x, y, 2 * d, 2 * d);


            string s = Convert.ToString(p.Value);
            SizeF size = g.MeasureString(s, MyFont);
            g.DrawString(s, MyFont, Brushes.Black, x + size.Width/4, y + size.Width/4);
            Draw(p.Left, g, l, x, y + dy, dy);
            Draw(p.Right, g, x, r, y + dy, dy);

        }
    }
}
