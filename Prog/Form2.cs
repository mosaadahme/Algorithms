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
    public partial class Form2 : Form
    {

        string ContentOne = "Project A.. is the best thing for Investment";
        string ContentTwo = "Project B.. is the best thing for Investment";
        string ContentThree = "Project C.. is the best thing for Investment";
        public Form2()
        {
            InitializeComponent();
        }

        

        private void BtnMax_Click(object sender, EventArgs e)
        {
            
            var temp=Form1.GroupOfLists.Select(x=> x.Max()).ToList();
            TxtMax.Text = temp.Max().ToString();
            var IndexResult = temp.IndexOf((temp.Max()));
            MessageBox.Show(IndexResult == 0 ? ContentOne : IndexResult == 1 ? ContentTwo : ContentThree);
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
             
            var temp = Form1.GroupOfLists.Select(x => x.Min()).ToList();
            TxtMin.Text = temp.Max().ToString();
            var IndexResult=  temp.IndexOf((temp.Max()));
            MessageBox.Show(IndexResult==0?ContentOne: IndexResult == 1 ? ContentTwo:ContentThree);
        }

        private void BtnMinMax_Click(object sender, EventArgs e)
        {
            string Content = string.Empty;
            List<decimal> c1 = new List<decimal>();
            List<decimal> c2 = new List<decimal>();
            List<decimal> c3 = new List<decimal>();

           var FirstColumn= Form1.GroupOfLists.Select(x => x.ElementAt(0)).ToList();//list of first col
           var SecondColumn = Form1.GroupOfLists.Select(x => x.ElementAt(1)).ToList();
           var ThirdColumn = Form1.GroupOfLists.Select(x => x.ElementAt(2)).ToList();


            for (int i = 0; i < FirstColumn.Count; i++)
            {
                c1.Add(FirstColumn.Max() - FirstColumn.ElementAt(i));
            }

         
           for (int i = 0; i< SecondColumn.Count; i++)
            {
                c2.Add(SecondColumn.Max() - SecondColumn.ElementAt(i));
            }
            for (int i = 0; i < ThirdColumn.Count; i++)
            {
                c3.Add(ThirdColumn.Max() - ThirdColumn.ElementAt(i));
            }
            int Pointer = -1;
            // c1,c2,c3 make regret table
            List<List<decimal>> FinalCompositeList = new List<List<decimal>>() {c1,c2,c3};
            var FirstVal=FinalCompositeList.Select(x => x.ElementAt(0)).Max();
            var SecondVal = FinalCompositeList.Select(x => x.ElementAt(1)).Max();
            var ThirdVal = FinalCompositeList.Select(x => x.ElementAt(2)).Max();
            if ((FirstVal<SecondVal)&&(FirstVal<ThirdVal))
            {
                TxtMaxBoth.Text = FirstVal.ToString();
                Pointer = 0;
            }
            else if ((SecondVal<FirstVal) && (SecondVal < ThirdVal)) 
            {
                TxtMaxBoth.Text = SecondVal.ToString();
                Pointer = 1;
            }
            else 
            {
                TxtMaxBoth.Text = ThirdVal.ToString();
                Pointer = 2;
            }
            MessageBox.Show(Pointer == 0 ? ContentOne : Pointer == 1 ? ContentTwo : ContentThree);
        }
    }
 
}
