namespace Coding_Task
{
    partial class CodingTask
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Ctn_Intro = new GroupBox();
            Lbl_Header = new Label();
            Btn_Task2 = new Button();
            Btn_Task11 = new Button();
            Btn_Task1 = new Button();
            Lbl_Intro = new Label();
            Ctn_Task1 = new GroupBox();
            label1 = new Label();
            Lbl_Task1_Intro = new Label();
            linkLabel1 = new LinkLabel();
            Btn_Task1_Go = new Button();
            Btn_Task1_Back = new Button();
            Txt_Task1_Code = new TextBox();
            Txt_Task1_User = new TextBox();
            Lbl_Task1_Code = new Label();
            Lbl_Task1_User = new Label();
            Ctn_Task1_Logged = new GroupBox();
            Btn_Task1_Logged_Home = new Button();
            Lbl_Task1_Logged = new Label();
            Ctn_Task11 = new GroupBox();
            Btn_Task11_Home = new Button();
            Btn_Task11_Open = new Button();
            label3 = new Label();
            Btn_Task11_Select_File = new Button();
            Txt_Task11_File = new TextBox();
            Lbl_Task11_Occurrence = new Label();
            Lst_Task11 = new ListBox();
            label2 = new Label();
            Ctn_Task2 = new GroupBox();
            Btn_task2_Load = new Button();
            DataGrid_Task2 = new DataGridView();
            teste = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Btn_Task2_Add = new Button();
            Lbl_Task2_Intro = new Label();
            Lbl_Task2_Stock = new Label();
            Lbl_Task2_Price = new Label();
            Lbl_Task2_Product = new Label();
            Txt_Task2_Price = new TextBox();
            Txt_Task2_Stock = new TextBox();
            Txt_Task2_Product = new TextBox();
            Lbl_Task2_Header = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Ctn_Intro.SuspendLayout();
            Ctn_Task1.SuspendLayout();
            Ctn_Task1_Logged.SuspendLayout();
            Ctn_Task11.SuspendLayout();
            Ctn_Task2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Task2).BeginInit();
            SuspendLayout();
            // 
            // Ctn_Intro
            // 
            Ctn_Intro.Controls.Add(Lbl_Header);
            Ctn_Intro.Controls.Add(Btn_Task2);
            Ctn_Intro.Controls.Add(Btn_Task11);
            Ctn_Intro.Controls.Add(Btn_Task1);
            Ctn_Intro.Controls.Add(Lbl_Intro);
            Ctn_Intro.Location = new Point(12, 22);
            Ctn_Intro.Name = "Ctn_Intro";
            Ctn_Intro.Size = new Size(448, 251);
            Ctn_Intro.TabIndex = 1;
            Ctn_Intro.TabStop = false;
            // 
            // Lbl_Header
            // 
            Lbl_Header.AutoSize = true;
            Lbl_Header.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Header.Location = new Point(75, 19);
            Lbl_Header.Name = "Lbl_Header";
            Lbl_Header.Size = new Size(295, 32);
            Lbl_Header.TabIndex = 5;
            Lbl_Header.Text = "Welcome to, Codign Task!";
            // 
            // Btn_Task2
            // 
            Btn_Task2.Location = new Point(270, 95);
            Btn_Task2.Name = "Btn_Task2";
            Btn_Task2.Size = new Size(75, 23);
            Btn_Task2.TabIndex = 4;
            Btn_Task2.Text = "Task 2";
            Btn_Task2.UseVisualStyleBackColor = true;
            Btn_Task2.Click += Btn_Task2_Click;
            // 
            // Btn_Task11
            // 
            Btn_Task11.Location = new Point(189, 95);
            Btn_Task11.Name = "Btn_Task11";
            Btn_Task11.Size = new Size(75, 23);
            Btn_Task11.TabIndex = 3;
            Btn_Task11.Text = "Task 1.1";
            Btn_Task11.UseVisualStyleBackColor = true;
            Btn_Task11.Click += Btn_Task11_Click_1;
            // 
            // Btn_Task1
            // 
            Btn_Task1.Location = new Point(108, 95);
            Btn_Task1.Name = "Btn_Task1";
            Btn_Task1.Size = new Size(75, 23);
            Btn_Task1.TabIndex = 2;
            Btn_Task1.Text = "Task 1";
            Btn_Task1.UseVisualStyleBackColor = true;
            Btn_Task1.Click += Btn_Task1_Click;
            // 
            // Lbl_Intro
            // 
            Lbl_Intro.AutoSize = true;
            Lbl_Intro.Location = new Point(134, 59);
            Lbl_Intro.Name = "Lbl_Intro";
            Lbl_Intro.Size = new Size(183, 15);
            Lbl_Intro.TabIndex = 1;
            Lbl_Intro.Text = "Feel free to select any of the tasks";
            // 
            // Ctn_Task1
            // 
            Ctn_Task1.AutoSize = true;
            Ctn_Task1.Controls.Add(label1);
            Ctn_Task1.Controls.Add(Ctn_Task1_Logged);
            Ctn_Task1.Controls.Add(Lbl_Task1_Intro);
            Ctn_Task1.Controls.Add(linkLabel1);
            Ctn_Task1.Controls.Add(Btn_Task1_Go);
            Ctn_Task1.Controls.Add(Btn_Task1_Back);
            Ctn_Task1.Controls.Add(Txt_Task1_Code);
            Ctn_Task1.Controls.Add(Txt_Task1_User);
            Ctn_Task1.Controls.Add(Lbl_Task1_Code);
            Ctn_Task1.Controls.Add(Lbl_Task1_User);
            Ctn_Task1.Location = new Point(12, 12);
            Ctn_Task1.Name = "Ctn_Task1";
            Ctn_Task1.Size = new Size(413, 247);
            Ctn_Task1.TabIndex = 5;
            Ctn_Task1.TabStop = false;
            Ctn_Task1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(110, 19);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 9;
            label1.Text = "Welcome to Task 1";
            // 
            // Lbl_Task1_Intro
            // 
            Lbl_Task1_Intro.AutoSize = true;
            Lbl_Task1_Intro.Location = new Point(94, 51);
            Lbl_Task1_Intro.Name = "Lbl_Task1_Intro";
            Lbl_Task1_Intro.Size = new Size(241, 15);
            Lbl_Task1_Intro.TabIndex = 1;
            Lbl_Task1_Intro.Text = "Please provide your username and password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(300, 73);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(35, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Hint?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Btn_Task1_Go
            // 
            Btn_Task1_Go.Location = new Point(260, 175);
            Btn_Task1_Go.Name = "Btn_Task1_Go";
            Btn_Task1_Go.Size = new Size(75, 23);
            Btn_Task1_Go.TabIndex = 7;
            Btn_Task1_Go.Text = "Confirm";
            Btn_Task1_Go.UseVisualStyleBackColor = true;
            Btn_Task1_Go.Click += Btn_Task1_Go_Click;
            // 
            // Btn_Task1_Back
            // 
            Btn_Task1_Back.Location = new Point(94, 175);
            Btn_Task1_Back.Name = "Btn_Task1_Back";
            Btn_Task1_Back.Size = new Size(75, 23);
            Btn_Task1_Back.TabIndex = 6;
            Btn_Task1_Back.Text = "Back";
            Btn_Task1_Back.UseVisualStyleBackColor = true;
            Btn_Task1_Back.Click += Btn_Task1_Back_Click;
            // 
            // Txt_Task1_Code
            // 
            Txt_Task1_Code.Location = new Point(94, 135);
            Txt_Task1_Code.Name = "Txt_Task1_Code";
            Txt_Task1_Code.Size = new Size(241, 23);
            Txt_Task1_Code.TabIndex = 5;
            // 
            // Txt_Task1_User
            // 
            Txt_Task1_User.Location = new Point(94, 91);
            Txt_Task1_User.Name = "Txt_Task1_User";
            Txt_Task1_User.Size = new Size(241, 23);
            Txt_Task1_User.TabIndex = 4;
            // 
            // Lbl_Task1_Code
            // 
            Lbl_Task1_Code.AutoSize = true;
            Lbl_Task1_Code.Location = new Point(94, 117);
            Lbl_Task1_Code.Name = "Lbl_Task1_Code";
            Lbl_Task1_Code.Size = new Size(60, 15);
            Lbl_Task1_Code.TabIndex = 3;
            Lbl_Task1_Code.Text = "Password:";
            // 
            // Lbl_Task1_User
            // 
            Lbl_Task1_User.AutoSize = true;
            Lbl_Task1_User.Location = new Point(94, 73);
            Lbl_Task1_User.Name = "Lbl_Task1_User";
            Lbl_Task1_User.Size = new Size(63, 15);
            Lbl_Task1_User.TabIndex = 2;
            Lbl_Task1_User.Text = "Username:";
            // 
            // Ctn_Task1_Logged
            // 
            Ctn_Task1_Logged.Controls.Add(Btn_Task1_Logged_Home);
            Ctn_Task1_Logged.Controls.Add(Lbl_Task1_Logged);
            Ctn_Task1_Logged.Location = new Point(17, 49);
            Ctn_Task1_Logged.Name = "Ctn_Task1_Logged";
            Ctn_Task1_Logged.Size = new Size(373, 176);
            Ctn_Task1_Logged.TabIndex = 6;
            Ctn_Task1_Logged.TabStop = false;
            Ctn_Task1_Logged.Visible = false;
            // 
            // Btn_Task1_Logged_Home
            // 
            Btn_Task1_Logged_Home.Location = new Point(146, 134);
            Btn_Task1_Logged_Home.Name = "Btn_Task1_Logged_Home";
            Btn_Task1_Logged_Home.Size = new Size(75, 23);
            Btn_Task1_Logged_Home.TabIndex = 1;
            Btn_Task1_Logged_Home.Text = "Home";
            Btn_Task1_Logged_Home.UseVisualStyleBackColor = true;
            Btn_Task1_Logged_Home.Click += Btn_Task1_Logged_Home_Click;
            // 
            // Lbl_Task1_Logged
            // 
            Lbl_Task1_Logged.AutoSize = true;
            Lbl_Task1_Logged.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Task1_Logged.Location = new Point(8, 65);
            Lbl_Task1_Logged.Name = "Lbl_Task1_Logged";
            Lbl_Task1_Logged.Size = new Size(359, 30);
            Lbl_Task1_Logged.TabIndex = 0;
            Lbl_Task1_Logged.Text = "Congratulations, you finshed task 1 !";
            // 
            // Ctn_Task11
            // 
            Ctn_Task11.Controls.Add(Btn_Task11_Home);
            Ctn_Task11.Controls.Add(Btn_Task11_Open);
            Ctn_Task11.Controls.Add(label3);
            Ctn_Task11.Controls.Add(Btn_Task11_Select_File);
            Ctn_Task11.Controls.Add(Txt_Task11_File);
            Ctn_Task11.Controls.Add(Lbl_Task11_Occurrence);
            Ctn_Task11.Controls.Add(Lst_Task11);
            Ctn_Task11.Controls.Add(label2);
            Ctn_Task11.Location = new Point(12, 12);
            Ctn_Task11.Name = "Ctn_Task11";
            Ctn_Task11.Size = new Size(448, 315);
            Ctn_Task11.TabIndex = 7;
            Ctn_Task11.TabStop = false;
            Ctn_Task11.Visible = false;
            // 
            // Btn_Task11_Home
            // 
            Btn_Task11_Home.Location = new Point(6, 110);
            Btn_Task11_Home.Name = "Btn_Task11_Home";
            Btn_Task11_Home.Size = new Size(75, 23);
            Btn_Task11_Home.TabIndex = 15;
            Btn_Task11_Home.Text = "Home";
            Btn_Task11_Home.UseVisualStyleBackColor = true;
            Btn_Task11_Home.Click += Btn_Task11_Home_Click;
            // 
            // Btn_Task11_Open
            // 
            Btn_Task11_Open.Location = new Point(361, 111);
            Btn_Task11_Open.Name = "Btn_Task11_Open";
            Btn_Task11_Open.Size = new Size(75, 23);
            Btn_Task11_Open.TabIndex = 14;
            Btn_Task11_Open.Text = "Open";
            Btn_Task11_Open.UseVisualStyleBackColor = true;
            Btn_Task11_Open.Click += Btn_Task11_Open_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 51);
            label3.Name = "label3";
            label3.Size = new Size(174, 15);
            label3.TabIndex = 13;
            label3.Text = "Search the file and then open it!";
            // 
            // Btn_Task11_Select_File
            // 
            Btn_Task11_Select_File.Location = new Point(361, 81);
            Btn_Task11_Select_File.Name = "Btn_Task11_Select_File";
            Btn_Task11_Select_File.Size = new Size(75, 23);
            Btn_Task11_Select_File.TabIndex = 12;
            Btn_Task11_Select_File.Text = "Search";
            Btn_Task11_Select_File.UseVisualStyleBackColor = true;
            Btn_Task11_Select_File.Click += Btn_Task11_Select_File_Click;
            // 
            // Txt_Task11_File
            // 
            Txt_Task11_File.Location = new Point(0, 81);
            Txt_Task11_File.Name = "Txt_Task11_File";
            Txt_Task11_File.ReadOnly = true;
            Txt_Task11_File.Size = new Size(355, 23);
            Txt_Task11_File.TabIndex = 11;
            // 
            // Lbl_Task11_Occurrence
            // 
            Lbl_Task11_Occurrence.AutoSize = true;
            Lbl_Task11_Occurrence.Location = new Point(6, 297);
            Lbl_Task11_Occurrence.Name = "Lbl_Task11_Occurrence";
            Lbl_Task11_Occurrence.Size = new Size(0, 15);
            Lbl_Task11_Occurrence.TabIndex = 8;
            // 
            // Lst_Task11
            // 
            Lst_Task11.FormattingEnabled = true;
            Lst_Task11.ItemHeight = 15;
            Lst_Task11.Location = new Point(0, 140);
            Lst_Task11.Name = "Lst_Task11";
            Lst_Task11.Size = new Size(436, 154);
            Lst_Task11.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(86, 19);
            label2.Name = "label2";
            label2.Size = new Size(231, 32);
            label2.TabIndex = 10;
            label2.Text = "Welcome to Task 1.1";
            // 
            // Ctn_Task2
            // 
            Ctn_Task2.Controls.Add(Btn_task2_Load);
            Ctn_Task2.Controls.Add(DataGrid_Task2);
            Ctn_Task2.Controls.Add(Btn_Task2_Add);
            Ctn_Task2.Controls.Add(Lbl_Task2_Intro);
            Ctn_Task2.Controls.Add(Lbl_Task2_Stock);
            Ctn_Task2.Controls.Add(Lbl_Task2_Price);
            Ctn_Task2.Controls.Add(Lbl_Task2_Product);
            Ctn_Task2.Controls.Add(Txt_Task2_Price);
            Ctn_Task2.Controls.Add(Txt_Task2_Stock);
            Ctn_Task2.Controls.Add(Txt_Task2_Product);
            Ctn_Task2.Controls.Add(Lbl_Task2_Header);
            Ctn_Task2.Location = new Point(18, 0);
            Ctn_Task2.Name = "Ctn_Task2";
            Ctn_Task2.Size = new Size(403, 347);
            Ctn_Task2.TabIndex = 8;
            Ctn_Task2.TabStop = false;
            Ctn_Task2.Visible = false;
            // 
            // Btn_task2_Load
            // 
            Btn_task2_Load.Location = new Point(210, 137);
            Btn_task2_Load.Name = "Btn_task2_Load";
            Btn_task2_Load.Size = new Size(104, 38);
            Btn_task2_Load.TabIndex = 27;
            Btn_task2_Load.Text = "Home";
            Btn_task2_Load.UseVisualStyleBackColor = true;
            Btn_task2_Load.Click += Btn_task2_Load_Click;
            // 
            // DataGrid_Task2
            // 
            DataGrid_Task2.AllowUserToOrderColumns = true;
            DataGrid_Task2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid_Task2.Columns.AddRange(new DataGridViewColumn[] { teste, Price, Stock });
            DataGrid_Task2.Location = new Point(12, 197);
            DataGrid_Task2.Name = "DataGrid_Task2";
            DataGrid_Task2.RowTemplate.Height = 25;
            DataGrid_Task2.Size = new Size(391, 150);
            DataGrid_Task2.TabIndex = 26;
            // 
            // teste
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            teste.DefaultCellStyle = dataGridViewCellStyle1;
            teste.HeaderText = "Product";
            teste.Name = "teste";
            // 
            // Price
            // 
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Price.DefaultCellStyle = dataGridViewCellStyle2;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Stock
            // 
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Stock.DefaultCellStyle = dataGridViewCellStyle3;
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // Btn_Task2_Add
            // 
            Btn_Task2_Add.Location = new Point(210, 94);
            Btn_Task2_Add.Name = "Btn_Task2_Add";
            Btn_Task2_Add.Size = new Size(104, 38);
            Btn_Task2_Add.TabIndex = 24;
            Btn_Task2_Add.Text = "Add";
            Btn_Task2_Add.UseVisualStyleBackColor = true;
            Btn_Task2_Add.Click += Btn_Task2_Add_Click;
            // 
            // Lbl_Task2_Intro
            // 
            Lbl_Task2_Intro.AutoSize = true;
            Lbl_Task2_Intro.Location = new Point(104, 51);
            Lbl_Task2_Intro.Name = "Lbl_Task2_Intro";
            Lbl_Task2_Intro.Size = new Size(186, 15);
            Lbl_Task2_Intro.TabIndex = 23;
            Lbl_Task2_Intro.Text = "Please, inform as requested below";
            // 
            // Lbl_Task2_Stock
            // 
            Lbl_Task2_Stock.AutoSize = true;
            Lbl_Task2_Stock.Location = new Point(64, 155);
            Lbl_Task2_Stock.Name = "Lbl_Task2_Stock";
            Lbl_Task2_Stock.Size = new Size(39, 15);
            Lbl_Task2_Stock.TabIndex = 22;
            Lbl_Task2_Stock.Text = "Stock:";
            // 
            // Lbl_Task2_Price
            // 
            Lbl_Task2_Price.AutoSize = true;
            Lbl_Task2_Price.Location = new Point(64, 126);
            Lbl_Task2_Price.Name = "Lbl_Task2_Price";
            Lbl_Task2_Price.Size = new Size(36, 15);
            Lbl_Task2_Price.TabIndex = 21;
            Lbl_Task2_Price.Text = "Price:";
            // 
            // Lbl_Task2_Product
            // 
            Lbl_Task2_Product.AutoSize = true;
            Lbl_Task2_Product.Location = new Point(48, 97);
            Lbl_Task2_Product.Name = "Lbl_Task2_Product";
            Lbl_Task2_Product.Size = new Size(52, 15);
            Lbl_Task2_Product.TabIndex = 20;
            Lbl_Task2_Product.Text = "Product:";
            // 
            // Txt_Task2_Price
            // 
            Txt_Task2_Price.Location = new Point(104, 123);
            Txt_Task2_Price.Name = "Txt_Task2_Price";
            Txt_Task2_Price.Size = new Size(100, 23);
            Txt_Task2_Price.TabIndex = 19;
            // 
            // Txt_Task2_Stock
            // 
            Txt_Task2_Stock.Location = new Point(104, 152);
            Txt_Task2_Stock.Name = "Txt_Task2_Stock";
            Txt_Task2_Stock.Size = new Size(100, 23);
            Txt_Task2_Stock.TabIndex = 18;
            // 
            // Txt_Task2_Product
            // 
            Txt_Task2_Product.Location = new Point(104, 94);
            Txt_Task2_Product.Name = "Txt_Task2_Product";
            Txt_Task2_Product.Size = new Size(100, 23);
            Txt_Task2_Product.TabIndex = 17;
            // 
            // Lbl_Task2_Header
            // 
            Lbl_Task2_Header.AutoSize = true;
            Lbl_Task2_Header.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Task2_Header.ForeColor = Color.Black;
            Lbl_Task2_Header.Location = new Point(88, 19);
            Lbl_Task2_Header.Name = "Lbl_Task2_Header";
            Lbl_Task2_Header.Size = new Size(218, 32);
            Lbl_Task2_Header.TabIndex = 16;
            Lbl_Task2_Header.Text = "Welcome to Task 2";
            // 
            // CodingTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1053, 1061);
            Controls.Add(Ctn_Task2);
            Controls.Add(Ctn_Task1);
            Controls.Add(Ctn_Task11);
            Controls.Add(Ctn_Intro);
            Name = "CodingTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coding Task";
            Load += CodingTask_Load;
            Ctn_Intro.ResumeLayout(false);
            Ctn_Intro.PerformLayout();
            Ctn_Task1.ResumeLayout(false);
            Ctn_Task1.PerformLayout();
            Ctn_Task1_Logged.ResumeLayout(false);
            Ctn_Task1_Logged.PerformLayout();
            Ctn_Task11.ResumeLayout(false);
            Ctn_Task11.PerformLayout();
            Ctn_Task2.ResumeLayout(false);
            Ctn_Task2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Task2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox Ctn_Intro;
        private Label Lbl_Intro;
        private Button Btn_Task2;
        private Button Btn_Task11;
        private Button Btn_Task1;
        private GroupBox Ctn_Task1;
        private Label Lbl_Task1_Code;
        private Label Lbl_Task1_User;
        private Label Lbl_Task1_Intro;
        private Button Btn_Task1_Go;
        private Button Btn_Task1_Back;
        private TextBox Txt_Task1_Code;
        private TextBox Txt_Task1_User;
        private Label Lbl_Header;
        private LinkLabel linkLabel1;
        private GroupBox Ctn_Task1_Logged;
        private Button Btn_Task1_Logged_Home;
        private Label Lbl_Task1_Logged;
        private Label label1;
        private GroupBox Ctn_Task11;
        private Label label2;
        private TreeView treeView1;
        private ListBox Lst_Task11;
        private Label Lbl_Task11_Occurrence;
        private TextBox Txt_Task11_File;
        private Button Btn_Task11_Select_File;
        private Button Btn_Task11_Open;
        private Label label3;
        private Button Btn_Task11_Home;
        private GroupBox Ctn_Task2;
        private Label Lbl_Task2_Product;
        private TextBox Txt_Task2_Price;
        private TextBox Txt_Task2_Stock;
        private TextBox Txt_Task2_Product;
        private Label Lbl_Task2_Header;
        private Label Lbl_Task2_Intro;
        private Label Lbl_Task2_Stock;
        private Label Lbl_Task2_Price;
        private Button Btn_Task2_Add;
        private DataGridView DataGrid_Task2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Btn_task2_Load;
        private DataGridViewTextBoxColumn teste;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Stock;
    }
}