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
    public partial class AddGroupTypeForm : Form
    {
        Code_AcademyEntities db = new Code_AcademyEntities();
        public AddGroupTypeForm()
        {
            InitializeComponent();
            combo_schedule();
            ShowGroupTypeGrid();
        }

        private void btn_add_schedule_Click(object sender, EventArgs e)
        {
            AddGroupScheduleForm new_schedule = new AddGroupScheduleForm();
            new_schedule.ShowDialog();
        }

        private void combo_schedule()
        {
            foreach (var item in db.Group_schedule.ToList())
            {
                this.cb_shedule.Items.Add(item.group_schedule_name);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Group_types new_group_type = new Group_types();
            new_group_type.group_type_name = txt_group_type_name.Text;
            int schedule_id = db.Group_schedule.Where(s => s.group_schedule_name == cb_shedule.Text).First().id;
            new_group_type.group_schedule_id = schedule_id;
            db.Group_types.Add(new_group_type);
            db.SaveChanges();
            MessageBox.Show("elave edildi");
            ShowGroupTypeGrid();
        }

        private void ShowGroupTypeGrid()
        {
            groupTypeGridView.Rows.Clear();
            int i = 0;
            List<Group_types> list_types = db.Group_types.ToList();
            foreach (Group_types t_item in list_types)
            {
                groupTypeGridView.Rows.Add();
                groupTypeGridView.Rows[i].Cells[0].Value = t_item.group_type_name;
                groupTypeGridView.Rows[i].Cells[1].Value = t_item.Group_schedule.group_schedule_name;
                i++;
            }
        }
    }
}
