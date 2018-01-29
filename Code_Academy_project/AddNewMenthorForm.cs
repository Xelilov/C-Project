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
    public partial class AddNewMenthorForm : Form
    {
        AdminPanelForm backadmin = null;
        Code_AcademyEntities db = new Code_AcademyEntities();
        OpenFileDialog file = new OpenFileDialog();
        public int id;
        public AddNewMenthorForm(AdminPanelForm adm)
        {
            InitializeComponent();
            backadmin = adm;
        }
        public AddNewMenthorForm()
        {
            InitializeComponent();            
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            pc_menthor_photo.Image = Image.FromFile(file.FileName);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string image = DateTime.Now.ToString("yyyyMMddhhssmm") + file.SafeFileName;

            WebClient foto = new WebClient();

            Mentor new_mentor = new Mentor();
            new_mentor.mentor_name = txt_menthor_name.Text;
            new_mentor.mentor_surname = txt_menthor_surname.Text;
            new_mentor.mentor_email = txt_menthor_email.Text;
            new_mentor.mentor_phone = txt_menthor_phone.Text;
            new_mentor.mentor_photo = image;
            new_mentor.mentor_info = txt_menthor_info.Text;
            new_mentor.mentor_password = txt_menthor_password.Text;

            rb_menthor_male.Name = db.Genders.FirstOrDefault(g => g.gender_name == rb_menthor_male.Text).id.ToString();
            rb_menthor_female.Name = db.Genders.FirstOrDefault(v => v.gender_name == rb_menthor_female.Text).id.ToString();
            if (rb_menthor_male.Checked == true)
            {
                new_mentor.mentor_gender_id = Convert.ToInt32(rb_menthor_male.Name);
            }
            else if (rb_menthor_female.Checked == true)
            {
                new_mentor.mentor_gender_id = Convert.ToInt32(rb_menthor_female.Name);
            }

            db.Mentors.Add(new_mentor);
            db.SaveChanges();

            
            foto.DownloadFile(file.FileName, Extentions.path+image);
            backadmin.ShowGridMenthor();
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Mentor m = db.Mentors.Find(id);
            m.mentor_name = txt_menthor_name.Text;
            m.mentor_surname = txt_menthor_surname.Text;
            m.mentor_phone = txt_menthor_phone.Text;
            m.mentor_info = txt_menthor_info.Text;
            rb_menthor_male.Name = db.Genders.FirstOrDefault(g => g.gender_name == rb_menthor_male.Text).id.ToString();
            rb_menthor_female.Name = db.Genders.FirstOrDefault(v => v.gender_name == rb_menthor_female.Text).id.ToString();
            if (rb_menthor_male.Checked == true)
            {
                m.mentor_gender_id = Convert.ToInt32(rb_menthor_male.Name);
            }
            else if (rb_menthor_female.Checked == true)
            {
                m.mentor_gender_id = Convert.ToInt32(rb_menthor_female.Name);
            }
            db.SaveChanges();
            backadmin.ShowGridMenthor();
            this.Close();
        }
    }
}
