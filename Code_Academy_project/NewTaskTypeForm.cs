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
    public partial class NewTaskTypeForm : Form
    {
        Code_AcademyEntities db = new Code_AcademyEntities();
        public NewTaskTypeForm()
        {
            InitializeComponent();
            ShowGridTaskType();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Task_types new_task_type = new Task_types();
            new_task_type.task_type_name = txt_task_type_name.Text;
            new_task_type.task_type_rate = Convert.ToDouble(txt_task_type_rate.Text);
            db.Task_types.Add(new_task_type);
            db.SaveChanges();
            ShowGridTaskType();
        }

        private void ShowGridTaskType()
        {
            task_typeGridView.Rows.Clear();
            int i = 0;
            List<Task_types> list_task_type = db.Task_types.ToList();
            foreach (Task_types t_item in list_task_type)
            {
                task_typeGridView.Rows.Add();
                task_typeGridView.Rows[i].Cells[0].Value = t_item.task_type_name;
                task_typeGridView.Rows[i].Cells[1].Value = t_item.task_type_rate;
                i++;
            }
        }
    }
}
