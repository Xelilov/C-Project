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
    public partial class AddGroupScheduleForm : Form
    {
        Code_AcademyEntities db = new Code_AcademyEntities();
        public AddGroupScheduleForm()
        {
            InitializeComponent();
            ShowScheduleGrid();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Group_schedule new_Schedule = new Group_schedule();
            new_Schedule.group_schedule_name = txt_schedule_name.Text;
            new_Schedule.group_begin_time = dtp_begin_time.Value;
            new_Schedule.group_end_time = dtp_end_time.Value;
            db.Group_schedule.Add(new_Schedule);
            db.SaveChanges();
            MessageBox.Show("Elave edildi");
            ShowScheduleGrid();
        }

        private void ShowScheduleGrid()
        {
            scheduleGridView.Rows.Clear();
            int i = 0;
            List<Group_schedule> list_schedule = db.Group_schedule.ToList();
            foreach (Group_schedule s_item in list_schedule)
            {
                scheduleGridView.Rows.Add();
                scheduleGridView.Rows[i].Cells[0].Value = s_item.group_schedule_name;
                scheduleGridView.Rows[i].Cells[1].Value = s_item.group_begin_time.ToShortTimeString();
                scheduleGridView.Rows[i].Cells[2].Value = s_item.group_end_time.ToShortTimeString();
                i++;
            }
        }
    }
}
