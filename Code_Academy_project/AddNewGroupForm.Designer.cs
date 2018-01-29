namespace Code_Academy_project
{
    partial class AddNewGroupForm
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
            this.btn_add_group_types = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_group_name = new System.Windows.Forms.TextBox();
            this.cb_group_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_group_menthor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_group_teacher = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.group_startTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.GroupGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_group_types
            // 
            this.btn_add_group_types.Location = new System.Drawing.Point(38, 23);
            this.btn_add_group_types.Name = "btn_add_group_types";
            this.btn_add_group_types.Size = new System.Drawing.Size(145, 23);
            this.btn_add_group_types.TabIndex = 0;
            this.btn_add_group_types.Text = "New Group Type";
            this.btn_add_group_types.UseVisualStyleBackColor = true;
            this.btn_add_group_types.Click += new System.EventHandler(this.btn_add_group_types_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Group Name";
            // 
            // txt_group_name
            // 
            this.txt_group_name.Location = new System.Drawing.Point(149, 87);
            this.txt_group_name.Name = "txt_group_name";
            this.txt_group_name.Size = new System.Drawing.Size(145, 20);
            this.txt_group_name.TabIndex = 2;
            // 
            // cb_group_type
            // 
            this.cb_group_type.FormattingEnabled = true;
            this.cb_group_type.Location = new System.Drawing.Point(149, 129);
            this.cb_group_type.Name = "cb_group_type";
            this.cb_group_type.Size = new System.Drawing.Size(145, 21);
            this.cb_group_type.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Group Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Group Menthor";
            // 
            // cb_group_menthor
            // 
            this.cb_group_menthor.FormattingEnabled = true;
            this.cb_group_menthor.Location = new System.Drawing.Point(441, 132);
            this.cb_group_menthor.Name = "cb_group_menthor";
            this.cb_group_menthor.Size = new System.Drawing.Size(145, 21);
            this.cb_group_menthor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Group Teacher";
            // 
            // cb_group_teacher
            // 
            this.cb_group_teacher.FormattingEnabled = true;
            this.cb_group_teacher.Location = new System.Drawing.Point(440, 87);
            this.cb_group_teacher.Name = "cb_group_teacher";
            this.cb_group_teacher.Size = new System.Drawing.Size(145, 21);
            this.cb_group_teacher.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Group Start Time";
            // 
            // group_startTimePicker1
            // 
            this.group_startTimePicker1.Location = new System.Drawing.Point(173, 182);
            this.group_startTimePicker1.Name = "group_startTimePicker1";
            this.group_startTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.group_startTimePicker1.TabIndex = 10;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(272, 244);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(163, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // GroupGridView
            // 
            this.GroupGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GroupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.GroupGridView.Location = new System.Drawing.Point(54, 312);
            this.GroupGridView.Name = "GroupGridView";
            this.GroupGridView.Size = new System.Drawing.Size(622, 150);
            this.GroupGridView.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Group Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Group Teacher";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Group Menthor";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Group Type";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Group Start Time";
            this.Column5.Name = "Column5";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(272, 244);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(163, 23);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // AddNewGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 514);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.GroupGridView);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.group_startTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_group_teacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_group_menthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_group_type);
            this.Controls.Add(this.txt_group_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add_group_types);
            this.Name = "AddNewGroupForm";
            this.Text = "AddNewGroupForm";
            ((System.ComponentModel.ISupportInitialize)(this.GroupGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GroupGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.TextBox txt_group_name;
        public System.Windows.Forms.ComboBox cb_group_type;
        public System.Windows.Forms.ComboBox cb_group_menthor;
        public System.Windows.Forms.ComboBox cb_group_teacher;
        public System.Windows.Forms.DateTimePicker group_startTimePicker1;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_add_group_types;
    }
}