namespace WinFormsApp2
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            uiTabControlMain = new Sunny.UI.UITabControlMenu();
            tabPageLogIn = new TabPage();
            uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            uiBarChart1 = new Sunny.UI.UIBarChart();
            uiLabel5 = new Sunny.UI.UILabel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPageUserAccount = new TabPage();
            ButView = new Button();
            ButDel = new Button();
            ButUpdate = new Button();
            ButInsert = new Button();
            CboProFile = new ComboBox();
            LblProFile = new Label();
            LblUserEmail = new Label();
            TxtUserEmail = new TextBox();
            LblUserPwd = new Label();
            TxtUserPwd = new TextBox();
            LblUserName = new Label();
            TxtUserName = new TextBox();
            LblUserID = new Label();
            TxtUserID = new TextBox();
            tabPageSuppliers = new TabPage();
            tabControlSupplier = new TabControl();
            tabPageSupplierInfo = new TabPage();
            uiListBox1 = new Sunny.UI.UIListBox();
            uiBtnCommit = new Sunny.UI.UIButton();
            uiTxtSubName = new Sunny.UI.UITextBox();
            uiLabelSubName = new Sunny.UI.UILabel();
            uiTxtAddress = new Sunny.UI.UITextBox();
            uiTxtEmail = new Sunny.UI.UITextBox();
            uiTxtPhone = new Sunny.UI.UITextBox();
            uiTxtContactPerson = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiTxtSupID = new Sunny.UI.UITextBox();
            uiLabelSupID = new Sunny.UI.UILabel();
            tabPagePurchase = new TabPage();
            tabControlPurchase = new TabControl();
            tabPagePurchaseInfo = new TabPage();
            tabPageReport = new TabPage();
            imageList1 = new ImageList(components);
            groupBox1 = new GroupBox();
            uiTabControlMain.SuspendLayout();
            tabPageLogIn.SuspendLayout();
            tabPageUserAccount.SuspendLayout();
            tabPageSuppliers.SuspendLayout();
            tabControlSupplier.SuspendLayout();
            tabPageSupplierInfo.SuspendLayout();
            tabPagePurchase.SuspendLayout();
            tabControlPurchase.SuspendLayout();
            tabPageReport.SuspendLayout();
            SuspendLayout();
            // 
            // uiTabControlMain
            // 
            uiTabControlMain.Alignment = TabAlignment.Left;
            uiTabControlMain.Controls.Add(tabPageLogIn);
            uiTabControlMain.Controls.Add(tabPageUserAccount);
            uiTabControlMain.Controls.Add(tabPageSuppliers);
            uiTabControlMain.Controls.Add(tabPagePurchase);
            uiTabControlMain.Controls.Add(tabPageReport);
            uiTabControlMain.Dock = DockStyle.Fill;
            uiTabControlMain.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControlMain.Font = new Font("Microsoft Sans Serif", 12F);
            uiTabControlMain.ImageList = imageList1;
            uiTabControlMain.Location = new Point(0, 0);
            uiTabControlMain.Margin = new Padding(6, 8, 6, 8);
            uiTabControlMain.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTabControlMain.Multiline = true;
            uiTabControlMain.Name = "uiTabControlMain";
            uiTabControlMain.SelectedIndex = 0;
            uiTabControlMain.Size = new Size(2250, 1230);
            uiTabControlMain.SizeMode = TabSizeMode.Fixed;
            uiTabControlMain.TabBackColor = Color.DarkGoldenrod;
            uiTabControlMain.TabIndex = 4;
            uiTabControlMain.TabSelectedColor = Color.MistyRose;
            // 
            // tabPageLogIn
            // 
            tabPageLogIn.Controls.Add(uiSymbolButton1);
            tabPageLogIn.Controls.Add(uiComboBox1);
            tabPageLogIn.Controls.Add(uiBarChart1);
            tabPageLogIn.Controls.Add(uiLabel5);
            tabPageLogIn.Controls.Add(button1);
            tabPageLogIn.Controls.Add(comboBox1);
            tabPageLogIn.Controls.Add(label3);
            tabPageLogIn.Controls.Add(textBox2);
            tabPageLogIn.Controls.Add(label2);
            tabPageLogIn.Controls.Add(textBox1);
            tabPageLogIn.Controls.Add(label1);
            tabPageLogIn.ImageIndex = 9;
            tabPageLogIn.Location = new Point(201, 0);
            tabPageLogIn.Margin = new Padding(6, 8, 6, 8);
            tabPageLogIn.Name = "tabPageLogIn";
            tabPageLogIn.Size = new Size(2049, 1230);
            tabPageLogIn.TabIndex = 3;
            tabPageLogIn.Text = "Log In";
            tabPageLogIn.UseVisualStyleBackColor = true;
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolButton1.Location = new Point(440, 687);
            uiSymbolButton1.Margin = new Padding(6);
            uiSymbolButton1.MinimumSize = new Size(2, 2);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.Size = new Size(525, 90);
            uiSymbolButton1.TabIndex = 10;
            uiSymbolButton1.Text = "uiSymbolButton1";
            uiSymbolButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiComboBox1
            // 
            uiComboBox1.DataSource = null;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiComboBox1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox1.Location = new Point(1043, 160);
            uiComboBox1.Margin = new Padding(6, 8, 6, 8);
            uiComboBox1.MinimumSize = new Size(106, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 64, 4);
            uiComboBox1.Size = new Size(382, 72);
            uiComboBox1.SymbolSize = 24;
            uiComboBox1.TabIndex = 9;
            uiComboBox1.Text = "uiComboBox1";
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "";
            // 
            // uiBarChart1
            // 
            uiBarChart1.Font = new Font("Microsoft Sans Serif", 12F);
            uiBarChart1.LegendFont = new Font("Microsoft Sans Serif", 9F);
            uiBarChart1.Location = new Point(1055, 317);
            uiBarChart1.Margin = new Padding(4);
            uiBarChart1.MinimumSize = new Size(2, 2);
            uiBarChart1.Name = "uiBarChart1";
            uiBarChart1.Size = new Size(550, 228);
            uiBarChart1.SubFont = new Font("Microsoft Sans Serif", 9F);
            uiBarChart1.TabIndex = 8;
            uiBarChart1.Text = "uiBarChart1";
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(1216, 242);
            uiLabel5.Margin = new Padding(4, 0, 4, 0);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(255, 55);
            uiLabel5.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(440, 484);
            button1.Margin = new Padding(6, 8, 6, 8);
            button1.Name = "button1";
            button1.Size = new Size(427, 111);
            button1.TabIndex = 6;
            button1.Text = "Log &In";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(446, 357);
            comboBox1.Margin = new Padding(6, 8, 6, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(414, 54);
            comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 357);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(197, 46);
            label3.TabIndex = 4;
            label3.Text = "SERVER:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(446, 234);
            textBox2.Margin = new Padding(6, 8, 6, 8);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(414, 53);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 234);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(266, 46);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(446, 107);
            textBox1.Margin = new Padding(6, 8, 6, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 53);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 107);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 46);
            label1.TabIndex = 0;
            label1.Text = "USER NAME:";
            // 
            // tabPageUserAccount
            // 
            tabPageUserAccount.Controls.Add(ButView);
            tabPageUserAccount.Controls.Add(ButDel);
            tabPageUserAccount.Controls.Add(ButUpdate);
            tabPageUserAccount.Controls.Add(ButInsert);
            tabPageUserAccount.Controls.Add(CboProFile);
            tabPageUserAccount.Controls.Add(LblProFile);
            tabPageUserAccount.Controls.Add(LblUserEmail);
            tabPageUserAccount.Controls.Add(TxtUserEmail);
            tabPageUserAccount.Controls.Add(LblUserPwd);
            tabPageUserAccount.Controls.Add(TxtUserPwd);
            tabPageUserAccount.Controls.Add(LblUserName);
            tabPageUserAccount.Controls.Add(TxtUserName);
            tabPageUserAccount.Controls.Add(LblUserID);
            tabPageUserAccount.Controls.Add(TxtUserID);
            tabPageUserAccount.Location = new Point(201, 0);
            tabPageUserAccount.Margin = new Padding(6, 8, 6, 8);
            tabPageUserAccount.Name = "tabPageUserAccount";
            tabPageUserAccount.Size = new Size(2049, 1230);
            tabPageUserAccount.TabIndex = 2;
            tabPageUserAccount.Text = "User Account";
            tabPageUserAccount.UseVisualStyleBackColor = true;
            // 
            // ButView
            // 
            ButView.Location = new Point(544, 816);
            ButView.Margin = new Padding(6, 8, 6, 8);
            ButView.Name = "ButView";
            ButView.Size = new Size(657, 102);
            ButView.TabIndex = 14;
            ButView.Text = "&VIEW";
            ButView.UseVisualStyleBackColor = true;
            ButView.Click += ButView_Click;
            // 
            // ButDel
            // 
            ButDel.Location = new Point(990, 693);
            ButDel.Margin = new Padding(6, 8, 6, 8);
            ButDel.Name = "ButDel";
            ButDel.Size = new Size(208, 102);
            ButDel.TabIndex = 13;
            ButDel.Text = "DEL";
            ButDel.UseVisualStyleBackColor = true;
            ButDel.Click += ButDel_Click;
            // 
            // ButUpdate
            // 
            ButUpdate.Location = new Point(767, 693);
            ButUpdate.Margin = new Padding(6, 8, 6, 8);
            ButUpdate.Name = "ButUpdate";
            ButUpdate.Size = new Size(208, 102);
            ButUpdate.TabIndex = 12;
            ButUpdate.Text = "&UPDATE";
            ButUpdate.UseVisualStyleBackColor = true;
            ButUpdate.Click += ButUpdate_Click;
            // 
            // ButInsert
            // 
            ButInsert.Location = new Point(544, 693);
            ButInsert.Margin = new Padding(6, 8, 6, 8);
            ButInsert.Name = "ButInsert";
            ButInsert.Size = new Size(208, 102);
            ButInsert.TabIndex = 11;
            ButInsert.Text = "&INSERT";
            ButInsert.UseVisualStyleBackColor = true;
            ButInsert.Click += ButInsert_Click;
            // 
            // CboProFile
            // 
            CboProFile.FormattingEnabled = true;
            CboProFile.Location = new Point(544, 578);
            CboProFile.Margin = new Padding(6, 8, 6, 8);
            CboProFile.Name = "CboProFile";
            CboProFile.Size = new Size(650, 54);
            CboProFile.TabIndex = 10;
            // 
            // LblProFile
            // 
            LblProFile.AutoSize = true;
            LblProFile.Location = new Point(108, 578);
            LblProFile.Margin = new Padding(6, 0, 6, 0);
            LblProFile.Name = "LblProFile";
            LblProFile.Size = new Size(335, 46);
            LblProFile.TabIndex = 9;
            LblProFile.Text = "USER_PROFILE:";
            // 
            // LblUserEmail
            // 
            LblUserEmail.AutoSize = true;
            LblUserEmail.Location = new Point(108, 451);
            LblUserEmail.Margin = new Padding(6, 0, 6, 0);
            LblUserEmail.Name = "LblUserEmail";
            LblUserEmail.Size = new Size(284, 46);
            LblUserEmail.TabIndex = 7;
            LblUserEmail.Text = "USER_EMAIL:";
            // 
            // TxtUserEmail
            // 
            TxtUserEmail.Location = new Point(544, 451);
            TxtUserEmail.Margin = new Padding(6, 8, 6, 8);
            TxtUserEmail.Name = "TxtUserEmail";
            TxtUserEmail.Size = new Size(650, 53);
            TxtUserEmail.TabIndex = 6;
            // 
            // LblUserPwd
            // 
            LblUserPwd.AutoSize = true;
            LblUserPwd.Location = new Point(108, 332);
            LblUserPwd.Margin = new Padding(6, 0, 6, 0);
            LblUserPwd.Name = "LblUserPwd";
            LblUserPwd.Size = new Size(259, 46);
            LblUserPwd.TabIndex = 5;
            LblUserPwd.Text = "USER_PWD:";
            // 
            // TxtUserPwd
            // 
            TxtUserPwd.Location = new Point(544, 332);
            TxtUserPwd.Margin = new Padding(6, 8, 6, 8);
            TxtUserPwd.Name = "TxtUserPwd";
            TxtUserPwd.PasswordChar = '*';
            TxtUserPwd.Size = new Size(650, 53);
            TxtUserPwd.TabIndex = 4;
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.Location = new Point(108, 201);
            LblUserName.Margin = new Padding(6, 0, 6, 0);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(281, 46);
            LblUserName.TabIndex = 3;
            LblUserName.Text = "USER_NAME:";
            // 
            // TxtUserName
            // 
            TxtUserName.Location = new Point(544, 201);
            TxtUserName.Margin = new Padding(6, 8, 6, 8);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(650, 53);
            TxtUserName.TabIndex = 2;
            // 
            // LblUserID
            // 
            LblUserID.AutoSize = true;
            LblUserID.Location = new Point(108, 74);
            LblUserID.Margin = new Padding(6, 0, 6, 0);
            LblUserID.Name = "LblUserID";
            LblUserID.Size = new Size(204, 46);
            LblUserID.TabIndex = 1;
            LblUserID.Text = "USER_ID:";
            // 
            // TxtUserID
            // 
            TxtUserID.Location = new Point(544, 74);
            TxtUserID.Margin = new Padding(6, 8, 6, 8);
            TxtUserID.Name = "TxtUserID";
            TxtUserID.Size = new Size(650, 53);
            TxtUserID.TabIndex = 0;
            // 
            // tabPageSuppliers
            // 
            tabPageSuppliers.Controls.Add(tabControlSupplier);
            tabPageSuppliers.ImageIndex = 0;
            tabPageSuppliers.Location = new Point(201, 0);
            tabPageSuppliers.Margin = new Padding(6, 8, 6, 8);
            tabPageSuppliers.Name = "tabPageSuppliers";
            tabPageSuppliers.Size = new Size(2049, 1230);
            tabPageSuppliers.TabIndex = 1;
            tabPageSuppliers.Text = "Suppliers";
            tabPageSuppliers.UseVisualStyleBackColor = true;
            // 
            // tabControlSupplier
            // 
            tabControlSupplier.Controls.Add(tabPageSupplierInfo);
            tabControlSupplier.Dock = DockStyle.Fill;
            tabControlSupplier.Location = new Point(0, 0);
            tabControlSupplier.Margin = new Padding(6, 8, 6, 8);
            tabControlSupplier.Name = "tabControlSupplier";
            tabControlSupplier.SelectedIndex = 0;
            tabControlSupplier.Size = new Size(2049, 1230);
            tabControlSupplier.TabIndex = 0;
            // 
            // tabPageSupplierInfo
            // 
            tabPageSupplierInfo.Controls.Add(uiListBox1);
            tabPageSupplierInfo.Controls.Add(uiBtnCommit);
            tabPageSupplierInfo.Controls.Add(uiTxtSubName);
            tabPageSupplierInfo.Controls.Add(uiLabelSubName);
            tabPageSupplierInfo.Controls.Add(uiTxtAddress);
            tabPageSupplierInfo.Controls.Add(uiTxtEmail);
            tabPageSupplierInfo.Controls.Add(uiTxtPhone);
            tabPageSupplierInfo.Controls.Add(uiTxtContactPerson);
            tabPageSupplierInfo.Controls.Add(uiLabel4);
            tabPageSupplierInfo.Controls.Add(uiLabel3);
            tabPageSupplierInfo.Controls.Add(uiLabel2);
            tabPageSupplierInfo.Controls.Add(uiLabel1);
            tabPageSupplierInfo.Controls.Add(uiTxtSupID);
            tabPageSupplierInfo.Controls.Add(uiLabelSupID);
            tabPageSupplierInfo.Location = new Point(10, 63);
            tabPageSupplierInfo.Margin = new Padding(6, 8, 6, 8);
            tabPageSupplierInfo.Name = "tabPageSupplierInfo";
            tabPageSupplierInfo.Padding = new Padding(6, 8, 6, 8);
            tabPageSupplierInfo.Size = new Size(2029, 1157);
            tabPageSupplierInfo.TabIndex = 0;
            tabPageSupplierInfo.Text = "Supplier Info";
            tabPageSupplierInfo.UseVisualStyleBackColor = true;
            // 
            // uiListBox1
            // 
            uiListBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiListBox1.HoverColor = Color.FromArgb(155, 200, 255);
            uiListBox1.ItemSelectForeColor = Color.White;
            uiListBox1.Location = new Point(871, 62);
            uiListBox1.Margin = new Padding(11, 12, 11, 12);
            uiListBox1.MinimumSize = new Size(2, 4);
            uiListBox1.Name = "uiListBox1";
            uiListBox1.Padding = new Padding(4);
            uiListBox1.ShowText = false;
            uiListBox1.Size = new Size(850, 1054);
            uiListBox1.TabIndex = 10;
            uiListBox1.Text = "uiListBoxSuppliers";
            // 
            // uiBtnCommit
            // 
            uiBtnCommit.Font = new Font("Microsoft Sans Serif", 12F);
            uiBtnCommit.Location = new Point(436, 972);
            uiBtnCommit.Margin = new Padding(6, 8, 6, 8);
            uiBtnCommit.MinimumSize = new Size(2, 4);
            uiBtnCommit.Name = "uiBtnCommit";
            uiBtnCommit.Size = new Size(419, 148);
            uiBtnCommit.TabIndex = 5;
            uiBtnCommit.Text = "&Commit";
            uiBtnCommit.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiBtnCommit.Click += uiBtnCommit_Click;
            // 
            // uiTxtSubName
            // 
            uiTxtSubName.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtSubName.Location = new Point(436, 209);
            uiTxtSubName.Margin = new Padding(11, 12, 11, 12);
            uiTxtSubName.MinimumSize = new Size(2, 45);
            uiTxtSubName.Name = "uiTxtSubName";
            uiTxtSubName.Padding = new Padding(13, 12, 13, 12);
            uiTxtSubName.ShowText = false;
            uiTxtSubName.Size = new Size(419, 127);
            uiTxtSubName.TabIndex = 3;
            uiTxtSubName.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtSubName.Watermark = "";
            // 
            // uiLabelSubName
            // 
            uiLabelSubName.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabelSubName.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabelSubName.Location = new Point(36, 209);
            uiLabelSubName.Margin = new Padding(6, 0, 6, 0);
            uiLabelSubName.Name = "uiLabelSubName";
            uiLabelSubName.Size = new Size(327, 127);
            uiLabelSubName.TabIndex = 9;
            uiLabelSubName.Text = "Name:";
            // 
            // uiTxtAddress
            // 
            uiTxtAddress.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtAddress.Location = new Point(436, 824);
            uiTxtAddress.Margin = new Padding(11, 12, 11, 12);
            uiTxtAddress.MinimumSize = new Size(2, 45);
            uiTxtAddress.Name = "uiTxtAddress";
            uiTxtAddress.Padding = new Padding(13, 12, 13, 12);
            uiTxtAddress.ShowText = false;
            uiTxtAddress.Size = new Size(419, 127);
            uiTxtAddress.TabIndex = 8;
            uiTxtAddress.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtAddress.Watermark = "";
            // 
            // uiTxtEmail
            // 
            uiTxtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtEmail.Location = new Point(436, 668);
            uiTxtEmail.Margin = new Padding(11, 12, 11, 12);
            uiTxtEmail.MinimumSize = new Size(2, 45);
            uiTxtEmail.Name = "uiTxtEmail";
            uiTxtEmail.Padding = new Padding(13, 12, 13, 12);
            uiTxtEmail.ShowText = false;
            uiTxtEmail.Size = new Size(419, 127);
            uiTxtEmail.TabIndex = 7;
            uiTxtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtEmail.Watermark = "";
            // 
            // uiTxtPhone
            // 
            uiTxtPhone.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtPhone.Location = new Point(436, 517);
            uiTxtPhone.Margin = new Padding(11, 12, 11, 12);
            uiTxtPhone.MinimumSize = new Size(2, 45);
            uiTxtPhone.Name = "uiTxtPhone";
            uiTxtPhone.Padding = new Padding(13, 12, 13, 12);
            uiTxtPhone.ShowText = false;
            uiTxtPhone.Size = new Size(419, 127);
            uiTxtPhone.TabIndex = 6;
            uiTxtPhone.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtPhone.Watermark = "";
            // 
            // uiTxtContactPerson
            // 
            uiTxtContactPerson.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtContactPerson.Location = new Point(436, 365);
            uiTxtContactPerson.Margin = new Padding(11, 12, 11, 12);
            uiTxtContactPerson.MinimumSize = new Size(2, 45);
            uiTxtContactPerson.Name = "uiTxtContactPerson";
            uiTxtContactPerson.Padding = new Padding(13, 12, 13, 12);
            uiTxtContactPerson.ShowText = false;
            uiTxtContactPerson.Size = new Size(419, 127);
            uiTxtContactPerson.TabIndex = 3;
            uiTxtContactPerson.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtContactPerson.Watermark = "";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(36, 824);
            uiLabel4.Margin = new Padding(6, 0, 6, 0);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(327, 127);
            uiLabel4.TabIndex = 5;
            uiLabel4.Text = "Address:";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(45, 668);
            uiLabel3.Margin = new Padding(6, 0, 6, 0);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(321, 127);
            uiLabel3.TabIndex = 4;
            uiLabel3.Text = "Email:";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(45, 517);
            uiLabel2.Margin = new Padding(6, 0, 6, 0);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(321, 127);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "Phone:";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(45, 365);
            uiLabel1.Margin = new Padding(6, 0, 6, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(321, 127);
            uiLabel1.TabIndex = 2;
            uiLabel1.Text = "Contact Person:";
            uiLabel1.Click += uiLabel1_Click;
            // 
            // uiTxtSupID
            // 
            uiTxtSupID.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtSupID.Location = new Point(436, 62);
            uiTxtSupID.Margin = new Padding(11, 12, 11, 12);
            uiTxtSupID.MinimumSize = new Size(2, 45);
            uiTxtSupID.Name = "uiTxtSupID";
            uiTxtSupID.Padding = new Padding(13, 12, 13, 12);
            uiTxtSupID.ShowText = false;
            uiTxtSupID.Size = new Size(419, 127);
            uiTxtSupID.TabIndex = 1;
            uiTxtSupID.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtSupID.Watermark = "";
            // 
            // uiLabelSupID
            // 
            uiLabelSupID.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabelSupID.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabelSupID.Location = new Point(45, 62);
            uiLabelSupID.Margin = new Padding(6, 0, 6, 0);
            uiLabelSupID.Name = "uiLabelSupID";
            uiLabelSupID.Size = new Size(321, 127);
            uiLabelSupID.TabIndex = 0;
            uiLabelSupID.Text = "ID:";
            // 
            // tabPagePurchase
            // 
            tabPagePurchase.Controls.Add(tabControlPurchase);
            tabPagePurchase.ImageIndex = 1;
            tabPagePurchase.Location = new Point(201, 0);
            tabPagePurchase.Margin = new Padding(6, 8, 6, 8);
            tabPagePurchase.Name = "tabPagePurchase";
            tabPagePurchase.Size = new Size(2049, 1230);
            tabPagePurchase.TabIndex = 0;
            tabPagePurchase.Text = "Purchase";
            tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // tabControlPurchase
            // 
            tabControlPurchase.Controls.Add(tabPagePurchaseInfo);
            tabControlPurchase.Dock = DockStyle.Fill;
            tabControlPurchase.Location = new Point(0, 0);
            tabControlPurchase.Margin = new Padding(6, 8, 6, 8);
            tabControlPurchase.Name = "tabControlPurchase";
            tabControlPurchase.SelectedIndex = 0;
            tabControlPurchase.Size = new Size(2049, 1230);
            tabControlPurchase.TabIndex = 0;
            // 
            // tabPagePurchaseInfo
            // 
            tabPagePurchaseInfo.Location = new Point(10, 63);
            tabPagePurchaseInfo.Margin = new Padding(6, 8, 6, 8);
            tabPagePurchaseInfo.Name = "tabPagePurchaseInfo";
            tabPagePurchaseInfo.Padding = new Padding(6, 8, 6, 8);
            tabPagePurchaseInfo.Size = new Size(2029, 1157);
            tabPagePurchaseInfo.TabIndex = 0;
            tabPagePurchaseInfo.Text = "Purchase Info";
            tabPagePurchaseInfo.UseVisualStyleBackColor = true;
            // 
            // tabPageReport
            // 
            tabPageReport.Controls.Add(groupBox1);
            tabPageReport.Location = new Point(201, 0);
            tabPageReport.Margin = new Padding(6, 8, 6, 8);
            tabPageReport.Name = "tabPageReport";
            tabPageReport.Size = new Size(2049, 1230);
            tabPageReport.TabIndex = 4;
            tabPageReport.Text = "Reports";
            tabPageReport.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Add Bookmark.ico");
            imageList1.Images.SetKeyName(1, "Add Bookmark_Red.ico");
            imageList1.Images.SetKeyName(2, "Bookmark.ico");
            imageList1.Images.SetKeyName(3, "Check Mark.ico");
            imageList1.Images.SetKeyName(4, "Check Mark_1.ico");
            imageList1.Images.SetKeyName(5, "Check Mark_2.ico");
            imageList1.Images.SetKeyName(6, "Done.ico");
            imageList1.Images.SetKeyName(7, "Download from the Cloud.ico");
            imageList1.Images.SetKeyName(8, "Download from the Cloud_1.ico");
            imageList1.Images.SetKeyName(9, "Key.ico");
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(755, 299);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 214);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2250, 1230);
            Controls.Add(uiTabControlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 8, 6, 8);
            Name = "FrmMain";
            Text = "Delivery Systems";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            uiTabControlMain.ResumeLayout(false);
            tabPageLogIn.ResumeLayout(false);
            tabPageLogIn.PerformLayout();
            tabPageUserAccount.ResumeLayout(false);
            tabPageUserAccount.PerformLayout();
            tabPageSuppliers.ResumeLayout(false);
            tabControlSupplier.ResumeLayout(false);
            tabPageSupplierInfo.ResumeLayout(false);
            tabPagePurchase.ResumeLayout(false);
            tabControlPurchase.ResumeLayout(false);
            tabPageReport.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMain;
        private TabPage tabPagePurchase;
        private TabPage tabPageSuppliers;
        private TabControl tabControlPurchase;
        private TabPage tabPagePurchaseInfo;
        private TabControl tabControlSupplier;
        private TabPage tabPageSupplierInfo;
        private Sunny.UI.UITextBox uiTxtSupID;
        private Sunny.UI.UILabel uiLabelSupID;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTxtAddress;
        private Sunny.UI.UITextBox uiTxtEmail;
        private Sunny.UI.UITextBox uiTxtPhone;
        private Sunny.UI.UITextBox uiTxtContactPerson;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox uiTxtSubName;
        private Sunny.UI.UILabel uiLabelSubName;
        private ImageList imageList1;
        private Sunny.UI.UIButton uiBtnCommit;
        private Sunny.UI.UIListBox uiListBox1;
        private TabPage tabPageUserAccount;
        private Label LblUserPwd;
        private TextBox TxtUserPwd;
        private Label LblUserName;
        private TextBox TxtUserName;
        private Label LblUserID;
        private TextBox TxtUserID;
        private ComboBox CboProFile;
        private Label LblProFile;
        private Label LblUserEmail;
        private TextBox TxtUserEmail;
        private Button ButDel;
        private Button ButUpdate;
        private Button ButInsert;
        private Button ButView;
        private TabPage tabPageLogIn;
        private TabPage tabPageReport;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIBarChart uiBarChart1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private GroupBox groupBox1;
    }
}