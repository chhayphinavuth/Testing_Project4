namespace WinFormsApp2
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblProductName = new Label();
            TxtProductName = new TextBox();
            TxtUnitPrice = new TextBox();
            LblUnitPrice = new Label();
            TxtQty = new TextBox();
            LblQty = new Label();
            BtnSaleItems = new Button();
            listViewArray = new ListView();
            BtnViewItems = new Button();
            CboCCY = new ComboBox();
            LblCCY = new Label();
            SuspendLayout();
            // 
            // LblProductName
            // 
            LblProductName.AutoSize = true;
            LblProductName.Location = new Point(25, 32);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new Size(103, 15);
            LblProductName.TabIndex = 0;
            LblProductName.Text = "PRODUCT_NAME:";
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(147, 32);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(258, 23);
            TxtProductName.TabIndex = 1;
            TxtProductName.TextChanged += textBox1_TextChanged;
            // 
            // TxtUnitPrice
            // 
            TxtUnitPrice.Location = new Point(147, 102);
            TxtUnitPrice.Name = "TxtUnitPrice";
            TxtUnitPrice.Size = new Size(258, 23);
            TxtUnitPrice.TabIndex = 3;
            // 
            // LblUnitPrice
            // 
            LblUnitPrice.AutoSize = true;
            LblUnitPrice.Location = new Point(25, 110);
            LblUnitPrice.Name = "LblUnitPrice";
            LblUnitPrice.Size = new Size(73, 15);
            LblUnitPrice.TabIndex = 2;
            LblUnitPrice.Text = "UNIT_PRICE:";
            // 
            // TxtQty
            // 
            TxtQty.Location = new Point(147, 139);
            TxtQty.Name = "TxtQty";
            TxtQty.Size = new Size(258, 23);
            TxtQty.TabIndex = 4;
            // 
            // LblQty
            // 
            LblQty.AutoSize = true;
            LblQty.Location = new Point(25, 139);
            LblQty.Name = "LblQty";
            LblQty.Size = new Size(33, 15);
            LblQty.TabIndex = 4;
            LblQty.Text = "QTY:";
            // 
            // BtnSaleItems
            // 
            BtnSaleItems.Location = new Point(147, 175);
            BtnSaleItems.Name = "BtnSaleItems";
            BtnSaleItems.Size = new Size(110, 45);
            BtnSaleItems.TabIndex = 5;
            BtnSaleItems.Text = "&Sale Items";
            BtnSaleItems.UseVisualStyleBackColor = true;
            BtnSaleItems.Click += BtnSaleItems_Click;
            // 
            // listViewArray
            // 
            listViewArray.Location = new Point(25, 226);
            listViewArray.Name = "listViewArray";
            listViewArray.Size = new Size(380, 112);
            listViewArray.TabIndex = 7;
            listViewArray.UseCompatibleStateImageBehavior = false;
            // 
            // BtnViewItems
            // 
            BtnViewItems.Location = new Point(263, 175);
            BtnViewItems.Name = "BtnViewItems";
            BtnViewItems.Size = new Size(142, 45);
            BtnViewItems.TabIndex = 6;
            BtnViewItems.Text = "&View Items";
            BtnViewItems.UseVisualStyleBackColor = true;
            BtnViewItems.Click += BtnViewItems_Click;
            // 
            // CboCCY
            // 
            CboCCY.FormattingEnabled = true;
            CboCCY.Location = new Point(147, 70);
            CboCCY.Name = "CboCCY";
            CboCCY.Size = new Size(258, 23);
            CboCCY.TabIndex = 2;
            // 
            // LblCCY
            // 
            LblCCY.AutoSize = true;
            LblCCY.Location = new Point(25, 70);
            LblCCY.Name = "LblCCY";
            LblCCY.Size = new Size(33, 15);
            LblCCY.TabIndex = 10;
            LblCCY.Text = "CCY:";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 362);
            Controls.Add(LblCCY);
            Controls.Add(CboCCY);
            Controls.Add(BtnViewItems);
            Controls.Add(listViewArray);
            Controls.Add(BtnSaleItems);
            Controls.Add(TxtQty);
            Controls.Add(LblQty);
            Controls.Add(TxtUnitPrice);
            Controls.Add(LblUnitPrice);
            Controls.Add(TxtProductName);
            Controls.Add(LblProductName);
            Name = "Form9";
            Text = "Using Array";
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblProductName;
        private TextBox TxtProductName;
        private TextBox TxtUnitPrice;
        private Label LblUnitPrice;
        private TextBox TxtQty;
        private Label LblQty;
        private Button BtnSaleItems;
        private ListView listViewArray;
        private Button BtnViewItems;
        private ComboBox CboCCY;
        private Label LblCCY;
    }
}