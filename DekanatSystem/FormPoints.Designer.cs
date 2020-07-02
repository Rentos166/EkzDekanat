namespace DekanatSystem
{
    partial class FormPoints
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStudent = new System.Windows.Forms.Label();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxPoint = new System.Windows.Forms.TextBox();
            this.labelPoint = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewPoint = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.Point = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudent.Location = new System.Drawing.Point(7, 185);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(66, 19);
            this.labelStudent.TabIndex = 36;
            this.labelStudent.Text = "Студент:";
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.comboBoxStudent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(11, 207);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(440, 26);
            this.comboBoxStudent.TabIndex = 35;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubject.Location = new System.Drawing.Point(7, 137);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(69, 19);
            this.labelSubject.TabIndex = 32;
            this.labelSubject.Text = "Занятие:";
            // 
            // textBoxPoint
            // 
            this.textBoxPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.textBoxPoint.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPoint.Location = new System.Drawing.Point(11, 257);
            this.textBoxPoint.Name = "textBoxPoint";
            this.textBoxPoint.Size = new System.Drawing.Size(440, 26);
            this.textBoxPoint.TabIndex = 31;
            this.textBoxPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPoint_KeyPress);
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint.Location = new System.Drawing.Point(6, 235);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(46, 19);
            this.labelPoint.TabIndex = 30;
            this.labelPoint.Text = "Балл:";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(1069, 390);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(299, 36);
            this.buttonDel.TabIndex = 28;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(764, 390);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(299, 36);
            this.buttonEdit.TabIndex = 27;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(457, 390);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(299, 36);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewPoint
            // 
            this.listViewPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.listViewPoint.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.IdSubject,
            this.NameSubject,
            this.Teacher,
            this.IdStudent,
            this.NameStudent,
            this.Group,
            this.Point});
            this.listViewPoint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewPoint.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewPoint.FullRowSelect = true;
            this.listViewPoint.GridLines = true;
            this.listViewPoint.HideSelection = false;
            this.listViewPoint.Location = new System.Drawing.Point(457, 141);
            this.listViewPoint.Name = "listViewPoint";
            this.listViewPoint.Size = new System.Drawing.Size(911, 245);
            this.listViewPoint.TabIndex = 25;
            this.listViewPoint.UseCompatibleStateImageBehavior = false;
            this.listViewPoint.View = System.Windows.Forms.View.Details;
            this.listViewPoint.SelectedIndexChanged += new System.EventHandler(this.listViewPoint_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 41;
            // 
            // IdSubject
            // 
            this.IdSubject.Text = "ID Занятия";
            this.IdSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IdSubject.Width = 93;
            // 
            // NameSubject
            // 
            this.NameSubject.Text = "Наименование предмета";
            this.NameSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameSubject.Width = 197;
            // 
            // Teacher
            // 
            this.Teacher.Text = "Преподаватель";
            this.Teacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Teacher.Width = 142;
            // 
            // IdStudent
            // 
            this.IdStudent.Text = "ID Студента";
            this.IdStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IdStudent.Width = 92;
            // 
            // NameStudent
            // 
            this.NameStudent.Text = "ФИО Студента";
            this.NameStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameStudent.Width = 149;
            // 
            // Group
            // 
            this.Group.Text = "Группа";
            this.Group.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Group.Width = 125;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::DekanatSystem.Properties.Resources.Логотип;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(1356, 123);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 29;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Point
            // 
            this.Point.Text = "Балл";
            this.Point.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Point.Width = 66;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.comboBoxSubject.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(12, 159);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(439, 26);
            this.comboBoxSubject.TabIndex = 38;
            // 
            // FormPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(1378, 438);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.textBoxPoint);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewPoint);
            this.Name = "FormPoints";
            this.Text = "FormPoints";
            this.Load += new System.EventHandler(this.FormPoints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxPoint;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewPoint;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader IdSubject;
        private System.Windows.Forms.ColumnHeader NameSubject;
        private System.Windows.Forms.ColumnHeader Teacher;
        private System.Windows.Forms.ColumnHeader IdStudent;
        private System.Windows.Forms.ColumnHeader NameStudent;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.ColumnHeader Point;
        private System.Windows.Forms.ComboBox comboBoxSubject;
    }
}