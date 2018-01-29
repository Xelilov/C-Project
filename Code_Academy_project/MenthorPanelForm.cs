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
    public partial class MenthorPanelForm : Form
    {
        Code_AcademyEntities db = new Code_AcademyEntities();
        public static int mnt_id;
        public MenthorPanelForm()
        {
            InitializeComponent();
            gridMenthorStudent();
        }

        private void gridMenthorStudent()
        {
            mentor_studenGridView.Rows.Clear();
            int s = 0;
            List<Student> list_student = db.Students.Where(std => std.Group.group_mentor_id == mnt_id).ToList();
            foreach (Student s_item in list_student)
            {
                mentor_studenGridView.Rows.Add();
                mentor_studenGridView.Rows[s].Cells[0].Value = s_item.student_name;
                mentor_studenGridView.Rows[s].Cells[1].Value = s_item.student_surname;
                mentor_studenGridView.Rows[s].Cells[2].Value = s_item.student_email;
                mentor_studenGridView.Rows[s].Cells[3].Value = s_item.Group.group_name;
                s++;
            }
        }        
    }
}
