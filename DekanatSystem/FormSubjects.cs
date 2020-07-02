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
    public partial class FormSubjects : Form
    {
        //Метод вывода информации о занятиях
        void ShowSubjects()
        {
            listViewSubjects.Items.Clear();
            foreach (SubjectsSet subjectsSet in Program.ekzDb.SubjectsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    subjectsSet.Id.ToString(),
                    subjectsSet.Name,
                    subjectsSet.Teacher,
                    subjectsSet.Semestr.ToString(),
                    subjectsSet.Year.ToString() 
                });
                item.Tag = subjectsSet;
                listViewSubjects.Items.Add(item);
            }
            listViewSubjects.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormSubjects()
        {
            InitializeComponent();
        }

        private void FormSubjects_Load(object sender, EventArgs e)
        {

        }
        //Кнопка "Создать"
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != "" && textBoxPrepod.Text != ""
                    && textBoxChemester.Text != "" && textBoxYear.Text !="")
                {
                    SubjectsSet subjectsSet = new SubjectsSet();
                    subjectsSet.Name = textBoxName.Text;
                    subjectsSet.Teacher = textBoxPrepod.Text;
                    subjectsSet.Semestr = Convert.ToInt32(textBoxChemester.Text);
                    subjectsSet.Year = Convert.ToInt32(textBoxYear.Text);
                    Program.ekzDb.SubjectsSet.Add(subjectsSet);
                    Program.ekzDb.SaveChanges();
                    ShowSubjects();
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
                if (listViewSubjects.SelectedItems.Count == 1)
                {
                    if (textBoxName.Text != "" && textBoxPrepod.Text != ""
                    && textBoxChemester.Text != "" && textBoxYear.Text != "")
                    {
                        SubjectsSet subjectsSet = listViewSubjects.SelectedItems[0].Tag as SubjectsSet;
                        subjectsSet.Name = textBoxName.Text;
                        subjectsSet.Teacher = textBoxPrepod.Text;
                        subjectsSet.Semestr = Convert.ToInt32(textBoxChemester.Text);
                        subjectsSet.Year = Convert.ToInt32(textBoxYear.Text);
                        Program.ekzDb.SaveChanges();
                        ShowSubjects();
                    }
                    else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSubjects.SelectedItems.Count == 1)
            {
                SubjectsSet subjectsSet = listViewSubjects.SelectedItems[0].Tag as SubjectsSet;
                textBoxName.Text = subjectsSet.Name;
                textBoxPrepod.Text = subjectsSet.Teacher;
                textBoxChemester.Text = subjectsSet.Semestr.ToString();
                textBoxYear.Text = subjectsSet.Year.ToString();
            }
            else
            {
                textBoxName.Text = "";
                textBoxPrepod.Text = "";
                textBoxChemester.Text = "";
                textBoxYear.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSubjects.SelectedItems.Count == 1)
                {
                    SubjectsSet subjectsSet = listViewSubjects.SelectedItems[0].Tag as SubjectsSet;
                    Program.ekzDb.SubjectsSet.Remove(subjectsSet);
                    Program.ekzDb.SaveChanges();
                    ShowSubjects();
                }
                textBoxName.Text = "";
                textBoxPrepod.Text = "";
                textBoxChemester.Text = "";
                textBoxYear.Text = "";
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBoxChemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace 
            {
                e.Handled = true;
            }
        }
    }
}
