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
    public partial class TeacherPanelForm : Form
    {
        Code_AcademyEntities db = new Code_AcademyEntities();
        public static int tech_id;
        public TeacherPanelForm()
        {
            InitializeComponent();
            ShowGridTask();
        }

        private void btn_add_task_type_Click(object sender, EventArgs e)
        {
            NewTaskTypeForm new_task_typ = new NewTaskTypeForm();
            new_task_typ.ShowDialog();
        }

        private void btn_add_task_Click(object sender, EventArgs e)
        {
            NewTaskForm new_task = new NewTaskForm(this);
            new_task.ShowDialog();
        }


        public void ShowGridTask()
        {
            taskGridView.Rows.Clear();
            int ts = 0;
            List<Task> list_task = db.Tasks.Where(t => t.Group.group_techer_id == tech_id).ToList();
            foreach (Task ts_item in list_task)
            {
                taskGridView.Rows.Add();
                taskGridView.Rows[ts].Cells[0].Value = ts_item.Task_types.task_type_name;
                taskGridView.Rows[ts].Cells[1].Value = ts_item.task_start_date.ToShortDateString();
                taskGridView.Rows[ts].Cells[2].Value = ts_item.task_end_date.ToShortDateString();
                taskGridView.Rows[ts].Cells[3].Value = ts_item.task_point;
                taskGridView.Rows[ts].Cells[4].Value = ts_item.Group.group_name;
                taskGridView.Rows[ts].Cells[5].Value = ts_item.Student.student_name;
                ts++;
            }
        }
    }
}
