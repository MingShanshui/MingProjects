namespace AQMSUI
{
    partial class DocmentSO2
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
            this.label_SO2_Name = new System.Windows.Forms.Label();
            this.label_SO2_Statues = new System.Windows.Forms.Label();
            this.label_SO2_Value = new System.Windows.Forms.Label();
            this.label_SO2_Unit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_SO2_Name
            // 
            this.label_SO2_Name.AutoSize = true;
            this.label_SO2_Name.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SO2_Name.Location = new System.Drawing.Point(132, 72);
            this.label_SO2_Name.Name = "label_SO2_Name";
            this.label_SO2_Name.Size = new System.Drawing.Size(77, 38);
            this.label_SO2_Name.TabIndex = 0;
            this.label_SO2_Name.Text = "SO2";
            // 
            // label_SO2_Statues
            // 
            this.label_SO2_Statues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_SO2_Statues.AutoSize = true;
            this.label_SO2_Statues.Location = new System.Drawing.Point(35, 283);
            this.label_SO2_Statues.Name = "label_SO2_Statues";
            this.label_SO2_Statues.Size = new System.Drawing.Size(67, 15);
            this.label_SO2_Statues.TabIndex = 1;
            this.label_SO2_Statues.Text = "仪器正常";
            // 
            // label_SO2_Value
            // 
            this.label_SO2_Value.AutoSize = true;
            this.label_SO2_Value.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SO2_Value.Location = new System.Drawing.Point(127, 172);
            this.label_SO2_Value.Name = "label_SO2_Value";
            this.label_SO2_Value.Size = new System.Drawing.Size(87, 28);
            this.label_SO2_Value.TabIndex = 2;
            this.label_SO2_Value.Text = "0.027";
            // 
            // label_SO2_Unit
            // 
            this.label_SO2_Unit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SO2_Unit.AutoSize = true;
            this.label_SO2_Unit.Location = new System.Drawing.Point(216, 283);
            this.label_SO2_Unit.Name = "label_SO2_Unit";
            this.label_SO2_Unit.Size = new System.Drawing.Size(92, 15);
            this.label_SO2_Unit.TabIndex = 3;
            this.label_SO2_Unit.Text = "单位：mg/m3";
            this.label_SO2_Unit.Click += new System.EventHandler(this.label_SO2_Unit_Click);
            this.label_SO2_Unit.MouseEnter += new System.EventHandler(this.label_SO2_Unit_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_SO2_Unit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 343);
            this.panel1.TabIndex = 4;
            // 
            // DocmentSO2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.label_SO2_Value);
            this.Controls.Add(this.label_SO2_Statues);
            this.Controls.Add(this.label_SO2_Name);
            this.Controls.Add(this.panel1);
            this.Name = "DocmentSO2";
            this.Size = new System.Drawing.Size(340, 343);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SO2_Name;
        private System.Windows.Forms.Label label_SO2_Statues;
        private System.Windows.Forms.Label label_SO2_Value;
        private System.Windows.Forms.Label label_SO2_Unit;
        private System.Windows.Forms.Panel panel1;
    }
}
