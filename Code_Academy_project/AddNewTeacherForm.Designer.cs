namespace Code_Academy_project
{
    partial class AddNewTeacherForm
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
            this.txt_teacher_name = new System.Windows.Forms.TextBox();
            this.txt_teacher_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_teacher_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_teacher_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_teacher_info = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pc_teacher_photo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_upload = new System.Windows.Forms.Button();
            this.txt_teacher_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pc_teacher_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Name";
            // 
            // txt_teacher_name
            // 
            this.txt_teacher_name.Location = new System.Drawing.Point(159, 35);
            this.txt_teacher_name.Name = "txt_teacher_name";
            this.txt_teacher_name.Size = new System.Drawing.Size(143, 20);
            this.txt_teacher_name.TabIndex = 1;
            // 
            // txt_teacher_surname
            // 
            this.txt_teacher_surname.Location = new System.Drawing.Point(159, 88);
            this.txt_teacher_surname.Name = "txt_teacher_surname";
            this.txt_teacher_surname.Size = new System.Drawing.Size(143, 20);
            this.txt_teacher_surname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teacher Surname";
            // 
            // txt_teacher_email
            // 
            this.txt_teacher_email.Location = new System.Drawing.Point(159, 143);
            this.txt_teacher_email.Name = "txt_teacher_email";
            this.txt_teacher_email.Size = new System.Drawing.Size(143, 20);
            this.txt_teacher_email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teacher Email";
            // 
            // txt_teacher_phone
            // 
            this.txt_teacher_phone.Location = new System.Drawing.Point(456, 35);
            this.txt_teacher_phone.Name = "txt_teacher_phone";
            this.txt_teacher_phone.Size = new System.Drawing.Size(143, 20);
            this.txt_teacher_phone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teacher Phone";
            // 
            // txt_teacher_info
            // 
            this.txt_teacher_info.Location = new System.Drawing.Point(159, 316);
            this.txt_teacher_info.Multiline = true;
            this.txt_teacher_info.Name = "txt_teacher_info";
            this.txt_teacher_info.Size = new System.Drawing.Size(769, 125);
            this.txt_teacher_info.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teacher Info";
            // 
            // pc_teacher_photo
            // 
            this.pc_teacher_photo.Location = new System.Drawing.Point(778, 35);
            this.pc_teacher_photo.Name = "pc_teacher_photo";
            this.pc_teacher_photo.Size = new System.Drawing.Size(150, 169);
            this.pc_teacher_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_teacher_photo.TabIndex = 10;
            this.pc_teacher_photo.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Teacher Photo";
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(825, 234);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 12;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // txt_teacher_password
            // 
            this.txt_teacher_password.Location = new System.Drawing.Point(456, 88);
            this.txt_teacher_password.Name = "txt_teacher_password";
            this.txt_teacher_password.Size = new System.Drawing.Size(143, 20);
            this.txt_teacher_password.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Teacher Password";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(456, 488);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 23);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(422, 147);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(48, 17);
            this.rb_male.TabIndex = 18;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(422, 187);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(59, 17);
            this.rb_female.TabIndex = 19;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(456, 488);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(125, 23);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // AddNewTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_teacher_password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pc_teacher_photo);
            this.Controls.Add(this.txt_teacher_info);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_teacher_phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_teacher_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_teacher_surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_teacher_name);
            this.Controls.Add(this.label1);
            this.Name = "AddNewTeacherForm";
            this.Text = "AddNewTeacherForm";
            ((System.ComponentModel.ISupportInitialize)(this.pc_teacher_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_teacher_name;
        public System.Windows.Forms.TextBox txt_teacher_surname;
        public System.Windows.Forms.TextBox txt_teacher_email;
        public System.Windows.Forms.TextBox txt_teacher_phone;
        public System.Windows.Forms.TextBox txt_teacher_info;
        public System.Windows.Forms.PictureBox pc_teacher_photo;
        public System.Windows.Forms.TextBox txt_teacher_password;
        public System.Windows.Forms.RadioButton rb_male;
        public System.Windows.Forms.RadioButton rb_female;
        public System.Windows.Forms.Button btn_upload;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_save;
    }
}