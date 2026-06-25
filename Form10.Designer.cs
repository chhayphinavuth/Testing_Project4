namespace WinFormsApp2
{
    partial class Form10
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
            LblMethod = new Label();
            CboMethod = new ComboBox();
            LblAmount = new Label();
            TxtValue1 = new TextBox();
            TxtValue2 = new TextBox();
            label3 = new Label();
            TxtValue3 = new TextBox();
            LblTerm = new Label();
            BtnCaculate = new Button();
            listViewReport = new ListView();
            SuspendLayout();
            // 
            // LblMethod
            // 
            LblMethod.AutoSize = true;
            LblMethod.Location = new Point(47, 21);
            LblMethod.Name = "LblMethod";
            LblMethod.Size = new Size(60, 15);
            LblMethod.TabIndex = 0;
            LblMethod.Text = "METHOD:";
            // 
            // CboMethod
            // 
            CboMethod.FormattingEnabled = true;
            CboMethod.Location = new Point(113, 21);
            CboMethod.Name = "CboMethod";
            CboMethod.Size = new Size(174, 23);
            CboMethod.TabIndex = 1;
            // 
            // LblAmount
            // 
            LblAmount.AutoSize = true;
            LblAmount.Location = new Point(47, 50);
            LblAmount.Name = "LblAmount";
            LblAmount.Size = new Size(54, 15);
            LblAmount.TabIndex = 2;
            LblAmount.Text = "VALUE 1:";
            // 
            // TxtValue1
            // 
            TxtValue1.Location = new Point(113, 50);
            TxtValue1.Name = "TxtValue1";
            TxtValue1.Size = new Size(174, 23);
            TxtValue1.TabIndex = 3;
            // 
            // TxtValue2
            // 
            TxtValue2.Location = new Point(113, 88);
            TxtValue2.Name = "TxtValue2";
            TxtValue2.Size = new Size(174, 23);
            TxtValue2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 88);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "VALUE 2:";
            // 
            // TxtValue3
            // 
            TxtValue3.Location = new Point(113, 127);
            TxtValue3.Name = "TxtValue3";
            TxtValue3.Size = new Size(174, 23);
            TxtValue3.TabIndex = 7;
            // 
            // LblTerm
            // 
            LblTerm.AutoSize = true;
            LblTerm.Location = new Point(47, 127);
            LblTerm.Name = "LblTerm";
            LblTerm.Size = new Size(54, 15);
            LblTerm.TabIndex = 6;
            LblTerm.Text = "VALUE 3:";
            // 
            // BtnCaculate
            // 
            BtnCaculate.Location = new Point(113, 156);
            BtnCaculate.Name = "BtnCaculate";
            BtnCaculate.Size = new Size(174, 52);
            BtnCaculate.TabIndex = 8;
            BtnCaculate.Text = "&Caculate";
            BtnCaculate.UseVisualStyleBackColor = true;
            BtnCaculate.Click += BtnCaculate_Click;
            // 
            // listViewReport
            // 
            listViewReport.Location = new Point(113, 214);
            listViewReport.Name = "listViewReport";
            listViewReport.Size = new Size(508, 145);
            listViewReport.TabIndex = 9;
            listViewReport.UseCompatibleStateImageBehavior = false;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 382);
            Controls.Add(listViewReport);
            Controls.Add(BtnCaculate);
            Controls.Add(TxtValue3);
            Controls.Add(LblTerm);
            Controls.Add(TxtValue2);
            Controls.Add(label3);
            Controls.Add(TxtValue1);
            Controls.Add(LblAmount);
            Controls.Add(CboMethod);
            Controls.Add(LblMethod);
            Name = "Form10";
            Text = "Using Public Method and paramet";
            Load += Form10_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblMethod;
        private ComboBox CboMethod;
        private Label LblAmount;
        private TextBox TxtValue1;
        private TextBox TxtValue2;
        private Label label3;
        private TextBox TxtValue3;
        private Label LblTerm;
        private Button BtnCaculate;
        private ListView listViewReport;
    }
}