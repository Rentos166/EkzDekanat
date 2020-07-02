using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DekanatSystem
{
    public partial class FormPoints : Form
    {
        //Метод вывода информации о баллах
        void ShowPoint()
        {
            listViewPoint.Items.Clear();
            foreach (PointsSet pointSet in Program.ekzDb.PointsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    pointSet.Id.ToString(),
                    pointSet.IdSubject.ToString(),
                    pointSet.SubjectsSet.Name,
                    pointSet.SubjectsSet.Teacher,
                    pointSet.IdStudent.ToString(),
                    pointSet.StudentsSet.FirstName +" "+pointSet.StudentsSet.MiddleName.Remove(1) +
                    ". "+ pointSet.StudentsSet.LastName.Remove(1)+" .",
                    pointSet.StudentsSet.GroupsSet.Name,
                    pointSet.Point
                });
                item.Tag = pointSet;
                listViewPoint.Items.Add(item);
            }
            listViewPoint.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        //Метод вывода в comboBox
        void ShowSubjects()
        {
            comboBoxSubject.Items.Clear();
            foreach (SubjectsSet subject in Program.ekzDb.SubjectsSet)
            {
                string[] item = { subject.Id.ToString() + ". ", "Предмет: " + subject.Name + ". ", "Преподаватель: " + subject.Teacher + " ." };
                comboBoxSubject.Items.Add(string.Join(" ", item));
            }
        }
        //Метод вывода в comboBox
        void ShowStudents()
        {
            comboBoxStudent.Items.Clear();
            foreach (StudentsSet student in Program.ekzDb.StudentsSet)
            {
                string[] item = { student.Id.ToString() + ". ", student.FirstName, student.MiddleName.Remove(1) + ". ",
                    student.LastName.Remove(1)+ ". ","Группа: " + student.GroupsSet.Name};
                comboBoxStudent.Items.Add(string.Join(" ", item));
            }
        }
        public FormPoints()
        {
            InitializeComponent();
            ShowPoint();
            ShowSubjects();
            ShowStudents();
        }

        private void FormPoints_Load(object sender, EventArgs e)
        {

        }
        //Кнопка "Создать"
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSubject.SelectedItem != null && comboBoxStudent.SelectedItem != null && textBoxPoint.Text != "" )
                {
                    PointsSet pointSet = new PointsSet();
                    pointSet.IdSubject = Convert.ToInt32(comboBoxSubject.SelectedItem.ToString().Split('.')[0]);
                    pointSet.IdStudent = Convert.ToInt32(comboBoxStudent.SelectedItem.ToString().Split('.')[0]);
                    pointSet.Point = textBoxPoint.Text;
                    Program.ekzDb.PointsSet.Add(pointSet);
                    Program.ekzDb.SaveChanges();
                    ShowPoint();
                }
                else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Кнопка "Изменить"
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPoint.SelectedItems.Count == 1)
                {
                    if (comboBoxSubject.SelectedItem != null && comboBoxStudent.SelectedItem != null && textBoxPoint.Text != "")
                    {
                        PointsSet pointSet = listViewPoint.SelectedItems[0].Tag as PointsSet;
                        pointSet.IdSubject = Convert.ToInt32(comboBoxSubject.SelectedItem.ToString().Split('.')[0]);
                        pointSet.IdStudent = Convert.ToInt32(comboBoxStudent.SelectedItem.ToString().Split('.')[0]);
                        pointSet.Point = textBoxPoint.Text;
                        Program.ekzDb.SaveChanges();
                        ShowPoint();
                    }
                    else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPoint.SelectedItems.Count == 1)
            {
                PointsSet pointSet = listViewPoint.SelectedItems[0].Tag as PointsSet;
                comboBoxSubject.SelectedIndex = comboBoxSubject.FindString(pointSet.IdSubject.ToString());
                comboBoxStudent.SelectedIndex = comboBoxStudent.FindString(pointSet.IdStudent.ToString());
                textBoxPoint.Text = pointSet.Point.ToString();
            }
            else
            {
                comboBoxSubject.SelectedItem = null;
                comboBoxStudent.SelectedItem = null;
                textBoxPoint.Text = "";
            }
        }
        //Кнопка "Удалить"
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPoint.SelectedItems.Count == 1)
                {
                    PointsSet pointSet = listViewPoint.SelectedItems[0].Tag as PointsSet;
                    Program.ekzDb.PointsSet.Remove(pointSet);
                    Program.ekzDb.SaveChanges();
                    ShowPoint();
                }
                comboBoxSubject.SelectedItem = null;
                comboBoxStudent.SelectedItem = null;
                textBoxPoint.Text = "";
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBoxPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 46 && number != 8 && number != 47) //цифры, клавиша BackSpace, точка 
            {
                e.Handled = true;
            }
        }
    }
}
