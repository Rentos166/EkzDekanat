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
    public partial class FormGroups : Form
    {
        void ShowGroups()
        {
            listViewGroups.Items.Clear();
            foreach (GroupsSet groupsSet in Program.ekzDb.GroupsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    groupsSet.Id.ToString(),
                    groupsSet.Name
                });
                item.Tag = groupsSet;
                listViewGroups.Items.Add(item);
            }
            listViewGroups.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormGroups()
        {
            InitializeComponent();
            ShowGroups();
        }

        private void FormGroups_Load(object sender, EventArgs e)
        {

        }
        //Кнопка "Создать"
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                GroupsSet groupsSet = new GroupsSet();
                groupsSet.Name = textBoxName.Text;
                Program.ekzDb.GroupsSet.Add(groupsSet);
                //Сохраняем изменения в модели itDb (экземпляр которой был создан ранее)
                Program.ekzDb.SaveChanges();
                ShowGroups();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Кнопка "Изменить"
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewGroups.SelectedItems.Count == 1)
                {
                    GroupsSet groupsSet = listViewGroups.SelectedItems[0].Tag as GroupsSet;
                    groupsSet.Name = textBoxName.Text;
                    Program.ekzDb.SaveChanges();
                    ShowGroups();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Вывод информации
        private void listViewGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGroups.SelectedItems.Count == 1)
            {
                GroupsSet groupsSet = listViewGroups.SelectedItems[0].Tag as GroupsSet;
                textBoxName.Text = groupsSet.Name;
            }
            else
            {
                textBoxName.Text = "";
            }
        }
        //Кнопка "Удалить"
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewGroups.SelectedItems.Count == 1)
                {
                    GroupsSet groupsSet = listViewGroups.SelectedItems[0].Tag as GroupsSet;
                    Program.ekzDb.GroupsSet.Remove(groupsSet);
                    Program.ekzDb.SaveChanges();
                    ShowGroups();
                }
                textBoxName.Text = "";
            }
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
