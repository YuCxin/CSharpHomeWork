using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public int Th1 { get; set; }//分支角度
        public int Th2 { get; set; }//分支角度
        public double Per1 { get; set; }//分支长度比1
        public double Per2 { get; set; }//分支长度比2
        public double Length { get; set; } //主干高度
        public int N { get; set; }//深度
        public Pen DrawPen { get; set; }//画笔

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Th1 = 30; Th2 = 20; Per1 = 0.6; Per2 = 0.7; Length = 100; N = 10;
            DrawPen = Pens.Red;
            Pen[] pens = { Pens.Red, Pens.Green, Pens.Yellow };
            cbxColor.DataSource = pens;
            cbxColor.DisplayMember = "Color";
            cbxColor.DataBindings.Add("SelectedItem", this, "DrawPen");

            txtTh1.DataBindings.Add("Text", this, "Th1");
            txtTh2.DataBindings.Add("Text", this, "Th2");
            txtPer1.DataBindings.Add("Text", this, "Per1");
            txtPer2.DataBindings.Add("Text", this, "Per2");
            txtLength.DataBindings.Add("Text", this, "Length");
            txtN.DataBindings.Add("Text", this, "N");
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            graphics = this.panel2.CreateGraphics();
            graphics.Clear(panel2.BackColor);
            drawCayleyTree(this.N, panel2.Width / 2, panel2.Height - 80, this.Length, -Math.PI / 2);
        }

        void drawCayleyTree(int n, double x0, double y0, double len, double th)
        {
            if (n == 0) return;
            double x1 = x0 + len * Math.Cos(th);
            double y1 = y0 + len * Math.Sin(th);
            graphics.DrawLine(DrawPen,
               (int)x0, (int)y0, (int)x1, (int)y1);
            drawCayleyTree(n - 1, x1, y1, this.Per1 * len, th + this.Th1 * Math.PI / 180);
            drawCayleyTree(n - 1, x1, y1, this.Per2 * len, th - this.Th2 * Math.PI / 180);
        }
    }
}
