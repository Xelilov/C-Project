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
    public partial class AdminPanelForm : Form
    {
        Code_AcademyEntities db = new Code_AcademyEntities();
        Teacher selectedTeacher;
        Mentor selectedMenthor;
        Group selectedGroup;
        Student selectedStudent;
        public AdminPanelForm()
        {
            InitializeComponent();
            ShowGridTeacher();
            ShowGridMenthor();
            ShowGridGroup();
            ShowGridStudent();
        }

        private void btn_add_teacher_Click(object sender, EventArgs e)
        {
            AddNewTeacherForm new_teacher = new AddNewTeacherForm(this);
            new_teacher.ShowDialog();
        }

        public  void ShowGridTeacher()
        {
            teacherGridView.Rows.Clear();
            teacherGridView.Columns.Clear();

            int i = 0;
            List<Teacher> list_teacher = db.Teachers.ToList();
            foreach (Teacher t_item in list_teacher)
            {
                teacherGridView.ColumnCount = 5;
                teacherGridView.Columns[0].Name = "id";
                teacherGridView.Columns[0].HeaderText = "id";
                teacherGridView.Columns[0].Visible = false;
                teacherGridView.Columns[1].Name = "name";
                teacherGridView.Columns[1].HeaderText = "Teacher Name";
                teacherGridView.Columns[2].Name = "surname";
                teacherGridView.Columns[2].HeaderText = "Teacher Surname";
                teacherGridView.Columns[3].Name = "email";
                teacherGridView.Columns[3].HeaderText = "Teacher Email";
                teacherGridView.Columns[4].Name = "gender";
                teacherGridView.Columns[4].HeaderText = "Teacher Gender";

                teacherGridView.Rows.Add();
                teacherGridView.Rows[i].Cells[0].Value = t_item.id;
                teacherGridView.Rows[i].Cells[1].Value = t_item.teacher_name;
                teacherGridView.Rows[i].Cells[2].Value = t_item.teacher_surname;
                teacherGridView.Rows[i].Cells[3].Value = t_item.teacher_email;
                teacherGridView.Rows[i].Cells[4].Value = t_item.Gender.gender_name;               
                DataGridViewButtonColumn t_delete = new DataGridViewButtonColumn();
                t_delete.Text = "Delete";
                t_delete.DefaultCellStyle.BackColor=Color.Red;
                t_delete.UseColumnTextForButtonValue = true;
                teacherGridView.Columns.Insert(5, t_delete);
                DataGridViewButtonColumn t_edit = new DataGridViewButtonColumn();
                t_edit.Text = "Edit";
                t_edit.DefaultCellStyle.BackColor = Color.Green;
                t_edit.UseColumnTextForButtonValue = true;
                teacherGridView.Columns.Insert(6, t_edit);
                i++;
            }
        }

        private void Update_Teacher(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)teacherGridView.Rows[e.RowIndex].Cells[0].Value;
            selectedTeacher = db.Teachers.Find(id);
            if (e.ColumnIndex == 6)
            {
                AddNewTeacherForm tech = new AddNewTeacherForm(this);
                tech.txt_teacher_name.Text = selectedTeacher.teacher_name;
                tech.txt_teacher_email.ReadOnly = true;
                tech.txt_teacher_info.Text = selectedTeacher.teacher_info;
                tech.txt_teacher_password.ReadOnly = true;
                tech.txt_teacher_phone.Text = selectedTeacher.teacher_phone;
                tech.txt_teacher_surname.Text = selectedTeacher.teacher_surname;
                tech.pc_teacher_photo.Image = Image.FromFile(Extentions.path + selectedTeacher.teacher_photo);
                tech.btn_upload.Enabled = false;
                tech.rb_male.Checked = selectedTeacher.teacher_gender_id == 1 ? true : false;
                tech.rb_female.Checked = selectedTeacher.teacher_gender_id == 2 ? true : false;
                tech.btn_save.Visible = false;
                tech.btn_update.Visible = true;
                tech.id = selectedTeacher.id;
                tech.ShowDialog();
                this.ShowGridTeacher();
            }

            else if (e.ColumnIndex == 5)
            {
                db.Teachers.Remove(selectedTeacher);
                MessageBox.Show("Eminsen????");
                db.SaveChanges();
                ShowGridTeacher();
            }
        }

        private void btn_add_menthor_Click(object sender, EventArgs e)
        {
            AddNewMenthorForm new_menthor = new AddNewMenthorForm(this);
            new_menthor.ShowDialog();
        }

        public void ShowGridMenthor()
        {
            menthorGridView.Rows.Clear();
            menthorGridView.Columns.Clear();
            int m = 0;
            List<Mentor> list_menthor = db.Mentors.ToList();
            foreach (Mentor m_item in list_menthor)
            {
                menthorGridView.ColumnCount = 5;
                menthorGridView.Columns[0].Name = "id";
                menthorGridView.Columns[0].HeaderText = "Menthor id";
                menthorGridView.Columns[0].Visible = false;
                menthorGridView.Columns[1].Name = "name";
                menthorGridView.Columns[1].HeaderText = "Menthor Name";
                menthorGridView.Columns[2].Name = "surname";
                menthorGridView.Columns[2].HeaderText = "Menthor Surname";
                menthorGridView.Columns[3].Name = "email";
                menthorGridView.Columns[3].HeaderText = "Menthor Email";
                menthorGridView.Columns[4].Name = "gender";
                menthorGridView.Columns[4].HeaderText = "Menthor Gender";

                menthorGridView.Rows.Add();
                menthorGridView.Rows[m].Cells[0].Value = m_item.id;
                menthorGridView.Rows[m].Cells[1].Value = m_item.mentor_name;
                menthorGridView.Rows[m].Cells[2].Value = m_item.mentor_surname;
                menthorGridView.Rows[m].Cells[3].Value = m_item.mentor_email;
                menthorGridView.Rows[m].Cells[4].Value = m_item.Gender.gender_name;                
                DataGridViewButtonColumn m_delete = new DataGridViewButtonColumn();
                m_delete.Text = "Delete";
                m_delete.DefaultCellStyle.BackColor = Color.Red;
                m_delete.UseColumnTextForButtonValue = true;
                menthorGridView.Columns.Insert(5, m_delete);
                DataGridViewButtonColumn m_edit = new DataGridViewButtonColumn();
                m_edit.Text = "Edit";
                m_edit.DefaultCellStyle.BackColor = Color.Green;
                m_edit.UseColumnTextForButtonValue = true;
                menthorGridView.Columns.Insert(6, m_edit);
                m++;
            }
        }

        private void Update_Menthor(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)menthorGridView.Rows[e.RowIndex].Cells[0].Value;
            selectedMenthor = db.Mentors.Find(id);
            if (e.ColumnIndex == 6)
            {
                AddNewMenthorForm menthor = new AddNewMenthorForm(this);
                menthor.txt_menthor_name.Text = selectedMenthor.mentor_name;
                menthor.txt_menthor_surname.Text = selectedMenthor.mentor_surname;
                menthor.txt_menthor_email.ReadOnly = true;
                menthor.txt_menthor_phone.Text = selectedMenthor.mentor_phone;
                menthor.txt_menthor_password.ReadOnly = true;
                menthor.txt_menthor_info.Text = selectedMenthor.mentor_info;
                menthor.pc_menthor_photo.Image = Image.FromFile(Extentions.path + selectedMenthor.mentor_photo);
                menthor.btn_upload.Enabled = false;
                menthor.rb_menthor_male.Checked = selectedMenthor.mentor_gender_id == 1 ? true : false;
                menthor.rb_menthor_female.Checked = selectedMenthor.mentor_gender_id == 2 ? true : false;
                menthor.btn_save.Visible = false;
                menthor.btn_update.Visible = true;
                menthor.id = selectedMenthor.id;
                menthor.ShowDialog();
                this.ShowGridMenthor();
            }
            else if(e.ColumnIndex == 5)
            {
                db.Mentors.Remove(selectedMenthor);
                MessageBox.Show("Eminsen???");
                db.SaveChanges();
                ShowGridMenthor();
            }
        }

        private void btn_add_group_Click(object sender, EventArgs e)
        {
            AddNewGroupForm new_group = new AddNewGroupForm(this);
            new_group.ShowDialog();
        }

        public void ShowGridGroup()
        {
            groupGridView.Rows.Clear();
            groupGridView.Columns.Clear();
            int g = 0;
            List<Group> list_group = db.Groups.ToList();
            foreach (Group g_item in list_group)
            {
                groupGridView.ColumnCount = 6;
                groupGridView.Columns[0].Name = "id";
                groupGridView.Columns[0].HeaderText = "Group id";
                groupGridView.Columns[0].Visible = false;
                groupGridView.Columns[1].Name = "name";
                groupGridView.Columns[1].HeaderText = "Group Name";
                groupGridView.Columns[2].Name = "teacher";
                groupGridView.Columns[2].HeaderText = "Teacher Name";
                groupGridView.Columns[3].Name = "menthor";
                groupGridView.Columns[3].HeaderText = "Menthor Name";
                groupGridView.Columns[4].Name = "types";
                groupGridView.Columns[4].HeaderText = "Group Types";
                groupGridView.Columns[5].Name = "start";
                groupGridView.Columns[5].HeaderText = "Start Time";

                groupGridView.Rows.Add();
                groupGridView.Rows[g].Cells[0].Value = g_item.id;
                groupGridView.Rows[g].Cells[1].Value = g_item.group_name;
                groupGridView.Rows[g].Cells[2].Value = g_item.Teacher.teacher_name;
                groupGridView.Rows[g].Cells[3].Value = g_item.Mentor.mentor_name;
                groupGridView.Rows[g].Cells[4].Value = g_item.Group_types.group_type_name;
                groupGridView.Rows[g].Cells[5].Value = g_item.group_start_date.ToShortDateString();                
                DataGridViewButtonColumn g_delete = new DataGridViewButtonColumn();
                g_delete.Text = "Delete";
                g_delete.DefaultCellStyle.BackColor = Color.Red;
                g_delete.UseColumnTextForButtonValue = true;
                groupGridView.Columns.Insert(6, g_delete);
                DataGridViewButtonColumn g_edit = new DataGridViewButtonColumn();
                g_edit.Text = "Edit";
                g_edit.DefaultCellStyle.BackColor = Color.Green;
                g_edit.UseColumnTextForButtonValue = true;
                groupGridView.Columns.Insert(7, g_edit);
                g++;
            }
        }

        private void Update_Groups(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 7)
            {
                int id = (int)groupGridView.Rows[e.RowIndex].Cells[0].Value;
                selectedGroup = db.Groups.Find(id);
                AddNewGroupForm group = new AddNewGroupForm(this);
                group.txt_group_name.Text = selectedGroup.group_name;
                group.cb_group_teacher.Text = selectedGroup.Teacher.teacher_name;
                group.cb_group_menthor.Text = selectedGroup.Mentor.mentor_name;
                group.btn_add_group_types.Enabled = false;
                group.cb_group_type.Text = selectedGroup.Group_types.group_type_name;
                group.group_startTimePicker1.Value = selectedGroup.group_start_date;
                group.btn_save.Visible = false;
                group.btn_update.Visible = true;
                group.id = selectedGroup.id;
                group.ShowDialog();
                this.ShowGridGroup();
            }
            else if (e.ColumnIndex == 6)
            {
                db.Groups.Remove(selectedGroup);
                MessageBox.Show("Eminsen???");
                db.SaveChanges();
                ShowGridGroup();
            }
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            AddNewStudentForm new_student = new AddNewStudentForm(this);
            new_student.ShowDialog();
        }

        public void ShowGridStudent()
        {
            StudentGridView.Rows.Clear();
            StudentGridView.Columns.Clear();
            int s = 0;
            List<Student> list_student=db.Students.ToList();
            foreach (Student s_item in list_student)
            {
                StudentGridView.ColumnCount = 5;
                StudentGridView.Columns[0].Name = "id";
                StudentGridView.Columns[0].HeaderText = "Student id";
                StudentGridView.Columns[0].Visible = false;
                StudentGridView.Columns[1].Name = "name";
                StudentGridView.Columns[1].HeaderText = "Student Name";
                StudentGridView.Columns[2].Name = "Surname";
                StudentGridView.Columns[2].HeaderText = "Student Surname";
                StudentGridView.Columns[3].Name = "group";
                StudentGridView.Columns[3].HeaderText = "Student Group";
                StudentGridView.Columns[4].Name = "Email";
                StudentGridView.Columns[4].HeaderText = "Student Email";

                StudentGridView.Rows.Add();
                StudentGridView.Rows[s].Cells[0].Value = s_item.id;
                StudentGridView.Rows[s].Cells[1].Value = s_item.student_name;
                StudentGridView.Rows[s].Cells[2].Value = s_item.student_surname;
                StudentGridView.Rows[s].Cells[3].Value = s_item.Group.group_name;
                StudentGridView.Rows[s].Cells[4].Value = s_item.student_email;
                DataGridViewButtonColumn s_delete = new DataGridViewButtonColumn();
                s_delete.Text = "Delete";
                s_delete.DefaultCellStyle.BackColor = Color.Red;
                s_delete.UseColumnTextForButtonValue = true;
                StudentGridView.Columns.Insert(5, s_delete);
                DataGridViewButtonColumn s_edit = new DataGridViewButtonColumn();
                s_edit.Text = "Edit";
                s_edit.DefaultCellStyle.BackColor = Color.Green;
                s_edit.UseColumnTextForButtonValue = true;
                StudentGridView.Columns.Insert(6, s_edit);
                s++;
            }
        }

        private void Update_student(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int id = (int)StudentGridView.Rows[e.RowIndex].Cells[0].Value;
                selectedStudent = db.Students.Find(id);
                AddNewStudentForm student = new AddNewStudentForm(this);
                student.txt_student_name.Text = selectedStudent.student_name;
                student.txt_student_surname.Text = selectedStudent.student_surname;
                student.txt_student_email.ReadOnly = true;
                student.txt_student_phone.Text = selectedStudent.student_phone;
                student.txt_student_password.ReadOnly = true;
                student.txt_student_info.Text = selectedStudent.student_info;
                student.txt_student_github.Text = selectedStudent.student_github_account;
                student.txt_student_cap.ReadOnly = true;
                student.combo_student_gr.Text = selectedStudent.Group.group_name;
                student.pc_student_photo.Image = Image.FromFile(Extentions.path + selectedStudent.student_photo);
                student.btn_upload.Enabled = false;
                student.rb_student_male.Checked = selectedStudent.student_gender_id == 1 ? true : false;
                student.rb_student_female.Checked = selectedStudent.student_gender_id == 2 ? true : false;
                student.btn_save.Visible = false;
                student.btn_update.Visible = true;
                student.id = selectedStudent.id;
                student.ShowDialog();
                this.ShowGridStudent();
            }
            else if (e.ColumnIndex == 5)
            {
                db.Students.Remove(selectedStudent);
                MessageBox.Show("Eminsen???");
                db.SaveChanges();
                ShowGridStudent();
            }
        }
    }
}
