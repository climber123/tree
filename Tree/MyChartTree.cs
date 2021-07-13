using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tree
{
    public class MyNode
    {
        public string Value;
        public MyNode Left;
        public MyNode Right;
        public int count;

        
        public MyNode(string value, MyNode left, MyNode right)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
            this.count = 1;
        }
        
    }
    public class MyChartTree
    {
        private MyNode root;
        static Font MyFont = new Font("Arial", 12);
        static Pen MyPen = new Pen(Color.Black, 2);
        Random rnd = new Random();

        public void Create(/*ref MyNode node*/ string queue)
        {
            CreateTree(ref root ,queue);
        }
        
        private void CreateTree(ref MyNode node ,string queue)
        {
            if (node == null)
                node = new MyNode(queue, null, null);
            else
                if (queue.CompareTo(node.Value) < 0)
                CreateTree(ref node.Left, queue);
            else
                if (queue.CompareTo(node.Value) > 0)
                CreateTree(ref node.Right, queue);
            else
                node.count++;
        }   
        public bool Find(string s)
        {

            return FindWord(root, s);
        }
        private bool FindWord(MyNode node, string s)
        {
     
            bool z = false;
            if (node.Value == s)
            {
                
                z =  true;
            }
            else
            {
                
                if (node.Left != null)
                    z =FindWord(node.Left, s);
                if ((z == false) & (node.Right != null))
                    z = FindWord(node.Right, s);
            }
            
            return z;
            
        }



        public void DrawTree(Graphics g, int left, int right, int y, int step)
        {

            Draw(root, g, left, right, y, step);
        }
        private void Draw(MyNode p, Graphics g, int l, int r, int y, int dy)
        {

            if (p == null)
                return;
            int d = 15;
            int x = (l + r) / 2;


            if (p.Left != null)
                g.DrawLine(MyPen, x + 15, y + 15, (l + x) / 2 + 15, y + dy + 15);
            if (p.Right != null)
                g.DrawLine(MyPen, x + 15, y + 15, (r + x) / 2 + 15, y + dy + 15);

            g.FillEllipse(Brushes.Red, x, y, 2 * d, 2 * d);
            g.DrawEllipse(MyPen, x, y, 2 * d, 2 * d);


            string s = p.Value;
            SizeF size = g.MeasureString(s, MyFont);
            g.DrawString(s, MyFont, Brushes.Black, x + size.Width / 4, y + size.Width / 4);
            Draw(p.Left, g, l, x, y + dy, dy);
            Draw(p.Right, g, x, r, y + dy, dy);

        }

    }
}
