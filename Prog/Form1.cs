using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog
{
    public partial class Form1 : Form
    {
        public static List<List<decimal>> GroupOfLists;
        public Form1()
        {
            InitializeComponent();
        }
        public void SetFormSize() 
        {
            this.Size = new Size(1200,600);
            var Width =(Screen.PrimaryScreen.Bounds.Width-this.Width)/2;
            var Height = (Screen.PrimaryScreen.Bounds.Height-this.Height) / 2;
            this.Location = new Point(Width,Height);
        }
        private void Form1_Move(object sender, EventArgs e)
        {
            SetFormSize();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetFormSize();
        }
        private void Form1_Click(object sender, EventArgs e)
        { 
            Txt1.Clear();
            Txt4.Clear();
            Txt5.Clear();
            Txt2.Clear();
            Txt7.Clear();
            Txt8.Clear();
            Txt3.Clear();
            Txt6.Clear();
            Txt9.Clear(); 
        }
        public List<List<decimal>> BasicMethod()
        {
            List<Decimal> listA = new List<decimal>();
            List<Decimal> listB = new List<decimal>();
            List<Decimal> listC = new List<decimal>();

            listA.Add(Convert.ToDecimal(Txt1.Text));
            listA.Add(Convert.ToDecimal(Txt2.Text));
            listA.Add(Convert.ToDecimal(Txt3.Text));


            listB.Add(Convert.ToDecimal(Txt4.Text));
            listB.Add(Convert.ToDecimal(Txt5.Text));
            listB.Add(Convert.ToDecimal(Txt6.Text));



            listC.Add(Convert.ToDecimal(Txt7.Text));
            listC.Add(Convert.ToDecimal(Txt8.Text));
            listC.Add(Convert.ToDecimal(Txt9.Text));

            return new List<List<Decimal>> { listA, listB, listC };
        }
        private void CalcBtn_Click_1(object sender, EventArgs e)
        {
           GroupOfLists= BasicMethod();
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
            
            
        }
      
    }
}
