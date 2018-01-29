namespace Code_Academy_project
{
    partial class AddGroupTypeForm
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
            this.btn_add_schedule = new System.Windows.Forms.Button();
            this.txt_group_type_name = new System.Windows.Forms.TextBox();
            this.cb_shedule = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupTypeGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupTypeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_schedule
            // 
            this.btn_add_schedule.Location = new System.Drawing.Point(30, 22);
            this.btn_add_schedule.Name = "btn_add_schedule";
            this.btn_add_schedule.Size = new System.Drawing.Size(152, 23);
            this.btn_add_schedule.TabIndex = 0;
            this.btn_add_schedule.Text = "New Schedule";
            this.btn_add_schedule.UseVisualStyleBackColor = true;
            this.btn_add_schedule.Click += new System.EventHandler(this.btn_add_schedule_Click);
            // 
            // txt_group_type_name
            // 
            this.txt_group_type_name.Location = new System.Drawing.Point(119, 90);
            this.txt_group_type_name.Name = "txt_group_type_name";
            this.txt_group_type_name.Size = new System.Drawing.Size(132, 20);
            this.txt_group_type_name.TabIndex = 1;
            // 
            // cb_shedule
            // 
            this.cb_shedule.FormattingEnabled = true;
            this.cb_shedule.Location = new System.Drawing.Point(119, 130);
            this.cb_shedule.Name = "cb_shedule";
            this.cb_shedule.Size = new System.Drawing.Size(132, 21);
            this.cb_shedule.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type Name";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(326, 109);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Schedule";
            // 
            // groupTypeGridView
            // 
            this.groupTypeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupTypeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.groupTypeGridView.Location = new System.Drawing.Point(33, 192);
            this.groupTypeGridView.Name = "groupTypeGridView";
            this.groupTypeGridView.Size = new System.Drawing.Size(416, 150);
            this.groupTypeGridView.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Type Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Schedule";
            this.Column2.Name = "Column2";
            // 
            // AddGroupTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 364);
            this.Controls.Add(this.groupTypeGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_shedule);
            this.Controls.Add(this.txt_group_type_name);
            this.Controls.Add(this.btn_add_schedule);
            this.Name = "AddGroupTypeForm";
            this.Text = "AddGroupTypeForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupTypeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_schedule;
        private System.Windows.Forms.TextBox txt_group_type_name;
        private System.Windows.Forms.ComboBox cb_shedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView groupTypeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}