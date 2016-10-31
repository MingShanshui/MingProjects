using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace AQMS
{
    public partial class SplashScreen1 : SplashScreen
    {
        SQLOperation mSQLOper = new SQLOperation();
        SqlConnection mSQLConn;

        private Thread thread1; // 定义线程
        delegate void SetLableText(string strText); // 定义委托
        SetLableText SetText;

        public SplashScreen1()
        {
            InitializeComponent();
            mSQLConn = mSQLOper.SQLConnection();
        }

        public void InitSyetem()
        {
            this.Invoke((EventHandler)(delegate { progressBarControl1.Position = 5; }));
            Thread.Sleep(1000);
            this.Invoke((EventHandler)(delegate { progressBarControl1.Position = 20; }));
            labelControl2.Invoke(SetText, new object[] { "正在加载系统参数..." });
            this.Invoke((EventHandler)(delegate { progressBarControl1.Position = 30; }));
            if (!InitSysParams())
            {
                MessageBox.Show("无法运行，系统配置错误！", "错误！");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            this.Invoke((EventHandler)(delegate { progressBarControl1.Position = 40; }));
            Thread.Sleep(500);
            this.Invoke((EventHandler)(delegate { progressBarControl1.Position = 50; }));
            labelControl2.Invoke(SetText, new object[] { "正在加载数据库设置..." });
            this.Invoke((EventHandler)(delegate { progressBarControl1.Position = 60; }));
            if (!InitSQLConn())
            {
                MessageBox.Show("无法连接数据库，请重新配置！", "错误！");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            this.Invoke((EventHandler)(delegate { progressBarControl1.Position = 70; }));
            Thread.Sleep(500);
            this.Invoke((EventHandler)(delegate { progressBarControl1.Position = 80; }));
            ExitSQLConn();
            this.Invoke((EventHandler)(delegate { progressBarControl1.Position = 90; }));
            labelControl2.Invoke(SetText, new object[] { "加载完成" });
            this.Invoke((EventHandler)(delegate { progressBarControl1.Position = 100; }));
            labelControl2.Invoke(SetText, new object[] { "正在启动" });
            Thread.Sleep(1000);
            this.DialogResult = DialogResult.OK;
            return;
        }

        public void Form_SetLableText(string strText)
        {
            labelControl2.Text = strText;
        }

        public bool InitSQLConn()
        {
            try
            {
                mSQLConn.Open();
            }
            catch (Exception ex2)
            {
                LogToFile mDBLog = new LogToFile();
                mDBLog.WriteSysLog("数据库连接失败！");
                mDBLog.WriteDBLog(ex2.ToString());

                return false;
            }
            return true;
        }

        public bool ExitSQLConn()
        {
            try
            {
                mSQLConn.Close();
            }
            catch (Exception ex2)
            {
                LogToFile mDBLog = new LogToFile();
                mDBLog.WriteSysLog("数据库连接失败！");
                mDBLog.WriteDBLog(ex2.ToString());

                return false;
            }
            return true;
        }

        public bool InitSysParams()
        {
            string strDataPath = Application.StartupPath.ToString() + "\\data";
            if (!Directory.Exists(strDataPath))
            {
                Directory.CreateDirectory(strDataPath);
            }
            string strDataFile = strDataPath + "\\data1.bin";
            if (!File.Exists(strDataFile))
            {
                File.Create(strDataFile);
            }

            using (FileStream fs = new FileStream(strDataFile, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                if (fs.Length > 0)
                {
                    SysGlobal.m_Device = bf.Deserialize(fs) as List<Device>;
                }
            }
            return true;
        }

        private void SplashScreen1_Load(object sender, EventArgs e)
        {
            SetText = new SetLableText(Form_SetLableText); // 委托实例化

            progressBarControl1.Properties.Maximum = 100;
            progressBarControl1.Properties.Minimum = 0;
            progressBarControl1.Position = 0;//当前值
            progressBarControl1.Properties.ShowTitle = true;//是否显示数据
            progressBarControl1.Properties.PercentView = true;

            thread1 = new Thread(new ThreadStart(InitSyetem));
            thread1.Start();
        }
    }
}