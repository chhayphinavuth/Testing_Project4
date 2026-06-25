using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // Call Combobox Property
            My_Combobox_Property();

            // Call TextBox Property
            My_TextBox_Property();

            //Call Method create listview column
            My_Listview_Col();

        }

        public void My_Combobox_Property()
        {
            CboMethod.Items.Clear();
            CboMethod.Items.Add("SUM");
            CboMethod.Items.Add("MUL");
            CboMethod.Items.Add("SUB");
            CboMethod.Text = CboMethod.Items[0].ToString();
        }

        public void My_TextBox_Property()
        {
            TxtValue1.Text = "0";
            TxtValue2.Text = "0";
            TxtValue3.Text = "0";
        }

        public void My_Listview_Col()
        {
            //Create Property in listview control

            listViewReport.View = View.Details;
            listViewReport.FullRowSelect = true;
            listViewReport.GridLines = true;

            //Create Col in listview control
            listViewReport.Columns.Clear();
            listViewReport.Columns.Add("NO.",50,HorizontalAlignment.Center);
            listViewReport.Columns.Add("VALUE1", 100, HorizontalAlignment.Center);
            listViewReport.Columns.Add("VALUE2", 100, HorizontalAlignment.Center);
            listViewReport.Columns.Add("VALUE3", 100, HorizontalAlignment.Center);
            listViewReport.Columns.Add("METHOD", 100, HorizontalAlignment.Center);
            listViewReport.Columns.Add("AMOUNT", 100, HorizontalAlignment.Center);
        }

        public double My_Method(string Tmp_Method , double VALUE1, double VALUE2, double VALUE3)
        {
            double My_calculate = 0;

            switch (Tmp_Method)
            {
                case "SUM":
                    My_calculate = VALUE1+VALUE2+VALUE3;
                    break;

                case "SUB":
                    My_calculate = VALUE1-VALUE2-VALUE3;
                    break;

                case "MUL":
                    My_calculate=VALUE1* VALUE2*VALUE3;
                    break;

                default:
                    //Console.WriteLine("Number must be between 1 and 7.");
                    //Display message box
                    break;
            }

            return My_calculate;
        }

        public void My_Caculate()
        {
            string Tmp_method = CboMethod.Text;
            double VALUE1 = double.Parse(TxtValue1.Text.ToString());    //  get value from TxtValue1
            double VALUE2 = double.Parse(TxtValue2.Text.ToString()); ;    //  get value from TxtValue2
            double VALUE3 = double.Parse(TxtValue3.Text.ToString()); ;    //  get value from TxtValue3

            double My_AMT = My_Method(CboMethod.Text, VALUE1, VALUE2, VALUE3);

            //listViewReport.Items.Clear();

            int My_Num = listViewReport.Items.Count + 1;

            //Delclare ListviewItems
            ListViewItem items = new ListViewItem(My_Num.ToString());  //NO.
            items.SubItems.Add(VALUE1.ToString());
            items.SubItems.Add(VALUE2.ToString());
            items.SubItems.Add(VALUE3.ToString());
            items.SubItems.Add(Tmp_method.ToString());
            items.SubItems.Add(My_AMT.ToString());

            //Get items to Listview
            listViewReport.Items.Add(items);

            //listViewReport.Items.Add
        }
        private void BtnCaculate_Click(object sender, EventArgs e)
        {
            My_Caculate();
        }
    }
}
