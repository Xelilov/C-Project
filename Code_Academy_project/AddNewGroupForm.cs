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
    public partial class AddNewGroupForm : Form
    {
        AdminPanelForm groupadmin = null;
        Code_AcademyEntities db = new Code_AcademyEntities();
        public int id;
        public AddNewGroupForm(AdminPanelForm adm)
        {
            InitializeComponent();
            groupadmin = adm;
            combo_group();
            ShowGroupGrid();
        }
        public AddNewGroupForm()
        {
            InitializeComponent();
            combo_group();
            ShowGroupGrid();
        }

        private void btn_add_group_types_Click(object sender, EventArgs e)
        {
            AddGroupTypeForm new_group_type = new AddGroupTypeForm();
            new_group_type.ShowDialog();
        }


        private void combo_group()
        {
            foreach (var g_item in db.Group_types.ToList())
            {
                this.cb_group_type.Items.Add(g_item.group_type_name);
            }
            foreach (var t_item in db.Teachers.ToList())
            {
                this.cb_group_teacher.Items.Add(t_item.teacher_name);
            }
            foreach (var m_item in db.Mentors.ToList())
            {
                this.cb_group_menthor.Items.Add(m_item.mentor_name);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Group new_group = new Group();
            new_group.group_name = txt_group_name.Text;
            int gr_id = db.Group_types.Where(g => g.group_type_name == cb_group_type.Text).First().id;
            new_group.group_type_id = gr_id;
            int tr_id = db.Teachers.Where(t => t.teacher_name == cb_group_teacher.Text).First().id;
            new_group.group_techer_id = tr_id;
            int mt_id = db.Mentors.Where(m => m.mentor_name == cb_group_menthor.Text).First().id;
            new_group.group_mentor_id = mt_id;
            new_group.group_start_date = group_startTimePicker1.Value;
            db.Groups.Add(new_group);
            db.SaveChanges();
            MessageBox.Show("elave edildi");
            ShowGroupGrid();
            groupadmin.ShowGridGroup();
            this.Close();
        }

        private void ShowGroupGrid()
        {
            GroupGridView.Rows.Clear();
            int i = 0;
            List<Group> list_groups = db.Groups.ToList();
            foreach (Group g_item in list_groups)
            {
                GroupGridView.Rows.Add();
                GroupGridView.Rows[i].Cells[0].Value = g_item.group_name;
                GroupGridView.Rows[i].Cells[1].Value = g_item.Teacher.teacher_name;
                GroupGridView.Rows[i].Cells[2].Value = g_item.Mentor.mentor_name;
                GroupGridView.Rows[i].Cells[3].Value = g_item.Group_types.group_type_name;
                GroupGridView.Rows[i].Cells[4].Value = g_item.group_start_date.ToShortDateString();
                i++;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Group group = db.Groups.Find(id);
            group.group_name = txt_group_name.Text;
            int gr_id = db.Group_types.Where(g => g.group_type_name == cb_group_type.Text).First().id;
            group.group_type_id = gr_id;
            int tr_id = db.Teachers.Where(t => t.teacher_name == cb_group_teacher.Text).First().id;
            group.group_techer_id = tr_id;
            int mt_id = db.Mentors.Where(m => m.mentor_name == cb_group_menthor.Text).First().id;
            group.group_mentor_id = mt_id;
            group.group_start_date = group_startTimePicker1.Value;            
            db.SaveChanges();
            groupadmin.ShowGridGroup();
            this.Close();
        }
    }
}
