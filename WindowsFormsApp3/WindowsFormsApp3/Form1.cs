using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Boolean flage = false;
        Color[] x= { Color.White, Color.Black };
        int i = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          DialogResult r =  MessageBox.Show("Are you sure you wan to close the form");
            switch (r)
            {
                case DialogResult yes: this.Close(); break;
            }
            //custom controlle

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\lab502\\Desktop\\download.jpg");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "I love USA"+"("+e.X+","+e.Y+")";
            label1.ForeColor = Color.Red;
            label2.Text = e.Button.ToString();

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label1.Text = "I love USA more than mysilfe" + "(" + e.X + "," + e.Y + ")";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            label3.Text =  "(" + e.X + "," + e.Y + ")";
            Graphics a = this.CreateGraphics();
            if(flage==true)
            a.FillEllipse(new SolidBrush(x[i%2]), e.X, e.Y, 50, 50);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            flage = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

            flage = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;

        }
    }
}
