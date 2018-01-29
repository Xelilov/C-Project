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
    public partial class AddNewTeacherForm : Form
    {        
        AdminPanelForm backAdmin = null;
        Code_AcademyEntities db = new Code_AcademyEntities();
        OpenFileDialog file = new OpenFileDialog();
        public int id;
        public AddNewTeacherForm(AdminPanelForm adm)
        {
            InitializeComponent();
            backAdmin = adm;
        }

        public AddNewTeacherForm()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            pc_teacher_photo.Image = Image.FromFile(file.FileName);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string image = DateTime.Now.ToString("yyyyMMddhhssmm") + file.SafeFileName;

            WebClient foto = new WebClient();
           
            Teacher new_teacher = new Teacher();
            new_teacher.teacher_name = txt_teacher_name.Text;
            new_teacher.teacher_surname = txt_teacher_surname.Text;
            new_teacher.teacher_email = txt_teacher_email.Text;
            new_teacher.teacher_phone = txt_teacher_phone.Text;
            new_teacher.teacher_photo = image;
            new_teacher.teacher_info = txt_teacher_info.Text;
            new_teacher.teacher_password = txt_teacher_password.Text;
            rb_male.Name = db.Genders.FirstOrDefault(g => g.gender_name == rb_male.Text).id.ToString();
            rb_female.Name = db.Genders.FirstOrDefault(v => v.gender_name == rb_female.Text).id.ToString();
            if (rb_male.Checked == true)
            {
                new_teacher.teacher_gender_id = Convert.ToInt32(rb_male.Name);
            }
            else if (rb_female.Checked==true)
            {
                new_teacher.teacher_gender_id = Convert.ToInt32(rb_female.Name);
            }

            db.Teachers.Add(new_teacher);
            db.SaveChanges();

            foto.DownloadFile(file.FileName, Extentions.path+image);

            backAdmin.ShowGridTeacher();
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Teacher t = db.Teachers.Find(id);
            t.teacher_name = txt_teacher_name.Text;
            t.teacher_surname = txt_teacher_surname.Text;
            t.teacher_phone = txt_teacher_phone.Text;
            t.teacher_info = txt_teacher_info.Text;
            rb_male.Name = db.Genders.FirstOrDefault(g => g.gender_name == rb_male.Text).id.ToString();
            rb_female.Name = db.Genders.FirstOrDefault(v => v.gender_name == rb_female.Text).id.ToString();
            if (rb_male.Checked == true)
            {
                t.teacher_gender_id = Convert.ToInt32(rb_male.Name);
            }
            else if (rb_female.Checked == true)
            {
                t.teacher_gender_id = Convert.ToInt32(rb_female.Name);
            }

            db.SaveChanges();
            backAdmin.ShowGridTeacher();
            this.Close();
        }
    }
}
