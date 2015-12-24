namespace TrainTime
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_trainlist = new System.Windows.Forms.DataGridView();
            this.txt_vercode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_station_name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_GetTrainTime = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traincode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trainlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1068, 429);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_trainlist);
            this.tabPage2.Controls.Add(this.txt_vercode);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txt_station_name);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btn_GetTrainTime);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1060, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "列车时刻表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_trainlist
            // 
            this.dgv_trainlist.AllowUserToAddRows = false;
            this.dgv_trainlist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_trainlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_trainlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trainlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.traincode,
            this.level,
            this.StartStation,
            this.endStation,
            this.startTime,
            this.endTime,
            this.arrTime,
            this.depTime,
            this.stationName});
            this.dgv_trainlist.Location = new System.Drawing.Point(7, 42);
            this.dgv_trainlist.Name = "dgv_trainlist";
            this.dgv_trainlist.RowTemplate.Height = 23;
            this.dgv_trainlist.Size = new System.Drawing.Size(1043, 355);
            this.dgv_trainlist.TabIndex = 15;
            // 
            // txt_vercode
            // 
            this.txt_vercode.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.txt_vercode.Location = new System.Drawing.Point(398, 11);
            this.txt_vercode.Name = "txt_vercode";
            this.txt_vercode.Size = new System.Drawing.Size(63, 21);
            this.txt_vercode.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "验证码：";
            // 
            // txt_station_name
            // 
            this.txt_station_name.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.txt_station_name.Location = new System.Drawing.Point(241, 11);
            this.txt_station_name.Name = "txt_station_name";
            this.txt_station_name.Size = new System.Drawing.Size(100, 21);
            this.txt_station_name.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(484, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_GetTrainTime
            // 
            this.btn_GetTrainTime.Location = new System.Drawing.Point(595, 10);
            this.btn_GetTrainTime.Name = "btn_GetTrainTime";
            this.btn_GetTrainTime.Size = new System.Drawing.Size(75, 23);
            this.btn_GetTrainTime.TabIndex = 10;
            this.btn_GetTrainTime.Text = "获取";
            this.btn_GetTrainTime.UseVisualStyleBackColor = true;
            this.btn_GetTrainTime.Click += new System.EventHandler(this.btn_GetTrainTime_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 21);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "车站：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "日期：";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1060, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "……";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.Frozen = true;
            this.number.HeaderText = "序号";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 60;
            // 
            // traincode
            // 
            this.traincode.DataPropertyName = "traincode";
            this.traincode.Frozen = true;
            this.traincode.HeaderText = "车次";
            this.traincode.Name = "traincode";
            // 
            // level
            // 
            this.level.DataPropertyName = "level";
            this.level.HeaderText = "等级";
            this.level.Name = "level";
            // 
            // StartStation
            // 
            this.StartStation.DataPropertyName = "StartStation";
            this.StartStation.HeaderText = "始发站";
            this.StartStation.Name = "StartStation";
            // 
            // endStation
            // 
            this.endStation.DataPropertyName = "endStation";
            this.endStation.HeaderText = "终到站";
            this.endStation.Name = "endStation";
            // 
            // startTime
            // 
            this.startTime.DataPropertyName = "startTime";
            this.startTime.HeaderText = "出发时间";
            this.startTime.Name = "startTime";
            // 
            // endTime
            // 
            this.endTime.DataPropertyName = "endTime";
            this.endTime.HeaderText = "到达时间";
            this.endTime.Name = "endTime";
            // 
            // arrTime
            // 
            this.arrTime.DataPropertyName = "arrTime";
            this.arrTime.HeaderText = "到时";
            this.arrTime.Name = "arrTime";
            // 
            // depTime
            // 
            this.depTime.DataPropertyName = "depTime";
            this.depTime.HeaderText = "发时";
            this.depTime.Name = "depTime";
            // 
            // stationName
            // 
            this.stationName.DataPropertyName = "stationName";
            this.stationName.HeaderText = "车站";
            this.stationName.Name = "stationName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 443);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "12306列车时刻表采集";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trainlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_station_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_GetTrainTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_vercode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_trainlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn traincode;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn endStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn depTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationName;
    }
}

