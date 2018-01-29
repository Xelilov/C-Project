namespace Code_Academy_project
{
    partial class NewTaskTypeForm
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
            this.txt_task_type_name = new System.Windows.Forms.TextBox();
            this.txt_task_type_rate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.task_typeGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.task_typeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_task_type_name
            // 
            this.txt_task_type_name.Location = new System.Drawing.Point(162, 45);
            this.txt_task_type_name.Name = "txt_task_type_name";
            this.txt_task_type_name.Size = new System.Drawing.Size(222, 20);
            this.txt_task_type_name.TabIndex = 0;
            // 
            // txt_task_type_rate
            // 
            this.txt_task_type_rate.Location = new System.Drawing.Point(162, 96);
            this.txt_task_type_rate.Name = "txt_task_type_rate";
            this.txt_task_type_rate.Size = new System.Drawing.Size(222, 20);
            this.txt_task_type_rate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task Rate";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(471, 68);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // task_typeGridView
            // 
            this.task_typeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.task_typeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.task_typeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.task_typeGridView.Location = new System.Drawing.Point(67, 185);
            this.task_typeGridView.Name = "task_typeGridView";
            this.task_typeGridView.Size = new System.Drawing.Size(529, 150);
            this.task_typeGridView.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Task Type";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Task Rate";
            this.Column2.Name = "Column2";
            // 
            // NewTaskTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 414);
            this.Controls.Add(this.task_typeGridView);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_task_type_rate);
            this.Controls.Add(this.txt_task_type_name);
            this.Name = "NewTaskTypeForm";
            this.Text = "NewTaskTypeForm";
            ((System.ComponentModel.ISupportInitialize)(this.task_typeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_task_type_name;
        private System.Windows.Forms.TextBox txt_task_type_rate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView task_typeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}