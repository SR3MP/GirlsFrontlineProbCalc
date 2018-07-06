using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;
//using System.Data.OleDb;


namespace 概率计算器
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "请选择人形";
            this.CenterToScreen();
            string connectionStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Tdoll-rate.mdb";
            // 最开始只是随便填了个access表格，以后看心情做数据库
            using (OleDbConnection con = new OleDbConnection(connectionStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    con.Open();
                    cmd.CommandText = string.Format("select Tdoll from Tdoll");
                    cmd.Connection = con;
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbbTdoll.Items.Add(reader[0]);
                        }
                    }
                    con.Close();
                }
            }
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cbbForm.Text.Length == 0 || cbbTdoll.Text.Length == 0 || txtTime.Text.Length == 0 )
            {
                MessageBox.Show("请正确选择人形/公式并正确填写建造次数","错误");
                // 只设计了未输入值的情形下的报错，不知道该怎么设计使第一个combobox中的值只能为显示值。
                // 测试后发现因为cbbTdoll控制cbbForm，cbbTdoll输入错误时，cbbForm只能为空，解决了问题。
            }
            else
            {
                string SelectedTdoll = cbbTdoll.Text;
                string SelectedForm = cbbForm.Text;
                int t = int.Parse(txtTime.Text);
                // 初学者的穷举法 下面是普建
                if (SelectedForm == "30/30/30/30")
                {
                    lblManpower.Text = (t * 30).ToString();
                    lblAmmuntion.Text = (t * 30).ToString();
                    lblRation.Text = (t * 30).ToString();
                    lblParts.Text = (t * 30).ToString();
                    lblWhiteCons.Text = (t * 1).ToString();
                    lblFastCons.Text = (t * 1).ToString();
                    lblCores.Text = (t * 0).ToString();
                }
                else if (SelectedForm == "130/130/130/130")
                {
                    lblManpower.Text = (t * 130).ToString();
                    lblAmmuntion.Text = (t * 130).ToString();
                    lblRation.Text = (t * 130).ToString();
                    lblParts.Text = (t * 130).ToString();
                    lblWhiteCons.Text = (t * 1).ToString();
                    lblFastCons.Text = (t * 1).ToString();
                    lblCores.Text = (t * 0).ToString();
                }
                else if (SelectedForm == "170/160/160/30")
                {
                    lblManpower.Text = (t * 170).ToString();
                    lblAmmuntion.Text = (t * 160).ToString();
                    lblRation.Text = (t * 130).ToString();
                    lblParts.Text = (t * 30).ToString();
                    lblWhiteCons.Text = (t * 1).ToString();
                    lblFastCons.Text = (t * 1).ToString();
                    lblCores.Text = (t * 0).ToString();
                }
                else if (SelectedForm == "430/430/430/230")
                {
                    lblManpower.Text = (t * 430).ToString();
                    lblAmmuntion.Text = (t * 430).ToString();
                    lblRation.Text = (t * 430).ToString();
                    lblParts.Text = (t * 230).ToString();
                    lblWhiteCons.Text = (t * 1).ToString();
                    lblFastCons.Text = (t * 1).ToString();
                    lblCores.Text = (t * 0).ToString();
                }
                else if (SelectedForm == "430/430/130/230")
                {
                    lblManpower.Text = (t * 430).ToString();
                    lblAmmuntion.Text = (t * 430).ToString();
                    lblRation.Text = (t * 130).ToString();
                    lblParts.Text = (t * 230).ToString();
                    lblWhiteCons.Text = (t * 1).ToString();
                    lblFastCons.Text = (t * 1).ToString();
                    lblCores.Text = (t * 0).ToString();
                }
                else if (SelectedForm == "430/130/430/230")
                {
                    lblManpower.Text = (t * 430).ToString();
                    lblAmmuntion.Text = (t * 130).ToString();
                    lblRation.Text = (t * 430).ToString();
                    lblParts.Text = (t * 230).ToString();
                    lblWhiteCons.Text = (t * 1).ToString();
                    lblFastCons.Text = (t * 1).ToString();
                    lblCores.Text = (t * 0).ToString();
                }
                else if (SelectedForm == "97/404/404/97")
                {
                    lblManpower.Text = (t * 96).ToString();
                    lblAmmuntion.Text = (t * 404).ToString();
                    lblRation.Text = (t * 404).ToString();
                    lblParts.Text = (t * 97).ToString();
                    lblWhiteCons.Text = (t * 1).ToString();
                    lblFastCons.Text = (t * 1).ToString();
                    lblCores.Text = (t * 0).ToString();
                }
                else if (SelectedForm == "130/430/430/230")
                {
                    lblManpower.Text = (t * 130).ToString();
                    lblAmmuntion.Text = (t * 430).ToString();
                    lblRation.Text = (t * 430).ToString();
                    lblParts.Text = (t * 230).ToString();
                    lblWhiteCons.Text = (t * 1).ToString();
                    lblFastCons.Text = (t * 1).ToString();
                    lblCores.Text = (t * 0).ToString();
                }
                else if (SelectedForm == "730/630/130/430")
                {
                    lblManpower.Text = (t * 730).ToString();
                    lblAmmuntion.Text = (t * 630).ToString();
                    lblRation.Text = (t * 130).ToString();
                    lblParts.Text = (t * 430).ToString();
                    lblWhiteCons.Text = (t * 1).ToString();
                    lblFastCons.Text = (t * 1).ToString();
                    lblCores.Text = (t * 0).ToString();
                }
                // 大建
                else if (SelectedForm == "6264-1")
                {
                    lblManpower.Text = (t * 6000).ToString();
                    lblAmmuntion.Text = (t * 2000).ToString();
                    lblRation.Text = (t * 6000).ToString();
                    lblParts.Text = (t * 4000).ToString();
                    lblWhiteCons.Text = (t * 1).ToString();
                    lblFastCons.Text = (t * 10).ToString();
                    lblCores.Text = (t * 3).ToString();
                }
                else if (SelectedForm == "6264-2")
                {
                    lblManpower.Text = (t * 6000).ToString();
                    lblAmmuntion.Text = (t * 2000).ToString();
                    lblRation.Text = (t * 6000).ToString();
                    lblParts.Text = (t * 4000).ToString();
                    lblWhiteCons.Text = (t * 20).ToString();
                    lblFastCons.Text = (t * 10).ToString();
                    lblCores.Text = (t * 5).ToString();
                }
                else if (SelectedForm == "6264-3")
                {
                    lblManpower.Text = (t * 6000).ToString();
                    lblAmmuntion.Text = (t * 2000).ToString();
                    lblRation.Text = (t * 6000).ToString();
                    lblParts.Text = (t * 4000).ToString();
                    lblWhiteCons.Text = (t * 50).ToString();
                    lblFastCons.Text = (t * 10).ToString();
                    lblCores.Text = (t * 10).ToString();
                }
                else if (SelectedForm == "6664-1")
                {
                    lblManpower.Text = (t * 6000).ToString();
                    lblAmmuntion.Text = (t * 6000).ToString();
                    lblRation.Text = (t * 6000).ToString();
                    lblParts.Text = (t * 4000).ToString();
                    lblWhiteCons.Text = (t * 1).ToString();
                    lblFastCons.Text = (t * 10).ToString();
                    lblCores.Text = (t * 3).ToString();
                }
                else if (SelectedForm == "6664-2")
                {
                    lblManpower.Text = (t * 6000).ToString();
                    lblAmmuntion.Text = (t * 6000).ToString();
                    lblRation.Text = (t * 6000).ToString();
                    lblParts.Text = (t * 4000).ToString();
                    lblWhiteCons.Text = (t * 20).ToString();
                    lblFastCons.Text = (t * 10).ToString();
                    lblCores.Text = (t * 5).ToString();
                }
                else if (SelectedForm == "6664-3")
                {
                    lblManpower.Text = (t * 6000).ToString();
                    lblAmmuntion.Text = (t * 6000).ToString();
                    lblRation.Text = (t * 6000).ToString();
                    lblParts.Text = (t * 4000).ToString();
                    lblWhiteCons.Text = (t * 50).ToString();
                    lblFastCons.Text = (t * 10).ToString();
                    lblCores.Text = (t * 10).ToString();
                }
                else if (SelectedForm == "4163-1")
                {
                    lblManpower.Text = (t * 4000).ToString();
                    lblAmmuntion.Text = (t * 1000).ToString();
                    lblRation.Text = (t * 6000).ToString();
                    lblParts.Text = (t * 3000).ToString();
                    lblWhiteCons.Text = (t * 1).ToString();
                    lblFastCons.Text = (t * 10).ToString();
                    lblCores.Text = (t * 3).ToString();
                }
                else if (SelectedForm == "4163-2")
                {
                    lblManpower.Text = (t * 4000).ToString();
                    lblAmmuntion.Text = (t * 1000).ToString();
                    lblRation.Text = (t * 6000).ToString();
                    lblParts.Text = (t * 3000).ToString();
                    lblWhiteCons.Text = (t * 20).ToString();
                    lblFastCons.Text = (t * 10).ToString();
                    lblCores.Text = (t * 5).ToString();
                }
                else if (SelectedForm == "4163-3")
                {
                    lblManpower.Text = (t * 4000).ToString();
                    lblAmmuntion.Text = (t * 1000).ToString();
                    lblRation.Text = (t * 6000).ToString();
                    lblParts.Text = (t * 3000).ToString();
                    lblWhiteCons.Text = (t * 50).ToString();
                    lblFastCons.Text = (t * 10).ToString();
                    lblCores.Text = (t * 10).ToString();
                }

                string connectionStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Tdoll-rate.mdb";
                using (OleDbConnection con = new OleDbConnection(connectionStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        con.Open();
                        cmd.CommandText = string.Format("SELECT Rate FROM Rate where Tdoll='" + SelectedTdoll + "' and Form='" + SelectedForm + "'");
                        cmd.Connection = con;
                        string rto = cmd.ExecuteScalar().ToString();
                        float p;
                        p = float.Parse(rto);
                        float n;
                        n = 1 - p;
                        int c;
                        c = int.Parse(txtTime.Text);
                        double d;
                        d = Math.Pow(n, c);
                        double f;
                        f = 1 - d;
                        float x;
                        x = float.Parse(f.ToString());
                        txtOutput.Text = x * 100 + "%";
                        // 太菜了，定义了一串数字，数值在转换中有损失，只能精确到三位小数
                        cmd.CommandText = string.Format("select ProduceTime From Tdoll wherE Tdoll='" + SelectedTdoll + "'");
                        lblTimes.Text = cmd.ExecuteScalar().ToString();
                        con.Close();
                    }
                }
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedTdoll = cbbTdoll.Text;
            string SelectedForm = cbbForm.Text;
            string connectionStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Tdoll-rate.mdb";
            using (OleDbConnection con = new OleDbConnection(connectionStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    con.Open();
                    cmd.CommandText = string.Format("SELECT Rate FROM Rate where Tdoll='" + SelectedTdoll + "' and Form='" + SelectedForm + "'");
                    cmd.Connection = con;
                    string rto = cmd.ExecuteScalar().ToString();
                    float p;
                    p = float.Parse(rto);
                    toolStripStatusLabel1.Text = "当前公式出货率：" + p * 100 + "%";
                    con.Close();
                }
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedTdoll = cbbTdoll.Text;
            cbbForm.Items.Clear();
            string connectionStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Tdoll-rate.mdb";
            using (OleDbConnection con = new OleDbConnection(connectionStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    con.Open();
                    cmd.CommandText = string.Format("SELECT Form FROM Rate where Tdoll='"+ SelectedTdoll+"'");
                    cmd.Connection = con;
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbbForm.Items.Add(reader[0]);
                        }
                    }
                    con.Close();
                }
            }
            toolStripStatusLabel1.Text = "请选择公式";
        }

        private void CbbTdoll_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbbTdoll_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPct_Click(object sender, EventArgs e)
        {

        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            // 检测输入是否为数字，懒得设计检测第一行的错误，太麻烦，直接让第二个combobox禁止输入
        }

        private void gbxSource_Enter(object sender, EventArgs e)
        {

        }
    }
}

