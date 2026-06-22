using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //Add CCY
            CboCCY.Items.Clear();
            CboCCY.Items.Add("KHR");
            CboCCY.Items.Add("USD");
            CboCCY.Text = CboCCY.Items[0].ToString();

            //Add value to text box
            TxtUnitPrice.Text = "0";
            TxtQty.Text = "0";

            //Create property in listview control

            listViewArray.View = View.Details;
            listViewArray.FullRowSelect = true;
            listViewArray.GridLines = true;
            //listViewItems.View = View.List;
            //listViewItems.View = View.Tile;

            //Create col in listview control
            listViewArray.Columns.Clear();
            listViewArray.Columns.Add("NO.", 50, HorizontalAlignment.Center);
            listViewArray.Columns.Add("PRO_NAME", 100, HorizontalAlignment.Center);
            listViewArray.Columns.Add("CCY", 50, HorizontalAlignment.Center);
            listViewArray.Columns.Add("UNIT_PRICE", 100, HorizontalAlignment.Center);
            listViewArray.Columns.Add("QTY", 100, HorizontalAlignment.Center);


        }


        private void BtnSaleItems_Click(object sender, EventArgs e)
        {
            string Pro_Name = TxtProductName.Text;
            string CCY = CboCCY.Text;
            double Unit_Price = double.Parse(TxtUnitPrice.Text.ToString());
            int QTY = int.Parse(TxtUnitPrice.Text.ToString()); ;
            //My_Array = {""};
            string[] My_Array =
                {Pro_Name,CCY,Unit_Price.ToString(),QTY.ToString() };

            //Get Items from Array
            listViewArray.Items.Clear();
            foreach (var items in My_Array)
            {
                listViewArray.Items.Add(items);

            }
        }

        private void BtnViewItems_Click(object sender, EventArgs e)
        {
            listViewArray.Items.Clear();
            //listViewItem item = new listViewItem("1");
            ListViewItem items = new ListViewItem("1");
            items.SubItems.Add("Milk");
            items.SubItems.Add("KHR");
            items.SubItems.Add("20000");
            items.SubItems.Add("2");

            listViewArray.Items.Add(items);
        }
    }
}
