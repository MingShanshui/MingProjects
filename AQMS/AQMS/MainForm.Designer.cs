using System.Windows.Forms;

namespace AQMS
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.radialMenu1 = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem6 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem7 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.系统高级设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.监测因子设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联网传输配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.切换用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aQI日报表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aQI日报表查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.质控任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.现场质控任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.定时质控任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.质控预标识ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.质控任务查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.串口调试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.串口侦测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助支持ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用手册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ucDocmentManager1 = new AQMS.UCDocmentManager();
            this.ucDocmentManager2 = new AQMS.UCDocmentManager();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // radialMenu1
            // 
            this.radialMenu1.Manager = this.barManager1;
            this.radialMenu1.Name = "radialMenu1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barStaticItem3,
            this.barStaticItem4,
            this.barStaticItem6,
            this.barStaticItem7});
            this.barManager1.MaxItemId = 70;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem4, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem7)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barStaticItem1.Caption = "登录状态：管理员已登录";
            this.barStaticItem1.Id = 20;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem6
            // 
            this.barStaticItem6.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.barStaticItem6.Id = 32;
            this.barStaticItem6.Name = "barStaticItem6";
            this.barStaticItem6.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "Copyright © 2016 盈峰环境-宇星科技发展（深圳）有限公司";
            this.barStaticItem4.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.barStaticItem4.Id = 24;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem3.Caption = "系统时间：2016年10月20日";
            this.barStaticItem3.Id = 23;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem7
            // 
            this.barStaticItem7.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.barStaticItem7.Id = 33;
            this.barStaticItem7.Name = "barStaticItem7";
            this.barStaticItem7.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1360, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 613);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1360, 34);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 613);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1360, 0);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 613);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 57);
            this.panel1.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackgroundImage = global::AQMS.Properties.Resources.close_2;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(1304, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 27);
            this.panel4.TabIndex = 19;
            this.panel4.MouseEnter += new System.EventHandler(this.panel4_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::AQMS.Properties.Resources.min_withe;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(1268, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 27);
            this.panel3.TabIndex = 19;
            this.panel3.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::AQMS.Properties.Resources.menu;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(1232, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 27);
            this.panel2.TabIndex = 19;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "空气质量自动在线监测系统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AQMS.Properties.Resources.AQMS_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 57);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.系统设置ToolStripMenuItem,
            this.toolStripSeparator1,
            this.切换用户ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.质控任务ToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem2,
            this.检查更新ToolStripMenuItem,
            this.帮助支持ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 224);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::AQMS.Properties.Resources.user_1;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItem1.Text = "用户登录";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem1,
            this.系统高级设置ToolStripMenuItem,
            this.监测因子设置ToolStripMenuItem,
            this.联网传输配置ToolStripMenuItem});
            this.系统设置ToolStripMenuItem.Image = global::AQMS.Properties.Resources.setting_2;
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // 系统设置ToolStripMenuItem1
            // 
            this.系统设置ToolStripMenuItem1.Name = "系统设置ToolStripMenuItem1";
            this.系统设置ToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.系统设置ToolStripMenuItem1.Text = "系统参数设置";
            this.系统设置ToolStripMenuItem1.Click += new System.EventHandler(this.系统设置ToolStripMenuItem1_Click);
            // 
            // 系统高级设置ToolStripMenuItem
            // 
            this.系统高级设置ToolStripMenuItem.Name = "系统高级设置ToolStripMenuItem";
            this.系统高级设置ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.系统高级设置ToolStripMenuItem.Text = "系统高级设置";
            this.系统高级设置ToolStripMenuItem.Visible = false;
            this.系统高级设置ToolStripMenuItem.Click += new System.EventHandler(this.系统高级设置ToolStripMenuItem_Click);
            // 
            // 监测因子设置ToolStripMenuItem
            // 
            this.监测因子设置ToolStripMenuItem.Name = "监测因子设置ToolStripMenuItem";
            this.监测因子设置ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.监测因子设置ToolStripMenuItem.Text = "监测因子设置";
            this.监测因子设置ToolStripMenuItem.Click += new System.EventHandler(this.监测因子设置ToolStripMenuItem_Click);
            // 
            // 联网传输配置ToolStripMenuItem
            // 
            this.联网传输配置ToolStripMenuItem.Name = "联网传输配置ToolStripMenuItem";
            this.联网传输配置ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.联网传输配置ToolStripMenuItem.Text = "联网传输配置";
            this.联网传输配置ToolStripMenuItem.Click += new System.EventHandler(this.联网传输配置ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // 切换用户ToolStripMenuItem
            // 
            this.切换用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.历史数据查询ToolStripMenuItem,
            this.状态信息查询ToolStripMenuItem});
            this.切换用户ToolStripMenuItem.Image = global::AQMS.Properties.Resources.find_2;
            this.切换用户ToolStripMenuItem.Name = "切换用户ToolStripMenuItem";
            this.切换用户ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.切换用户ToolStripMenuItem.Text = "数据查询";
            // 
            // 历史数据查询ToolStripMenuItem
            // 
            this.历史数据查询ToolStripMenuItem.Name = "历史数据查询ToolStripMenuItem";
            this.历史数据查询ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.历史数据查询ToolStripMenuItem.Text = "历史数据查询";
            this.历史数据查询ToolStripMenuItem.Click += new System.EventHandler(this.历史数据查询ToolStripMenuItem_Click);
            // 
            // 状态信息查询ToolStripMenuItem
            // 
            this.状态信息查询ToolStripMenuItem.Name = "状态信息查询ToolStripMenuItem";
            this.状态信息查询ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.状态信息查询ToolStripMenuItem.Text = "状态信息查询";
            this.状态信息查询ToolStripMenuItem.Click += new System.EventHandler(this.状态信息查询ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aQI日报表查询ToolStripMenuItem,
            this.aQI日报表查询ToolStripMenuItem1});
            this.帮助ToolStripMenuItem.Image = global::AQMS.Properties.Resources.find_1;
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.帮助ToolStripMenuItem.Text = "AQI查询";
            // 
            // aQI日报表查询ToolStripMenuItem
            // 
            this.aQI日报表查询ToolStripMenuItem.Name = "aQI日报表查询ToolStripMenuItem";
            this.aQI日报表查询ToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.aQI日报表查询ToolStripMenuItem.Text = "AQI实时报表查询";
            this.aQI日报表查询ToolStripMenuItem.Click += new System.EventHandler(this.aQI日报表查询ToolStripMenuItem_Click);
            // 
            // aQI日报表查询ToolStripMenuItem1
            // 
            this.aQI日报表查询ToolStripMenuItem1.Name = "aQI日报表查询ToolStripMenuItem1";
            this.aQI日报表查询ToolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
            this.aQI日报表查询ToolStripMenuItem1.Text = "AQI日报表查询";
            this.aQI日报表查询ToolStripMenuItem1.Click += new System.EventHandler(this.aQI日报表查询ToolStripMenuItem1_Click);
            // 
            // 质控任务ToolStripMenuItem
            // 
            this.质控任务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.现场质控任务ToolStripMenuItem,
            this.定时质控任务ToolStripMenuItem,
            this.质控预标识ToolStripMenuItem,
            this.质控任务查询ToolStripMenuItem});
            this.质控任务ToolStripMenuItem.Image = global::AQMS.Properties.Resources.control_3;
            this.质控任务ToolStripMenuItem.Name = "质控任务ToolStripMenuItem";
            this.质控任务ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.质控任务ToolStripMenuItem.Text = "质控任务";
            // 
            // 现场质控任务ToolStripMenuItem
            // 
            this.现场质控任务ToolStripMenuItem.Name = "现场质控任务ToolStripMenuItem";
            this.现场质控任务ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.现场质控任务ToolStripMenuItem.Text = "现场质控任务";
            this.现场质控任务ToolStripMenuItem.Click += new System.EventHandler(this.现场质控任务ToolStripMenuItem_Click);
            // 
            // 定时质控任务ToolStripMenuItem
            // 
            this.定时质控任务ToolStripMenuItem.Name = "定时质控任务ToolStripMenuItem";
            this.定时质控任务ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.定时质控任务ToolStripMenuItem.Text = "定时质控任务";
            this.定时质控任务ToolStripMenuItem.Click += new System.EventHandler(this.定时质控任务ToolStripMenuItem_Click);
            // 
            // 质控预标识ToolStripMenuItem
            // 
            this.质控预标识ToolStripMenuItem.Name = "质控预标识ToolStripMenuItem";
            this.质控预标识ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.质控预标识ToolStripMenuItem.Text = "质控预标识";
            this.质控预标识ToolStripMenuItem.Click += new System.EventHandler(this.质控预标识ToolStripMenuItem_Click);
            // 
            // 质控任务查询ToolStripMenuItem
            // 
            this.质控任务查询ToolStripMenuItem.Name = "质控任务查询ToolStripMenuItem";
            this.质控任务查询ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.质控任务查询ToolStripMenuItem.Text = "质控任务查询";
            this.质控任务查询ToolStripMenuItem.Click += new System.EventHandler(this.质控任务查询ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.串口调试ToolStripMenuItem,
            this.串口侦测ToolStripMenuItem});
            this.toolStripMenuItem2.Image = global::AQMS.Properties.Resources.debug_1;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItem2.Text = "调试工具";
            this.toolStripMenuItem2.Visible = false;
            // 
            // 串口调试ToolStripMenuItem
            // 
            this.串口调试ToolStripMenuItem.Name = "串口调试ToolStripMenuItem";
            this.串口调试ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.串口调试ToolStripMenuItem.Text = "串口调试";
            this.串口调试ToolStripMenuItem.Click += new System.EventHandler(this.串口调试ToolStripMenuItem_Click);
            // 
            // 串口侦测ToolStripMenuItem
            // 
            this.串口侦测ToolStripMenuItem.Name = "串口侦测ToolStripMenuItem";
            this.串口侦测ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.串口侦测ToolStripMenuItem.Text = "串口侦测";
            this.串口侦测ToolStripMenuItem.Click += new System.EventHandler(this.串口侦测ToolStripMenuItem_Click);
            // 
            // 检查更新ToolStripMenuItem
            // 
            this.检查更新ToolStripMenuItem.Image = global::AQMS.Properties.Resources.update_1;
            this.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem";
            this.检查更新ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.检查更新ToolStripMenuItem.Text = "检查更新";
            this.检查更新ToolStripMenuItem.Click += new System.EventHandler(this.检查更新ToolStripMenuItem_Click);
            // 
            // 帮助支持ToolStripMenuItem
            // 
            this.帮助支持ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用手册ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助支持ToolStripMenuItem.Image = global::AQMS.Properties.Resources.help_1;
            this.帮助支持ToolStripMenuItem.Name = "帮助支持ToolStripMenuItem";
            this.帮助支持ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.帮助支持ToolStripMenuItem.Text = "帮助支持";
            // 
            // 使用手册ToolStripMenuItem
            // 
            this.使用手册ToolStripMenuItem.Name = "使用手册ToolStripMenuItem";
            this.使用手册ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.使用手册ToolStripMenuItem.Text = "帮助文档";
            this.使用手册ToolStripMenuItem.Click += new System.EventHandler(this.使用手册ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucDocmentManager1
            // 
            this.ucDocmentManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDocmentManager1.Location = new System.Drawing.Point(0, 0);
            this.ucDocmentManager1.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.ucDocmentManager1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucDocmentManager1.Name = "ucDocmentManager1";
            this.ucDocmentManager1.Size = new System.Drawing.Size(814, 556);
            this.ucDocmentManager1.TabIndex = 4;
            // 
            // ucDocmentManager2
            // 
            this.ucDocmentManager2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDocmentManager2.Location = new System.Drawing.Point(0, 0);
            this.ucDocmentManager2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucDocmentManager2.Name = "ucDocmentManager2";
            this.ucDocmentManager2.Size = new System.Drawing.Size(540, 556);
            this.ucDocmentManager2.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ucDocmentManager2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 556);
            this.panel5.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ucDocmentManager1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(546, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(814, 556);
            this.panel6.TabIndex = 29;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 647);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "空气质量自动在线监测系统-盈峰环境（V1.0.0.1100）";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RadialMenu radialMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraBars.BarStaticItem barStaticItem6;
        private DevExpress.XtraBars.BarStaticItem barStaticItem7;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 系统设置ToolStripMenuItem;
        private ToolStripMenuItem 切换用户ToolStripMenuItem;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private ToolStripMenuItem 质控任务ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 帮助支持ToolStripMenuItem;
        private ToolStripMenuItem 检查更新ToolStripMenuItem;
        private ToolStripMenuItem 系统设置ToolStripMenuItem1;
        private ToolStripMenuItem 系统高级设置ToolStripMenuItem;
        private ToolStripMenuItem 监测因子设置ToolStripMenuItem;
        private ToolStripMenuItem 联网传输配置ToolStripMenuItem;
        private ToolStripMenuItem 历史数据查询ToolStripMenuItem;
        private ToolStripMenuItem 状态信息查询ToolStripMenuItem;
        private ToolStripMenuItem aQI日报表查询ToolStripMenuItem;
        private ToolStripMenuItem aQI日报表查询ToolStripMenuItem1;
        private ToolStripMenuItem 现场质控任务ToolStripMenuItem;
        private ToolStripMenuItem 定时质控任务ToolStripMenuItem;
        private ToolStripMenuItem 质控预标识ToolStripMenuItem;
        private ToolStripMenuItem 质控任务查询ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem 使用手册ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ToolStripMenuItem 串口调试ToolStripMenuItem;
        private ToolStripMenuItem 串口侦测ToolStripMenuItem;
        private Timer timer1;
        private Panel panel5;
        private UCDocmentManager ucDocmentManager2;
        private UCDocmentManager ucDocmentManager1;
        private Panel panel6;
    }
}