namespace 概率计算器
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.lblTdoll = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblForm = new System.Windows.Forms.Label();
            this.lblPct = new System.Windows.Forms.Label();
            this.cbbTdoll = new System.Windows.Forms.ComboBox();
            this.tdollBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cbbForm = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tdollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxSource = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblManpower = new System.Windows.Forms.Label();
            this.lblAmmuntion = new System.Windows.Forms.Label();
            this.lblRation = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.lblWhiteCons = new System.Windows.Forms.Label();
            this.lblFastCons = new System.Windows.Forms.Label();
            this.lblCores = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tdollBindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdollBindingSource)).BeginInit();
            this.gbxSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.Enabled = false;
            this.txtOutput.Font = new System.Drawing.Font("宋体", 14.25F);
            this.txtOutput.Location = new System.Drawing.Point(15, 61);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(115, 29);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOutput.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCal.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCal.FlatAppearance.BorderSize = 0;
            this.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCal.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCal.Location = new System.Drawing.Point(150, 60);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(100, 30);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblTdoll
            // 
            this.lblTdoll.AutoSize = true;
            this.lblTdoll.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTdoll.Location = new System.Drawing.Point(10, 110);
            this.lblTdoll.Name = "lblTdoll";
            this.lblTdoll.Size = new System.Drawing.Size(88, 26);
            this.lblTdoll.TabIndex = 7;
            this.lblTdoll.Text = "战术人形";
            this.lblTdoll.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(10, 230);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(88, 26);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "建造次数";
            this.lblTime.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblForm.Location = new System.Drawing.Point(10, 170);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(88, 26);
            this.lblForm.TabIndex = 5;
            this.lblForm.Text = "公式选择";
            this.lblForm.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lblPct
            // 
            this.lblPct.AutoSize = true;
            this.lblPct.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPct.Location = new System.Drawing.Point(10, 20);
            this.lblPct.Name = "lblPct";
            this.lblPct.Size = new System.Drawing.Size(96, 28);
            this.lblPct.TabIndex = 4;
            this.lblPct.Text = "出货概率";
            this.lblPct.Click += new System.EventHandler(this.lblPct_Click);
            // 
            // cbbTdoll
            // 
            this.cbbTdoll.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTdoll.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTdoll.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbTdoll.FormattingEnabled = true;
            this.cbbTdoll.Location = new System.Drawing.Point(117, 111);
            this.cbbTdoll.Name = "cbbTdoll";
            this.cbbTdoll.Size = new System.Drawing.Size(131, 29);
            this.cbbTdoll.TabIndex = 0;
            this.cbbTdoll.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.cbbTdoll.SelectionChangeCommitted += new System.EventHandler(this.cbbTdoll_SelectionChangeCommitted);
            this.cbbTdoll.Layout += new System.Windows.Forms.LayoutEventHandler(this.CbbTdoll_Layout);
            // 
            // tdollBindingSource1
            // 
            this.tdollBindingSource1.DataMember = "Tdoll";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTime.Location = new System.Drawing.Point(117, 231);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(131, 29);
            this.txtTime.TabIndex = 2;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // cbbForm
            // 
            this.cbbForm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbForm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbForm.BackColor = System.Drawing.Color.White;
            this.cbbForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbForm.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cbbForm.Location = new System.Drawing.Point(117, 171);
            this.cbbForm.Name = "cbbForm";
            this.cbbForm.Size = new System.Drawing.Size(131, 28);
            this.cbbForm.TabIndex = 1;
            this.cbbForm.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(565, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tdollBindingSource
            // 
            this.tdollBindingSource.DataMember = "Tdoll";
            // 
            // gbxSource
            // 
            this.gbxSource.Controls.Add(this.pictureBox8);
            this.gbxSource.Controls.Add(this.lblFastCons);
            this.gbxSource.Controls.Add(this.lblParts);
            this.gbxSource.Controls.Add(this.lblTimes);
            this.gbxSource.Controls.Add(this.lblCores);
            this.gbxSource.Controls.Add(this.lblWhiteCons);
            this.gbxSource.Controls.Add(this.lblRation);
            this.gbxSource.Controls.Add(this.lblAmmuntion);
            this.gbxSource.Controls.Add(this.lblManpower);
            this.gbxSource.Controls.Add(this.pictureBox7);
            this.gbxSource.Controls.Add(this.pictureBox6);
            this.gbxSource.Controls.Add(this.pictureBox5);
            this.gbxSource.Controls.Add(this.pictureBox4);
            this.gbxSource.Controls.Add(this.pictureBox3);
            this.gbxSource.Controls.Add(this.pictureBox2);
            this.gbxSource.Controls.Add(this.pictureBox1);
            this.gbxSource.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbxSource.Location = new System.Drawing.Point(276, 20);
            this.gbxSource.Name = "gbxSource";
            this.gbxSource.Size = new System.Drawing.Size(277, 242);
            this.gbxSource.TabIndex = 8;
            this.gbxSource.TabStop = false;
            this.gbxSource.Text = "消耗资源";
            this.gbxSource.Enter += new System.EventHandler(this.gbxSource_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(150, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(30, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(150, 76);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(30, 136);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(150, 136);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(30, 196);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // lblManpower
            // 
            this.lblManpower.AutoSize = true;
            this.lblManpower.Font = new System.Drawing.Font("宋体", 12F);
            this.lblManpower.Location = new System.Drawing.Point(71, 35);
            this.lblManpower.Name = "lblManpower";
            this.lblManpower.Size = new System.Drawing.Size(56, 16);
            this.lblManpower.TabIndex = 5;
            this.lblManpower.Text = "(null)";
            // 
            // lblAmmuntion
            // 
            this.lblAmmuntion.AutoSize = true;
            this.lblAmmuntion.Font = new System.Drawing.Font("宋体", 12F);
            this.lblAmmuntion.Location = new System.Drawing.Point(191, 35);
            this.lblAmmuntion.Name = "lblAmmuntion";
            this.lblAmmuntion.Size = new System.Drawing.Size(56, 16);
            this.lblAmmuntion.TabIndex = 5;
            this.lblAmmuntion.Text = "(null)";
            // 
            // lblRation
            // 
            this.lblRation.AutoSize = true;
            this.lblRation.Font = new System.Drawing.Font("宋体", 12F);
            this.lblRation.Location = new System.Drawing.Point(71, 90);
            this.lblRation.Name = "lblRation";
            this.lblRation.Size = new System.Drawing.Size(56, 16);
            this.lblRation.TabIndex = 5;
            this.lblRation.Text = "(null)";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("宋体", 12F);
            this.lblParts.Location = new System.Drawing.Point(191, 90);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(56, 16);
            this.lblParts.TabIndex = 5;
            this.lblParts.Text = "(null)";
            // 
            // lblWhiteCons
            // 
            this.lblWhiteCons.AutoSize = true;
            this.lblWhiteCons.Font = new System.Drawing.Font("宋体", 12F);
            this.lblWhiteCons.Location = new System.Drawing.Point(71, 150);
            this.lblWhiteCons.Name = "lblWhiteCons";
            this.lblWhiteCons.Size = new System.Drawing.Size(56, 16);
            this.lblWhiteCons.TabIndex = 5;
            this.lblWhiteCons.Text = "(null)";
            // 
            // lblFastCons
            // 
            this.lblFastCons.AutoSize = true;
            this.lblFastCons.Font = new System.Drawing.Font("宋体", 12F);
            this.lblFastCons.Location = new System.Drawing.Point(191, 150);
            this.lblFastCons.Name = "lblFastCons";
            this.lblFastCons.Size = new System.Drawing.Size(56, 16);
            this.lblFastCons.TabIndex = 5;
            this.lblFastCons.Text = "(null)";
            // 
            // lblCores
            // 
            this.lblCores.AutoSize = true;
            this.lblCores.Font = new System.Drawing.Font("宋体", 12F);
            this.lblCores.Location = new System.Drawing.Point(71, 210);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(56, 16);
            this.lblCores.TabIndex = 5;
            this.lblCores.Text = "(null)";
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Font = new System.Drawing.Font("宋体", 12F);
            this.lblTimes.Location = new System.Drawing.Point(191, 210);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(56, 16);
            this.lblTimes.TabIndex = 5;
            this.lblTimes.Text = "(null)";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(150, 196);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(40, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 6;
            this.pictureBox8.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 298);
            this.Controls.Add(this.gbxSource);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbbForm);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.cbbTdoll);
            this.Controls.Add(this.lblPct);
            this.Controls.Add(this.lblForm);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTdoll);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtOutput);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "偷渡计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tdollBindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdollBindingSource)).EndInit();
            this.gbxSource.ResumeLayout(false);
            this.gbxSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblTdoll;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Label lblPct;
        private System.Windows.Forms.ComboBox cbbTdoll;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ComboBox cbbForm;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.BindingSource tdollBindingSource;
        private System.Windows.Forms.BindingSource tdollBindingSource1;
        private System.Windows.Forms.GroupBox gbxSource;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFastCons;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.Label lblWhiteCons;
        private System.Windows.Forms.Label lblRation;
        private System.Windows.Forms.Label lblAmmuntion;
        private System.Windows.Forms.Label lblManpower;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

