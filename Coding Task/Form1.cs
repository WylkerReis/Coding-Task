using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System;
using System.IO;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using System.Data;

namespace Coding_Task
{
    public partial class CodingTask : Form
    {

        public CodingTask()
        {
            InitializeComponent();
        }

        private void CodingTask_Load(object sender, EventArgs e)
        {
            Txt_Task11_File.Text = Path.GetFullPath(Path.Combine(Application.StartupPath,
                "C:\\Users\\wylke\\source\\repos1\\Coding Task\\Coding Task\\bin\\Debug\\net7.0-windows\\Docs\\Tests.txt"));
        }

        private void Btn_Task1_Click(object sender, EventArgs e)
        {
            Ctn_Intro.Visible = false;
            Ctn_Task1.Visible = true;
        }

        string username = "Admin", password = "Admin";
        private void Btn_Task1_Go_Click(object sender, EventArgs e)
        {

            if (Txt_Task1_User.Text == username && Txt_Task1_Code.Text == password)
            {
                LogUtils.LogWriter.Instance.WriteLog("INFO", "User logged in", "application");
                Txt_Task1_User.Clear();
                Txt_Task1_Code.Clear();
                Ctn_Task1_Logged.Visible = true;
            }
            else if (Txt_Task1_User.TextLength == 0 && Txt_Task1_Code.TextLength == 0)
            {
                LogUtils.LogWriter.Instance.WriteLog("WARNING", "No username or password provided", "application");
                MessageBox.Show("No Username or Password provided, please provide one and try again");
                Txt_Task1_User.Clear();
                Txt_Task1_Code.Clear();
                Txt_Task1_User.Focus();
            }
            else
            {
                LogUtils.LogWriter.Instance.WriteLog("ERROR", "Failed login attempt", "application");
                MessageBox.Show("Username or Password provided are incorrect, please try again");
                Txt_Task1_User.Clear();
                Txt_Task1_Code.Clear();
                Txt_Task1_User.Focus();
            }
        }

        private void Btn_Task1_Back_Click(object sender, EventArgs e)
        {
            Ctn_Intro.Visible = true;
            Ctn_Task1.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Username: " + username + "\n" + "Password: " + password);
            LogUtils.LogWriter.Instance.WriteLog("INFO", "Hint used", "application");

        }

        private void Btn_Task1_Logged_Home_Click(object sender, EventArgs e)
        {
            LogUtils.LogWriter.Instance.WriteLog("INFO", "Congratulations on Task 1!", "application");
            Ctn_Task1_Logged.Visible = false;
            Ctn_Intro.Visible = true;
            Ctn_Task1.Visible = false;
        }

        private void Btn_Task11_Click_1(object sender, EventArgs e)
        {
            Ctn_Intro.Visible = false;
            Ctn_Task11.Visible = true;
        }

        private void Btn_Task11_Select_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd1 = new OpenFileDialog();
            opfd1.Multiselect = false;
            opfd1.Title = "Select file";
            opfd1.InitialDirectory = @"C:\Users\wylke\source\repos1\Coding Task\Coding Task\bin\Debug\net7.0-windows\Docs";
            opfd1.Filter = "Images (*.TXT)|*.TXT|" + "Todos (*.*)|*.*";
            opfd1.CheckFileExists = true;
            opfd1.CheckPathExists = true;
            opfd1.FilterIndex = 1;

            DialogResult dr = opfd1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Txt_Task11_File.Text = opfd1.FileName;
            }
        }

        private void Btn_Task11_Open_Click(object sender, EventArgs e)
        {
            Lst_Task11.Items.Clear();
            Lbl_Task11_Occurrence.Text = "";
            Refresh();

            string[] datas = File.ReadAllLines(Txt_Task11_File.Text);
            foreach (string data in datas)
            {
                Lst_Task11.Items.Add(data);
            }
            Lbl_Task11_Occurrence.Text = Lst_Task11.Items.Count.ToString() + " ocurrences";
        }

        private void Btn_Task11_Home_Click(object sender, EventArgs e)
        {
            Ctn_Task11.Visible = false;
            Ctn_Intro.Visible = true;
        }

        private void Btn_Task2_Click(object sender, EventArgs e)
        {
            Ctn_Intro.Visible = false;
            Ctn_Task2.Visible = true;
        }

        DataTable dt = new DataTable();

        private void Btn_Task2_Add_Click(object sender, EventArgs e)
        {
            if (Txt_Task2_Product.TextLength != 0 && Txt_Task2_Price.TextLength != 0 && Txt_Task2_Stock.TextLength != 0)
            {
                this.DataGrid_Task2.Rows.Insert(0, Txt_Task2_Product.Text, Txt_Task2_Price.Text, Txt_Task2_Stock.Text);
                Txt_Task2_Product.Clear();
                Txt_Task2_Price.Clear();
                Txt_Task2_Stock.Clear();

            }
        }

        private void Btn_task2_Load_Click(object sender, EventArgs e)
        {
            Ctn_Task2.Visible = false;
            Ctn_Intro.Visible = true;
        }
    }

}