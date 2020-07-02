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
    public partial class FormStudents : Form
    {
        //Метод вывода информации
        void ShowStudents()
        {
            listViewStudents.Items.Clear();
            foreach (StudentsSet studentsSet in Program.ekzDb.StudentsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    studentsSet.Id.ToString(),
                    studentsSet.FirstName,
                    studentsSet.MiddleName,
                    studentsSet.LastName,
                    studentsSet.IdGroup.ToString(),
                    studentsSet.GroupsSet.Name,
                    studentsSet.YearPost.ToString("dd/MM/yyyy")
                });
                item.Tag = studentsSet;
                listViewStudents.Items.Add(item);
            }
            listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        //Метод вывода информации в comboBox
        void ShowGroups()
        {
            comboBoxGroups.Items.Clear();
            foreach (GroupsSet group in Program.ekzDb.GroupsSet)
            {
                string[] item = { group.Id.ToString() + ". ", group.Name + " ." };
                comboBoxGroups.Items.Add(string.Join(" ", item));
            }
        }
        public FormStudents()
        {
            InitializeComponent();
            ShowStudents();
            ShowGroups();
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {

        }
        //Кнопка "Создать"
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxGroups.SelectedItem != null && textBoxFirstName.Text != "" && textBoxMiddleName.Text != ""
                    && textBoxLastName.Text != "" && dateTimePickerYear.Value != null)
                {
                    StudentsSet studentsSet = new StudentsSet();
                    studentsSet.IdGroup = Convert.ToInt32(comboBoxGroups.SelectedItem.ToString().Split('.')[0]);
                    studentsSet.FirstName = textBoxFirstName.Text;
                    studentsSet.MiddleName = textBoxMiddleName.Text;
                    studentsSet.LastName = textBoxLastName.Text;
                    studentsSet.YearPost = dateTimePickerYear.Value;
                    Program.ekzDb.StudentsSet.Add(studentsSet);
                    Program.ekzDb.SaveChanges();
                    ShowStudents();
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
                if (listViewStudents.SelectedItems.Count == 1)
                {
                    if (comboBoxGroups.SelectedItem != null && textBoxFirstName.Text != "" && textBoxMiddleName.Text != "" 
                        && textBoxLastName.Text != "" && dateTimePickerYear.Value != null)
                    {
                        StudentsSet studentsSet = listViewStudents.SelectedItems[0].Tag as StudentsSet;
                        studentsSet.IdGroup = Convert.ToInt32(comboBoxGroups.SelectedItem.ToString().Split('.')[0]);
                        studentsSet.FirstName = textBoxFirstName.Text;
                        studentsSet.MiddleName = textBoxMiddleName.Text;
                        studentsSet.LastName = textBoxLastName.Text;
                        studentsSet.YearPost = dateTimePickerYear.Value;
                        Program.ekzDb.SaveChanges();
                        ShowStudents();
                    }
                }
                else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Вывод информации
        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count == 1)
            {
                StudentsSet studentsSet = listViewStudents.SelectedItems[0].Tag as StudentsSet;
                comboBoxGroups.SelectedIndex = comboBoxGroups.FindString(studentsSet.IdGroup.ToString());
                dateTimePickerYear.Value = studentsSet.YearPost;
                textBoxFirstName.Text = studentsSet.FirstName;
                textBoxMiddleName.Text = studentsSet.MiddleName;
                textBoxLastName.Text = studentsSet.LastName;
            }
            else
            {
                comboBoxGroups.SelectedItem = null;
                dateTimePickerYear.Value = DateTime.Now;
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
            }
        }
        //Кнопка "Удалить"
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStudents.SelectedItems.Count == 1)
                {
                    StudentsSet studentsSet = listViewStudents.SelectedItems[0].Tag as StudentsSet;
                    Program.ekzDb.StudentsSet.Remove(studentsSet);
                    Program.ekzDb.SaveChanges();
                    ShowStudents();
                }
                comboBoxGroups.SelectedItem = null;
                dateTimePickerYear.Value = DateTime.Now;
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
