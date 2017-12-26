using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TASKMGR
{
    public partial class NewBuildTaskForm : Form
    {
        public NewBuildTaskForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)   //浏览
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
             openFileDialog.ShowDialog();
             string filename=openFileDialog.FileName;
             comboBox1.Text=filename;
             openFileDialog.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(comboBox1.Text);
            ShowMSG("您确实要结束这个进程吗？这有可能导致所有数据的丢失！");   
        }

        private void button2_Click(object sender, EventArgs e)  //取消
        {
            this.Close();
        }
        private void ShowMSG(string showStr)
        {
            MessageBox.Show(showStr);
        }
    }
}
