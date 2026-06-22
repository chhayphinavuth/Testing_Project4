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
            uiLabel5 = new Sunny.UI.UILabel();
            uiLabel6 = new Sunny.UI.UILabel();
            uiTabControlMain.SuspendLayout();
            tabPageLogIn.SuspendLayout();
            tabPageUserAccount.SuspendLayout();
            tabPageSuppliers.SuspendLayout();
            tabControlSupplier.SuspendLayout();
            tabPageSupplierInfo.SuspendLayout();
            tabPagePurchase.SuspendLayout();
            tabControlPurchase.SuspendLayout();
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
            uiTabControlMain.Margin = new Padding(4, 5, 4, 5);
            uiTabControlMain.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTabControlMain.Multiline = true;
            uiTabControlMain.Name = "uiTabControlMain";
            uiTabControlMain.SelectedIndex = 0;
            uiTabControlMain.Size = new Size(1324, 750);
            uiTabControlMain.SizeMode = TabSizeMode.Fixed;
            uiTabControlMain.TabBackColor = Color.DarkGoldenrod;
            uiTabControlMain.TabIndex = 4;
            uiTabControlMain.TabSelectedColor = Color.MistyRose;
            // 
            // tabPageLogIn
            // 
            tabPageLogIn.Controls.Add(uiLabel6);
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
            tabPageLogIn.Margin = new Padding(4, 5, 4, 5);
            tabPageLogIn.Name = "tabPageLogIn";
            tabPageLogIn.Size = new Size(1123, 750);
            tabPageLogIn.TabIndex = 3;
            tabPageLogIn.Text = "Log In";
            tabPageLogIn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(259, 295);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(251, 67);
            button1.TabIndex = 6;
            button1.Text = "Log &In";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(263, 218);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 37);
            comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 218);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 29);
            label3.TabIndex = 4;
            label3.Text = "SERVER:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(263, 143);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 35);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 143);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 29);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(263, 65);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 35);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 29);
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
            tabPageUserAccount.Margin = new Padding(4, 5, 4, 5);
            tabPageUserAccount.Name = "tabPageUserAccount";
            tabPageUserAccount.Size = new Size(1123, 750);
            tabPageUserAccount.TabIndex = 2;
            tabPageUserAccount.Text = "User Account";
            tabPageUserAccount.UseVisualStyleBackColor = true;
            // 
            // ButView
            // 
            ButView.Location = new Point(320, 497);
            ButView.Margin = new Padding(4, 5, 4, 5);
            ButView.Name = "ButView";
            ButView.Size = new Size(386, 63);
            ButView.TabIndex = 14;
            ButView.Text = "&VIEW";
            ButView.UseVisualStyleBackColor = true;
            ButView.Click += ButView_Click;
            // 
            // ButDel
            // 
            ButDel.Location = new Point(583, 423);
            ButDel.Margin = new Padding(4, 5, 4, 5);
            ButDel.Name = "ButDel";
            ButDel.Size = new Size(123, 63);
            ButDel.TabIndex = 13;
            ButDel.Text = "DEL";
            ButDel.UseVisualStyleBackColor = true;
            ButDel.Click += ButDel_Click;
            // 
            // ButUpdate
            // 
            ButUpdate.Location = new Point(451, 423);
            ButUpdate.Margin = new Padding(4, 5, 4, 5);
            ButUpdate.Name = "ButUpdate";
            ButUpdate.Size = new Size(123, 63);
            ButUpdate.TabIndex = 12;
            ButUpdate.Text = "&UPDATE";
            ButUpdate.UseVisualStyleBackColor = true;
            ButUpdate.Click += ButUpdate_Click;
            // 
            // ButInsert
            // 
            ButInsert.Location = new Point(320, 423);
            ButInsert.Margin = new Padding(4, 5, 4, 5);
            ButInsert.Name = "ButInsert";
            ButInsert.Size = new Size(123, 63);
            ButInsert.TabIndex = 11;
            ButInsert.Text = "&INSERT";
            ButInsert.UseVisualStyleBackColor = true;
            ButInsert.Click += ButInsert_Click;
            // 
            // CboProFile
            // 
            CboProFile.FormattingEnabled = true;
            CboProFile.Location = new Point(320, 352);
            CboProFile.Margin = new Padding(4, 5, 4, 5);
            CboProFile.Name = "CboProFile";
            CboProFile.Size = new Size(384, 37);
            CboProFile.TabIndex = 10;
            // 
            // LblProFile
            // 
            LblProFile.AutoSize = true;
            LblProFile.Location = new Point(64, 352);
            LblProFile.Margin = new Padding(4, 0, 4, 0);
            LblProFile.Name = "LblProFile";
            LblProFile.Size = new Size(200, 29);
            LblProFile.TabIndex = 9;
            LblProFile.Text = "USER_PROFILE:";
            // 
            // LblUserEmail
            // 
            LblUserEmail.AutoSize = true;
            LblUserEmail.Location = new Point(64, 275);
            LblUserEmail.Margin = new Padding(4, 0, 4, 0);
            LblUserEmail.Name = "LblUserEmail";
            LblUserEmail.Size = new Size(168, 29);
            LblUserEmail.TabIndex = 7;
            LblUserEmail.Text = "USER_EMAIL:";
            // 
            // TxtUserEmail
            // 
            TxtUserEmail.Location = new Point(320, 275);
            TxtUserEmail.Margin = new Padding(4, 5, 4, 5);
            TxtUserEmail.Name = "TxtUserEmail";
            TxtUserEmail.Size = new Size(384, 35);
            TxtUserEmail.TabIndex = 6;
            // 
            // LblUserPwd
            // 
            LblUserPwd.AutoSize = true;
            LblUserPwd.Location = new Point(64, 202);
            LblUserPwd.Margin = new Padding(4, 0, 4, 0);
            LblUserPwd.Name = "LblUserPwd";
            LblUserPwd.Size = new Size(153, 29);
            LblUserPwd.TabIndex = 5;
            LblUserPwd.Text = "USER_PWD:";
            // 
            // TxtUserPwd
            // 
            TxtUserPwd.Location = new Point(320, 202);
            TxtUserPwd.Margin = new Padding(4, 5, 4, 5);
            TxtUserPwd.Name = "TxtUserPwd";
            TxtUserPwd.PasswordChar = '*';
            TxtUserPwd.Size = new Size(384, 35);
            TxtUserPwd.TabIndex = 4;
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.Location = new Point(64, 123);
            LblUserName.Margin = new Padding(4, 0, 4, 0);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(167, 29);
            LblUserName.TabIndex = 3;
            LblUserName.Text = "USER_NAME:";
            // 
            // TxtUserName
            // 
            TxtUserName.Location = new Point(320, 123);
            TxtUserName.Margin = new Padding(4, 5, 4, 5);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(384, 35);
            TxtUserName.TabIndex = 2;
            // 
            // LblUserID
            // 
            LblUserID.AutoSize = true;
            LblUserID.Location = new Point(64, 45);
            LblUserID.Margin = new Padding(4, 0, 4, 0);
            LblUserID.Name = "LblUserID";
            LblUserID.Size = new Size(121, 29);
            LblUserID.TabIndex = 1;
            LblUserID.Text = "USER_ID:";
            // 
            // TxtUserID
            // 
            TxtUserID.Location = new Point(320, 45);
            TxtUserID.Margin = new Padding(4, 5, 4, 5);
            TxtUserID.Name = "TxtUserID";
            TxtUserID.Size = new Size(384, 35);
            TxtUserID.TabIndex = 0;
            // 
            // tabPageSuppliers
            // 
            tabPageSuppliers.Controls.Add(tabControlSupplier);
            tabPageSuppliers.ImageIndex = 0;
            tabPageSuppliers.Location = new Point(201, 0);
            tabPageSuppliers.Margin = new Padding(4, 5, 4, 5);
            tabPageSuppliers.Name = "tabPageSuppliers";
            tabPageSuppliers.Size = new Size(1123, 750);
            tabPageSuppliers.TabIndex = 1;
            tabPageSuppliers.Text = "Suppliers";
            tabPageSuppliers.UseVisualStyleBackColor = true;
            // 
            // tabControlSupplier
            // 
            tabControlSupplier.Controls.Add(tabPageSupplierInfo);
            tabControlSupplier.Dock = DockStyle.Fill;
            tabControlSupplier.Location = new Point(0, 0);
            tabControlSupplier.Margin = new Padding(4, 5, 4, 5);
            tabControlSupplier.Name = "tabControlSupplier";
            tabControlSupplier.SelectedIndex = 0;
            tabControlSupplier.Size = new Size(1123, 750);
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
            tabPageSupplierInfo.Location = new Point(4, 38);
            tabPageSupplierInfo.Margin = new Padding(4, 5, 4, 5);
            tabPageSupplierInfo.Name = "tabPageSupplierInfo";
            tabPageSupplierInfo.Padding = new Padding(4, 5, 4, 5);
            tabPageSupplierInfo.Size = new Size(1115, 708);
            tabPageSupplierInfo.TabIndex = 0;
            tabPageSupplierInfo.Text = "Supplier Info";
            tabPageSupplierInfo.UseVisualStyleBackColor = true;
            // 
            // uiListBox1
            // 
            uiListBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiListBox1.HoverColor = Color.FromArgb(155, 200, 255);
            uiListBox1.ItemSelectForeColor = Color.White;
            uiListBox1.Location = new Point(513, 37);
            uiListBox1.Margin = new Padding(6, 8, 6, 8);
            uiListBox1.MinimumSize = new Size(1, 2);
            uiListBox1.Name = "uiListBox1";
            uiListBox1.Padding = new Padding(3, 3, 3, 3);
            uiListBox1.ShowText = false;
            uiListBox1.Size = new Size(500, 642);
            uiListBox1.TabIndex = 10;
            uiListBox1.Text = "uiListBoxSuppliers";
            // 
            // uiBtnCommit
            // 
            uiBtnCommit.Font = new Font("Microsoft Sans Serif", 12F);
            uiBtnCommit.Location = new Point(256, 592);
            uiBtnCommit.Margin = new Padding(4, 5, 4, 5);
            uiBtnCommit.MinimumSize = new Size(1, 2);
            uiBtnCommit.Name = "uiBtnCommit";
            uiBtnCommit.Size = new Size(246, 90);
            uiBtnCommit.TabIndex = 5;
            uiBtnCommit.Text = "&Commit";
            uiBtnCommit.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiBtnCommit.Click += uiBtnCommit_Click;
            // 
            // uiTxtSubName
            // 
            uiTxtSubName.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtSubName.Location = new Point(256, 128);
            uiTxtSubName.Margin = new Padding(6, 8, 6, 8);
            uiTxtSubName.MinimumSize = new Size(1, 27);
            uiTxtSubName.Name = "uiTxtSubName";
            uiTxtSubName.Padding = new Padding(7, 8, 7, 8);
            uiTxtSubName.ShowText = false;
            uiTxtSubName.Size = new Size(246, 77);
            uiTxtSubName.TabIndex = 3;
            uiTxtSubName.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtSubName.Watermark = "";
            // 
            // uiLabelSubName
            // 
            uiLabelSubName.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabelSubName.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabelSubName.Location = new Point(21, 128);
            uiLabelSubName.Margin = new Padding(4, 0, 4, 0);
            uiLabelSubName.Name = "uiLabelSubName";
            uiLabelSubName.Size = new Size(193, 77);
            uiLabelSubName.TabIndex = 9;
            uiLabelSubName.Text = "Name:";
            // 
            // uiTxtAddress
            // 
            uiTxtAddress.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtAddress.Location = new Point(256, 502);
            uiTxtAddress.Margin = new Padding(6, 8, 6, 8);
            uiTxtAddress.MinimumSize = new Size(1, 27);
            uiTxtAddress.Name = "uiTxtAddress";
            uiTxtAddress.Padding = new Padding(7, 8, 7, 8);
            uiTxtAddress.ShowText = false;
            uiTxtAddress.Size = new Size(246, 77);
            uiTxtAddress.TabIndex = 8;
            uiTxtAddress.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtAddress.Watermark = "";
            // 
            // uiTxtEmail
            // 
            uiTxtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtEmail.Location = new Point(256, 408);
            uiTxtEmail.Margin = new Padding(6, 8, 6, 8);
            uiTxtEmail.MinimumSize = new Size(1, 27);
            uiTxtEmail.Name = "uiTxtEmail";
            uiTxtEmail.Padding = new Padding(7, 8, 7, 8);
            uiTxtEmail.ShowText = false;
            uiTxtEmail.Size = new Size(246, 77);
            uiTxtEmail.TabIndex = 7;
            uiTxtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtEmail.Watermark = "";
            // 
            // uiTxtPhone
            // 
            uiTxtPhone.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtPhone.Location = new Point(256, 315);
            uiTxtPhone.Margin = new Padding(6, 8, 6, 8);
            uiTxtPhone.MinimumSize = new Size(1, 27);
            uiTxtPhone.Name = "uiTxtPhone";
            uiTxtPhone.Padding = new Padding(7, 8, 7, 8);
            uiTxtPhone.ShowText = false;
            uiTxtPhone.Size = new Size(246, 77);
            uiTxtPhone.TabIndex = 6;
            uiTxtPhone.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtPhone.Watermark = "";
            // 
            // uiTxtContactPerson
            // 
            uiTxtContactPerson.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtContactPerson.Location = new Point(256, 222);
            uiTxtContactPerson.Margin = new Padding(6, 8, 6, 8);
            uiTxtContactPerson.MinimumSize = new Size(1, 27);
            uiTxtContactPerson.Name = "uiTxtContactPerson";
            uiTxtContactPerson.Padding = new Padding(7, 8, 7, 8);
            uiTxtContactPerson.ShowText = false;
            uiTxtContactPerson.Size = new Size(246, 77);
            uiTxtContactPerson.TabIndex = 3;
            uiTxtContactPerson.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtContactPerson.Watermark = "";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(21, 502);
            uiLabel4.Margin = new Padding(4, 0, 4, 0);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(193, 77);
            uiLabel4.TabIndex = 5;
            uiLabel4.Text = "Address:";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(26, 408);
            uiLabel3.Margin = new Padding(4, 0, 4, 0);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(189, 77);
            uiLabel3.TabIndex = 4;
            uiLabel3.Text = "Email:";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(26, 315);
            uiLabel2.Margin = new Padding(4, 0, 4, 0);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(189, 77);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "Phone:";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(26, 222);
            uiLabel1.Margin = new Padding(4, 0, 4, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(189, 77);
            uiLabel1.TabIndex = 2;
            uiLabel1.Text = "Contact Person:";
            uiLabel1.Click += uiLabel1_Click;
            // 
            // uiTxtSupID
            // 
            uiTxtSupID.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtSupID.Location = new Point(256, 37);
            uiTxtSupID.Margin = new Padding(6, 8, 6, 8);
            uiTxtSupID.MinimumSize = new Size(1, 27);
            uiTxtSupID.Name = "uiTxtSupID";
            uiTxtSupID.Padding = new Padding(7, 8, 7, 8);
            uiTxtSupID.ShowText = false;
            uiTxtSupID.Size = new Size(246, 77);
            uiTxtSupID.TabIndex = 1;
            uiTxtSupID.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtSupID.Watermark = "";
            // 
            // uiLabelSupID
            // 
            uiLabelSupID.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabelSupID.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabelSupID.Location = new Point(26, 37);
            uiLabelSupID.Margin = new Padding(4, 0, 4, 0);
            uiLabelSupID.Name = "uiLabelSupID";
            uiLabelSupID.Size = new Size(189, 77);
            uiLabelSupID.TabIndex = 0;
            uiLabelSupID.Text = "ID:";
            // 
            // tabPagePurchase
            // 
            tabPagePurchase.Controls.Add(tabControlPurchase);
            tabPagePurchase.ImageIndex = 1;
            tabPagePurchase.Location = new Point(201, 0);
            tabPagePurchase.Margin = new Padding(4, 5, 4, 5);
            tabPagePurchase.Name = "tabPagePurchase";
            tabPagePurchase.Size = new Size(1123, 750);
            tabPagePurchase.TabIndex = 0;
            tabPagePurchase.Text = "Purchase";
            tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // tabControlPurchase
            // 
            tabControlPurchase.Controls.Add(tabPagePurchaseInfo);
            tabControlPurchase.Dock = DockStyle.Fill;
            tabControlPurchase.Location = new Point(0, 0);
            tabControlPurchase.Margin = new Padding(4, 5, 4, 5);
            tabControlPurchase.Name = "tabControlPurchase";
            tabControlPurchase.SelectedIndex = 0;
            tabControlPurchase.Size = new Size(1123, 750);
            tabControlPurchase.TabIndex = 0;
            // 
            // tabPagePurchaseInfo
            // 
            tabPagePurchaseInfo.Location = new Point(4, 38);
            tabPagePurchaseInfo.Margin = new Padding(4, 5, 4, 5);
            tabPagePurchaseInfo.Name = "tabPagePurchaseInfo";
            tabPagePurchaseInfo.Padding = new Padding(4, 5, 4, 5);
            tabPagePurchaseInfo.Size = new Size(1115, 708);
            tabPagePurchaseInfo.TabIndex = 0;
            tabPagePurchaseInfo.Text = "Purchase Info";
            tabPagePurchaseInfo.UseVisualStyleBackColor = true;
            // 
            // tabPageReport
            // 
            tabPageReport.Location = new Point(201, 0);
            tabPageReport.Margin = new Padding(4, 5, 4, 5);
            tabPageReport.Name = "tabPageReport";
            tabPageReport.Size = new Size(1123, 750);
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
            // uiLabel5
            // 
            uiLabel5.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(715, 148);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(150, 34);
            uiLabel5.TabIndex = 7;
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Location = new Point(739, 287);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(245, 151);
            uiLabel6.TabIndex = 8;
            uiLabel6.Text = "uiLabel6";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 750);
            Controls.Add(uiTabControlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
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
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
    }
}