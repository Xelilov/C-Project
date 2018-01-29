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
    public partial class StudentPanelForm : Form
    {
        Code_AcademyEntities db = new Code_AcademyEntities();
        public static int student_id;
        public StudentPanelForm()
        {
            InitializeComponent();
            ShowGridStudentTask();
            Cap_point();
        }

        private void ShowGridStudentTask()
        {
            Student_taskGridView.Rows.Clear();
            int ss = 0;
            List<Task> student_task = db.Tasks.Where(s => s.task_student_id == student_id).ToList();
            foreach (Task t_item in student_task)
            {
                Student_taskGridView.Rows.Add();
                Student_taskGridView.Rows[ss].Cells[0].Value = t_item.Task_types.task_type_name;
                Student_taskGridView.Rows[ss].Cells[1].Value = t_item.task_start_date.ToShortDateString();
                Student_taskGridView.Rows[ss].Cells[2].Value = t_item.task_end_date.ToShortDateString();
                Student_taskGridView.Rows[ss].Cells[3].Value = t_item.task_note;
                Student_taskGridView.Rows[ss].Cells[4].Value = t_item.task_source;
                Student_taskGridView.Rows[ss].Cells[5].Value = t_item.task_point;
                ss++;

            }

        }

        private void Cap_point()
        {
            List<int> task_types = new List<int>();
            List<Task> tasks = db.Tasks.Where(t => t.task_student_id == student_id).ToList();


            foreach (Task item in tasks)
            {
                if (!task_types.Contains(item.task_type_id))
                {
                    task_types.Add(item.task_type_id);
                }
            }


            int count = 0;
            double sum = 0;
            double cap_point = 0;
            double rate = 0;
            double average = 0;
            foreach (int item in task_types)
            {
                count = tasks.Where(t => t.task_type_id == item).Count();
                sum = tasks.Where(t => t.task_type_id == item).Select(t => t.task_point).Sum();
                rate = db.Task_types.First(t => t.id == item).task_type_rate;
                average += (sum / count) * rate;
                cap_point = average * 0.05;
            }

            
            Student selectedStudent = db.Students.Find(student_id);
            this.lb_student_cap.Text = Math.Round(cap_point, 2).ToString();

            selectedStudent.student_cap_point = cap_point;
            db.SaveChanges();
        }

    }
}
