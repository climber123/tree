using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tree;
using System.IO;

namespace Sum
{
    public partial class Sum : Form
    {
        MyTree tree;
        MyChartTree ch_tree;
        Interpretator intr;
        //MyQueue queue = new MyQueue();
        Graphics g;
        

        public Sum()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void CreateTree_Click(object sender, EventArgs e)
        {
            g.Clear(Color.AliceBlue);
            tree = new MyTree();
            tree.Random(Convert.ToInt32(textBox1.Text));
            tree.Draw(g, 0, pictureBox1.Right, 10, 40);     
        }

        private void summ_Click(object sender, EventArgs e)
        {
            textBox3.Text = tree.Sum(Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ch_tree = new MyChartTree();
            g = pictureBox1.CreateGraphics();
            g.Clear(Color.AliceBlue);
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            StreamReader str = new StreamReader(ofd.FileName);
            

            while (!str.EndOfStream)
            {
                string k = str.ReadLine();
                
                ch_tree.Create(k);

            }
            str.Close();
            

            ch_tree.DrawTree(g, 0, pictureBox1.Width, 10, 40);
        }

        private void find_button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            SaveFileDialog sfd = new SaveFileDialog();

            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            if (sfd.ShowDialog() != DialogResult.OK)
                return;


            StreamReader str = new StreamReader(ofd.FileName);
            StreamWriter stw = new StreamWriter(sfd.FileName);

            while (!str.EndOfStream)
            {
                string k = str.ReadLine();
                

                if (!ch_tree.Find(k))
                    stw.WriteLine(k);
            }
            str.Close();
            stw.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ch_tree = null;
            g.Clear(Color.AliceBlue);
        }

        private void IsSimpleElements_Click(object sender, EventArgs e)
        {
            bool a = tree.IsThereSimple1();
            if (a)
                label.Text = "В дереве присутствуют одинаковые элементы";
            else 
                label.Text = "В дереве отсутствуют одинаковые элементы";

        }

        private void Sum_Load(object sender, EventArgs e)
        {

        }

        private void Interp_Click(object sender, EventArgs e)
        {
            try
            {
                g.Clear(Color.AliceBlue);
                intr = new Interpretator();
                int k = intr.Parse(textBox4.Text);
                intr.Draw(g, 0, pictureBox1.Width, 10, 60);
                if (k == 1)
                    label4.Text = "T";
                else
                    label4.Text = "F";
            }
            catch (Exception)
            {
                label4.Text = "Error";
            }
        }
    }
}
