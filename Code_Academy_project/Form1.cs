using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Academy_project
{
    public partial class Form1 : Form
    {
        Code_AcademyEntities db = new Code_AcademyEntities();
        public Form1()
        {
            InitializeComponent();           
        }

        private void btn_sing_in_Click(object sender, EventArgs e)
        {
            var mentorLogin = db.Mentors.FirstOrDefault(m => m.mentor_email == txt_username.Text && m.mentor_password == txt_userpassword.Text);
            var teacherLogin = db.Teachers.FirstOrDefault(t => t.teacher_email == txt_username.Text && t.teacher_password == txt_userpassword.Text);
            var studentLogin = db.Students.FirstOrDefault(s => s.student_email == txt_username.Text && s.student_password == txt_userpassword.Text);
            if (txt_username.Text == "admin"&& txt_userpassword.Text=="admin")
            {
                AdminPanelForm admin_panel = new AdminPanelForm();
                admin_panel.ShowDialog();
            }
            else if (mentorLogin != null)
            {
                Mentor mtr = db.Mentors.FirstOrDefault(m_id => m_id.mentor_email == txt_username.Text);
                MenthorPanelForm.mnt_id = mtr.id;
                MenthorPanelForm mentor_panel = new MenthorPanelForm();
                mentor_panel.lb_name.Text = mtr.mentor_name;
                mentor_panel.lb_surname.Text = mtr.mentor_surname;
                mentor_panel.lb_email.Text = mtr.mentor_email;
                mentor_panel.lb_phone.Text = mtr.mentor_phone;
                mentor_panel.lb_gender.Text = mtr.Gender.gender_name;
                mentor_panel.txt_info.Text = mtr.mentor_info;
                Image image = Image.FromFile(Extentions.path+ mtr.mentor_photo);
                mentor_panel.pc_mentor_panel_foto.Image = image;
                mentor_panel.ShowDialog();
            }
            else if(teacherLogin != null)
            {
                Teacher tech = db.Teachers.FirstOrDefault(t_id => t_id.teacher_email == txt_username.Text);
                TeacherPanelForm.tech_id = tech.id;
                TeacherPanelForm teacher_panel = new TeacherPanelForm();
                teacher_panel.lb_teacher_name.Text = tech.teacher_name;
                teacher_panel.lb_teacher_surname.Text = tech.teacher_surname;
                teacher_panel.lb_teacher_phone.Text = tech.teacher_phone;
                teacher_panel.lb_teacher_gender.Text = tech.Gender.gender_name;
                teacher_panel.txt_teacher_info.Text = tech.teacher_info;
                Image image = Image.FromFile(Extentions.path + tech.teacher_photo);
                teacher_panel.pc_teacher_panel_foto.Image = image;
                teacher_panel.ShowDialog();
            }
            else if(studentLogin != null)
            {
                Student stdy = db.Students.FirstOrDefault(t_id => t_id.student_email == txt_username.Text);
                StudentPanelForm.student_id = stdy.id;
                StudentPanelForm student_panel = new StudentPanelForm();
                student_panel.lb_student_name.Text = stdy.student_name;
                student_panel.lb_student_surname.Text = stdy.student_surname;
                student_panel.lb_student_phone.Text = stdy.student_phone;
                student_panel.lb_student_gender.Text = stdy.Gender.gender_name;
                student_panel.lb_student_github.Text = stdy.student_github_account;
                student_panel.txt_info.Text = stdy.student_info;
                student_panel.lb_student_cap.Text = Convert.ToString(stdy.student_cap_point);
                Image image = Image.FromFile(Extentions.path + stdy.student_photo);
                student_panel.pc_studen_panel_foto.Image = image;
                student_panel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Your Email or Password is wrong!!!");
            }
        }
    }
}
