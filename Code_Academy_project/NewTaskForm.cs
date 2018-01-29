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
    public partial class NewTaskForm : Form
    {
        TeacherPanelForm backTeacher =null;
        Code_AcademyEntities db = new Code_AcademyEntities();
        public NewTaskForm(TeacherPanelForm adm)
        {
            InitializeComponent();
            combo_task();
            backTeacher = adm;
        }

        private void combo_task()
        {
            foreach (Task_types task_item in db.Task_types.ToList())
            {
                cb_task_type.Items.Add(task_item.task_type_name);
            }
            foreach (Group g_item in db.Groups.ToList())
            {
                cb_task_group.Items.Add(g_item.group_name);
            }
            foreach (Student s_item in db.Students.ToList())
            {
                cb_task_student.Items.Add(s_item.student_name);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Task new_task = new Task();
            new_task.task_start_date = dtp_start_date.Value;
            new_task.task_end_date = dtp_edb_date.Value;
            new_task.task_point = Convert.ToDouble(txt_task_point.Text);
            new_task.task_source = txt_task_source.Text;
            new_task.task_note = txt_task_note.Text;
            int t_type = db.Task_types.Where(t_t => t_t.task_type_name == cb_task_type.Text).First().id;
            new_task.task_type_id = t_type;
            int t_group = db.Groups.Where(t_g => t_g.group_name == cb_task_group.Text).First().id;
            new_task.task_group_id = t_group;
            int t_student = db.Students.Where(t_s => t_s.student_name == cb_task_student.Text).First().id;
            new_task.task_student_id = t_student;
            db.Tasks.Add(new_task);
            db.SaveChanges();

            backTeacher.ShowGridTask();
            this.Close();
            
        }
    }
}
