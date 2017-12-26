using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics.CodeAnalysis;  //?
using System.Diagnostics.SymbolStore;   //?
using System.Threading;


using goodAPI;


namespace TASKMGR
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ShowMSG("changed");
            //ShowMSG(JZHQLibrary.Controls.API.SC_MOVE);
            // ShowMSG(JZHQLibrary.Controls.API.SendMessage(aa,10,true,20));
        }
        private void ShowMSG(string showStr)
        {
            MessageBox.Show(showStr);
        }
        private void ShowMSG(int I)
        {
            MessageBox.Show(I.ToString());
        }
        private void exitTaskmgrXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)   //新建一个任务
        {
             //System.Threading.
            //System.Diagnostics.Process.Start(@"D:\\1.txt");   //成功
            NewBuildTaskForm newBuildTaskForm1 = new NewBuildTaskForm();
            newBuildTaskForm1.ShowDialog();
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)   //关机命令
        {
           //
            System.Diagnostics.Process.Start(@"D:\2010.4.17\gunterTaskmgr\TASKMGR\AllCMDFiles\shutdownIn15s.dat");
           
        }

        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBuildTaskForm newBuildTaskForm = new NewBuildTaskForm();
            newBuildTaskForm.ShowDialog();
           
            //JZHQLibrary.Controls.API.ShowWindow(
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Thread.Sleep(9000);
            //Thread.Sleep(0);
        }

        private void daijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.Sleep(System.Threading.Timeout.Infinite);   //休眠无限长时间
        }

        private void restratToolStripMenuItem_Click(object sender, EventArgs e)   //重启
        {

        }
        // 关键：：：
        //获取进程/线程列表，获取资源，绘制相应的曲线和找到相应的API

    }
}
