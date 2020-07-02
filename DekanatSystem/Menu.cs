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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonOpenGroups_Click(object sender, EventArgs e)
        {
            Form formGroups = new FormGroups();
            formGroups.Show();
        }

        private void buttonOpenStudents_Click(object sender, EventArgs e)
        {
            Form formStudents = new FormStudents();
            formStudents.Show();
        }

        private void buttonOpenSubject_Click(object sender, EventArgs e)
        {
            Form formSubjects = new FormSubjects();
            formSubjects.Show();
        }

        private void buttonOpenPoints_Click(object sender, EventArgs e)
        {
            Form formPoint = new FormPoints();
            formPoint.Show();
        }
    }
}
