namespace Code_Academy_project
{
    partial class AddGroupScheduleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_schedule_name = new System.Windows.Forms.TextBox();
            this.dtp_begin_time = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_end_time = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.scheduleGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule Name";
            // 
            // txt_schedule_name
            // 
            this.txt_schedule_name.Location = new System.Drawing.Point(176, 60);
            this.txt_schedule_name.Name = "txt_schedule_name";
            this.txt_schedule_name.Size = new System.Drawing.Size(152, 20);
            this.txt_schedule_name.TabIndex = 1;
            // 
            // dtp_begin_time
            // 
            this.dtp_begin_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_begin_time.Location = new System.Drawing.Point(176, 107);
            this.dtp_begin_time.Name = "dtp_begin_time";
            this.dtp_begin_time.Size = new System.Drawing.Size(85, 20);
            this.dtp_begin_time.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Begin Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Time";
            // 
            // dtp_end_time
            // 
            this.dtp_end_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_end_time.Location = new System.Drawing.Point(176, 147);
            this.dtp_end_time.Name = "dtp_end_time";
            this.dtp_end_time.Size = new System.Drawing.Size(85, 20);
            this.dtp_end_time.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(446, 102);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // scheduleGridView
            // 
            this.scheduleGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.scheduleGridView.Location = new System.Drawing.Point(65, 231);
            this.scheduleGridView.Name = "scheduleGridView";
            this.scheduleGridView.Size = new System.Drawing.Size(495, 150);
            this.scheduleGridView.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Schedule Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Begin Time";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "End Time";
            this.Column3.Name = "Column3";
            // 
            // AddGroupScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 406);
            this.Controls.Add(this.scheduleGridView);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dtp_end_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_begin_time);
            this.Controls.Add(this.txt_schedule_name);
            this.Controls.Add(this.label1);
            this.Name = "AddGroupScheduleForm";
            this.Text = "AddGroupScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_schedule_name;
        private System.Windows.Forms.DateTimePicker dtp_begin_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_end_time;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView scheduleGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}