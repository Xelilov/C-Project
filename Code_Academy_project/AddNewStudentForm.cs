using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Academy_project
{
    public partial class AddNewStudentForm : Form
    {
        AdminPanelForm BackStudent = null;
        Code_AcademyEntities db = new Code_AcademyEntities();
        OpenFileDialog file = new OpenFileDialog();
        public int id;
        public AddNewStudentForm(AdminPanelForm adm)
        {
            InitializeComponent();
            BackStudent = adm;
            student_combo();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            pc_student_photo.Image = Image.FromFile(file.FileName);
        }

        private void student_combo()
        {
            foreach (var g_item in db.Groups)
            {
                combo_student_gr.Items.Add(g_item.group_name);
            }            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string image = DateTime.Now.ToString("yyyyMMddhhssmm") + file.SafeFileName;

            WebClient foto = new WebClient();

            Student new_student = new Student();
            new_student.student_surname = txt_student_surname.Text;
            new_student.student_name = txt_student_name.Text;
            new_student.student_email = txt_student_email.Text;
            new_student.student_phone = txt_student_phone.Text;
            new_student.student_github_account = txt_student_github.Text;
            new_student.student_info = txt_student_info.Text;
            new_student.student_photo = image;
            new_student.student_cap_point = Convert.ToInt32(txt_student_cap.Text);
            new_student.student_password = txt_student_password.Text;

            rb_student_male.Name = db.Genders.FirstOrDefault(g => g.gender_name == rb_student_male.Text).id.ToString();
            rb_student_female.Name = db.Genders.FirstOrDefault(v => v.gender_name == rb_student_female.Text).id.ToString();
            if (rb_student_male.Checked == true)
            {
                new_student.student_gender_id = Convert.ToInt32(rb_student_male.Name);
            }
            else if (rb_student_female.Checked == true)
            {
                new_student.student_gender_id = Convert.ToInt32(rb_student_female.Name);
            }
            int gr_id = db.Groups.Where(g => g.group_name == combo_student_gr.Text).First().id;
            new_student.student_group_id = gr_id;

            db.Students.Add(new_student);
            db.SaveChanges();
            MessageBox.Show("Elave Edildi");

            
            foto.DownloadFile(file.FileName, Extentions.path+image);

            BackStudent.ShowGridStudent();
            this.Close();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Student s = db.Students.Find(id);
            s.student_surname = txt_student_surname.Text;
            s.student_name = txt_student_name.Text;
            s.student_phone = txt_student_phone.Text;
            s.student_github_account = txt_student_github.Text;
            s.student_info = txt_student_info.Text;

            rb_student_male.Name = db.Genders.FirstOrDefault(g => g.gender_name == rb_student_male.Text).id.ToString();
            rb_student_female.Name = db.Genders.FirstOrDefault(v => v.gender_name == rb_student_female.Text).id.ToString();
            if (rb_student_male.Checked == true)
            {
                s.student_gender_id = Convert.ToInt32(rb_student_male.Name);
            }
            else if (rb_student_female.Checked == true)
            {
                s.student_gender_id = Convert.ToInt32(rb_student_female.Name);
            }
            int gr_id = db.Groups.Where(g => g.group_name == combo_student_gr.Text).First().id;
            s.student_group_id = gr_id;
            db.SaveChanges();
            BackStudent.ShowGridStudent();
            this.Close();
        }
    }
}
