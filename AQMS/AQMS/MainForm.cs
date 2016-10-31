using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views.Widget;

namespace AQMS
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;            
            InitDocmentManager();
        }

        public void InitDocmentManager()
        {
            #region 加载设备Docment        
            StackGroup groupGas = new StackGroup();
            StackGroup groupPM  = new StackGroup();
            StackGroup groupAir = new StackGroup();
            groupGas.Length.UnitType = LengthUnitType.Star;
            groupGas.Length.UnitValue = 4;
            groupPM.Length.UnitType = LengthUnitType.Star;
            groupPM.Length.UnitValue = 3;
            groupAir.Length.UnitType = LengthUnitType.Star;
            groupAir.Length.UnitValue = 4;
            ucDocmentManager1.AddStackGroup(groupGas);
            ucDocmentManager1.AddStackGroup(groupPM);
            ucDocmentManager1.AddStackGroup(groupAir);

            List<Document> mDocments = new List<Document>();
            if (AirDevice.m_Device != null)
            {
                for (int i = 0; i < AirDevice.m_Device.Count - 1; i++)
                {
                    Document devDocment = new Document();
                    devDocment.Caption = AirDevice.m_Device.ElementAt(i).devChName;
                    devDocment.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
                    devDocment.Properties.AllowDock = DevExpress.Utils.DefaultBoolean.False;
                    devDocment.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.False;
                    devDocment.Properties.AllowActivate = DevExpress.Utils.DefaultBoolean.False;
                    ucDocmentManager1.AddDocument(devDocment);
                    if (AirDevice.m_Device[i].devType == 1)
                    {
                        groupGas.Items.Add(devDocment);
                    }
                    else if (AirDevice.m_Device[i].devType == 2)
                    {
                        groupPM.Items.Add(devDocment);
                    }
                    else if (AirDevice.m_Device[i].devType == 3)
                    {
                        groupAir.Items.Add(devDocment);
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                Document tempDocment = new Document();
                tempDocment.Caption = "二氧化硫";
                ucDocmentManager1.AddDocument(tempDocment);
                if (i < 3)
                {
                    groupPM.Items.Add(tempDocment);                   
                }
                else if (i>=3 && i<6)
                {
                    groupGas.Items.Add(tempDocment);
                }
                else
                {
                    groupAir.Items.Add(tempDocment);
                }
            }
            #endregion

            #region 加载状态Docment
            StackGroup groupState = new StackGroup();
            groupState.Length.UnitType = LengthUnitType.Star;
            groupState.Length.UnitValue = 1;
            Document homeDocment = new Document();
            homeDocment.Caption = "系统状态";
            homeDocment.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
            homeDocment.Properties.AllowDock = DevExpress.Utils.DefaultBoolean.False;
            homeDocment.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.False;
            homeDocment.Properties.AllowActivate = DevExpress.Utils.DefaultBoolean.False;
            
                      
            Document statuesDocment = new Document();
            statuesDocment.Caption = "主页曲线";
            statuesDocment.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
            statuesDocment.Properties.AllowDock = DevExpress.Utils.DefaultBoolean.False;
            statuesDocment.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.False;
            statuesDocment.Properties.AllowActivate = DevExpress.Utils.DefaultBoolean.False;
           
            groupState.Items.AddRange(new Document[] { homeDocment, statuesDocment });           
            ucDocmentManager2.AddStackGroup(groupState);
            ucDocmentManager2.AddDocument(homeDocment);
            ucDocmentManager2.AddDocument(statuesDocment);
            #endregion


        }

        #region 系统菜单栏
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.contextMenuStrip1.Show(this.panel2, 5, 25);
            }
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            mainmenuTip.Show("主菜单", this.panel2, 5, 25);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            mainmenuTip.Hide(this.panel2);
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        { // 最小化
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            this.panel3.BackgroundImage = global::AQMS.Properties.Resources.min_red;
            minTip.Show("最小化", this.panel3, 5, 25);
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            this.panel3.BackgroundImage = global::AQMS.Properties.Resources.min_withe;
            minTip.Hide(this.panel3);
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            this.panel4.BackgroundImage = global::AQMS.Properties.Resources.close_1;
            closeTip.Show("关闭", this.panel4, 5, 25);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            this.panel4.BackgroundImage = global::AQMS.Properties.Resources.close_2;
            closeTip.Hide(this.panel4);
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        { // 退出
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要退出监测系统吗?", "AQMS", messButton);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private ToolTip mainmenuTip;
        private ToolTip minTip;
        private ToolTip closeTip;
        public void InitToolTips()
        {
            mainmenuTip = new ToolTip();
            mainmenuTip.SetToolTip(this.panel2, "主菜单");
            mainmenuTip.AutoPopDelay = 100000;
            mainmenuTip.InitialDelay = 500;
            mainmenuTip.ReshowDelay = 800;

            minTip = new ToolTip();
            minTip.SetToolTip(this.panel3, "最小化");
            minTip.AutoPopDelay = 100000;
            minTip.InitialDelay = 500;
            minTip.ReshowDelay = 800;

            closeTip = new ToolTip();
            closeTip.SetToolTip(this.panel4, "关闭");
            closeTip.AutoPopDelay = 100000;
            closeTip.InitialDelay = 500;
            closeTip.ReshowDelay = 800;
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitToolTips();
        }

        #region 系统菜单响应
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        { // 用户登录

        }

        private void 系统设置ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 系统高级设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 监测因子设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 联网传输配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 历史数据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 状态信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aQI日报表查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aQI日报表查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 现场质控任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 定时质控任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 质控预标识ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 质控任务查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 串口调试ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 串口侦测ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 检查更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 使用手册ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime nowDate = System.DateTime.Now;
            this.barStaticItem3.Caption = nowDate.ToString("yyyy-MM-dd HH:mm:ss");
            
        }
    }
}