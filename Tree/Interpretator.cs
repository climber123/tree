using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tree
{
    public class NodeForInt
    {
        public int val;
        public string op; // operation

        public NodeForInt(int v)
        {
            val = v;
            op = "";
        }
        public NodeForInt(string c)
        {
            val = ' ';
            op = c.ToUpper();
        }
        public NodeForInt Left = null;
        public NodeForInt Right = null;
        public int Compute()
        {
            if (op == "")
                return val;
            int a = Left.Compute();
            int b = Right.Compute();
            int Result = 0;
            switch(op)
            {
                case "OR":
                    if (a == 1 || b == 1)
                        Result = 1;
                    else Result = 0;
                    break;
                case "AND":
                    Result = a * b;
                    break;

            }
            return Result;
        }

    }
    public class Interpretator
    {
        NodeForInt root = null;
        static Font MyFont = new Font("Arial", 12);
        static Pen MyPen = new Pen(Color.Black, 2);

        public int Parse(string text)
        {
            int pos = 0;
            root = Parse(text, ref pos);
            return root.Compute();
        }



        private NodeForInt Parse(string text,ref int pos)
        {
            NodeForInt Z = null;
            while (pos < text.Length && text[pos] == ' ')
                pos++;
            if (pos == text.Length)
                throw new Exception("Error: no operation");

            Z = Arg(text,ref pos);


            if (Z == null)
                Z = ParseExpression(text,ref pos);

            return Z;
        }
        private NodeForInt ParseExpression(string text,ref int pos)
        {
            string s = null;
            NodeForInt Z = null;
            if (text[pos] == 'A' || text[pos] == 'a')
            {
                for (int i = 0; i < 3; i++)
                {
                    s = s + text[pos];
                    pos++;
                }

                
                if (s.ToUpper() != "AND")
                    throw new Exception("");
                Z = new NodeForInt(s);
                
            }
            else
            if (text[pos] == 'O' || text[pos] == 'o')
            {
                for (int i = 0; i < 2; i++)
                {
                    s = s + text[pos];
                    pos++;

                }
                
                if (s.ToUpper() != "OR")
                    throw new Exception("");
                Z = new NodeForInt(s);
            }

            if (Z == null)
                throw new Exception("");

            while (pos < text.Length && text[pos] == ' ')
                pos++;
            if (pos == text.Length)
                throw new Exception("Error: no operation");

            string k = text.Substring(pos,1);
            if (k != "(")
                throw new Exception();
            pos++;

            NodeForInt A = Term(text, ref pos);
            
            while (pos < text.Length && text[pos] == ' ')
                pos++;
            if (pos == text.Length)
                throw new Exception("Error: no operation");

            k = text.Substring(pos, 1);
            if (k != ",")
                throw new Exception();
            pos++;

            NodeForInt B = Term(text, ref pos);


            while (pos < text.Length && text[pos] == ' ')
                pos++;
            if (pos == text.Length)
                throw new Exception("Error: no operation");
            k = text.Substring(pos, 1);
            if (k != ")")
                throw new Exception("");
            pos++;

            Z.Left = A;
            Z.Right = B;

            return Z;
        }

        private NodeForInt Arg(string text,ref int pos)
        {
            NodeForInt z = null;
            string s = text[pos].ToString().ToUpper();
            if (s == "T")
            {
                z = new NodeForInt(1);
                pos++;
            }
            else if (s == "F")
            {
                z = new NodeForInt(0);
                pos++;
            }

            while (pos < text.Length && text[pos] == ' ')
                pos++;
            if (pos == text.Length)
                return z;

            return null; 
            
        }
        private NodeForInt Term(string text,ref int pos) // элемент + другой терм/элемент
        {
            
            while (pos < text.Length && text[pos] == ' ')
                pos++;
            if (pos == text.Length)
                throw new Exception("Error: no operation");
            NodeForInt node = Element(text,ref pos);

            if (node == null)
                node = ParseExpression(text, ref pos);

            return node;

        }

        private NodeForInt Element(string text,ref int pos) // число + (выражение)/число 
        {
            NodeForInt Z = null;

            if (text[pos] == 'T' || text[pos] == 't')
            {
                //Z = new NodeForInt(Convert.ToChar(text[pos]));
                Z = new NodeForInt(1);
                pos++;
            }
            if (text[pos] == 'F' || text[pos] == 'f')
            {
                //Z = new NodeForInt(Convert.ToChar(text[pos]));
                Z = new NodeForInt(0);
                pos++;
            }
            
            return Z;
            
        }

        public void Draw(Graphics g, int left, int right, int y, int step)
        {
            Draw(root, g, left, right, y, step);
        }
        private void Draw(NodeForInt p, Graphics g, int l, int r, int y, int dy)
        {
            string s;
            if (p == null)
                return;
            int d = 15;
            int x = (l + r) / 2;


            if (p.Left != null)
                g.DrawLine(MyPen, x + 25, y + 25, (l + x) / 2 + 25, y + dy + 25);
            if (p.Right != null)
                g.DrawLine(MyPen, x + 25, y + 25, (r + x) / 2 + 25, y + dy + 25);

            g.FillEllipse(Brushes.Red, x, y, 3 * d, 3 * d);
            g.DrawEllipse(MyPen, x, y, 3 * d, 3 * d);

            if (p.val != ' ')
            {
                if (p.val == 1)
                    s = "T";
                else
                    s = "F";
                //s = Convert.ToString(p.val);
            }
            else
                s = p.op;
            SizeF size = g.MeasureString(s, MyFont);
            g.DrawString(s, MyFont, Brushes.Black, x + size.Width / 4, y + size.Width / 2);
            Draw(p.Left, g, l, x, y + dy, dy);
            Draw(p.Right, g, x, r, y + dy, dy);

        }
    }
}
