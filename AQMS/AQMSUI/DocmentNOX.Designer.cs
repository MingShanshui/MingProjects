namespace AQMSUI
{
    partial class DocmentNOX
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_NOX = new System.Windows.Forms.Label();
            this.label_NOX_Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_NO_Name = new System.Windows.Forms.Label();
            this.label_NO2_Name = new System.Windows.Forms.Label();
            this.label_NOX_Statues = new System.Windows.Forms.Label();
            this.label_NOX_Unit = new System.Windows.Forms.Label();
            this.label_NOX_Value = new System.Windows.Forms.Label();
            this.label_NO_Value = new System.Windows.Forms.Label();
            this.label_NO2_Value = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_NOX
            // 
            this.label_NOX.AutoSize = true;
            this.label_NOX.Location = new System.Drawing.Point(144, 47);
            this.label_NOX.Name = "label_NOX";
            this.label_NOX.Size = new System.Drawing.Size(67, 15);
            this.label_NOX.TabIndex = 0;
            this.label_NOX.Text = "氮氧化物";
            // 
            // label_NOX_Name
            // 
            this.label_NOX_Name.AutoSize = true;
            this.label_NOX_Name.Location = new System.Drawing.Point(80, 114);
            this.label_NOX_Name.Name = "label_NOX_Name";
            this.label_NOX_Name.Size = new System.Drawing.Size(31, 15);
            this.label_NOX_Name.TabIndex = 1;
            this.label_NOX_Name.Text = "NOX";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label_NO2_Value);
            this.panel1.Controls.Add(this.label_NO_Value);
            this.panel1.Controls.Add(this.label_NOX_Value);
            this.panel1.Controls.Add(this.label_NOX_Unit);
            this.panel1.Controls.Add(this.label_NOX_Statues);
            this.panel1.Controls.Add(this.label_NO2_Name);
            this.panel1.Controls.Add(this.label_NO_Name);
            this.panel1.Controls.Add(this.label_NOX_Name);
            this.panel1.Controls.Add(this.label_NOX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 405);
            this.panel1.TabIndex = 2;
            // 
            // label_NO_Name
            // 
            this.label_NO_Name.AutoSize = true;
            this.label_NO_Name.Location = new System.Drawing.Point(80, 168);
            this.label_NO_Name.Name = "label_NO_Name";
            this.label_NO_Name.Size = new System.Drawing.Size(23, 15);
            this.label_NO_Name.TabIndex = 2;
            this.label_NO_Name.Text = "NO";
            // 
            // label_NO2_Name
            // 
            this.label_NO2_Name.AutoSize = true;
            this.label_NO2_Name.Location = new System.Drawing.Point(80, 222);
            this.label_NO2_Name.Name = "label_NO2_Name";
            this.label_NO2_Name.Size = new System.Drawing.Size(31, 15);
            this.label_NO2_Name.TabIndex = 3;
            this.label_NO2_Name.Text = "NO2";
            // 
            // label_NOX_Statues
            // 
            this.label_NOX_Statues.AutoSize = true;
            this.label_NOX_Statues.Location = new System.Drawing.Point(42, 324);
            this.label_NOX_Statues.Name = "label_NOX_Statues";
            this.label_NOX_Statues.Size = new System.Drawing.Size(67, 15);
            this.label_NOX_Statues.TabIndex = 4;
            this.label_NOX_Statues.Text = "仪器正常";
            // 
            // label_NOX_Unit
            // 
            this.label_NOX_Unit.AutoSize = true;
            this.label_NOX_Unit.Location = new System.Drawing.Point(228, 324);
            this.label_NOX_Unit.Name = "label_NOX_Unit";
            this.label_NOX_Unit.Size = new System.Drawing.Size(92, 15);
            this.label_NOX_Unit.TabIndex = 5;
            this.label_NOX_Unit.Text = "单位：mg/m3";
            this.label_NOX_Unit.Click += new System.EventHandler(this.label_NOX_Unit_Click);
            this.label_NOX_Unit.MouseEnter += new System.EventHandler(this.label_NOX_Unit_MouseEnter);
            // 
            // label_NOX_Value
            // 
            this.label_NOX_Value.AutoSize = true;
            this.label_NOX_Value.Location = new System.Drawing.Point(213, 114);
            this.label_NOX_Value.Name = "label_NOX_Value";
            this.label_NOX_Value.Size = new System.Drawing.Size(47, 15);
            this.label_NOX_Value.TabIndex = 6;
            this.label_NOX_Value.Text = "1.234";
            // 
            // label_NO_Value
            // 
            this.label_NO_Value.AutoSize = true;
            this.label_NO_Value.Location = new System.Drawing.Point(213, 168);
            this.label_NO_Value.Name = "label_NO_Value";
            this.label_NO_Value.Size = new System.Drawing.Size(47, 15);
            this.label_NO_Value.TabIndex = 7;
            this.label_NO_Value.Text = "2.345";
            // 
            // label_NO2_Value
            // 
            this.label_NO2_Value.AutoSize = true;
            this.label_NO2_Value.Location = new System.Drawing.Point(213, 222);
            this.label_NO2_Value.Name = "label_NO2_Value";
            this.label_NO2_Value.Size = new System.Drawing.Size(47, 15);
            this.label_NO2_Value.TabIndex = 8;
            this.label_NO2_Value.Text = "3.456";
            // 
            // DocmentNOX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DocmentNOX";
            this.Size = new System.Drawing.Size(366, 405);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_NOX;
        private System.Windows.Forms.Label label_NOX_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_NO2_Value;
        private System.Windows.Forms.Label label_NO_Value;
        private System.Windows.Forms.Label label_NOX_Value;
        private System.Windows.Forms.Label label_NOX_Unit;
        private System.Windows.Forms.Label label_NOX_Statues;
        private System.Windows.Forms.Label label_NO2_Name;
        private System.Windows.Forms.Label label_NO_Name;
    }
}
