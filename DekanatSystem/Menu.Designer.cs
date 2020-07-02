namespace DekanatSystem
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenGroups = new System.Windows.Forms.Button();
            this.buttonOpenStudents = new System.Windows.Forms.Button();
            this.buttonOpenSubject = new System.Windows.Forms.Button();
            this.buttonOpenPoints = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenGroups
            // 
            this.buttonOpenGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonOpenGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenGroups.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenGroups.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenGroups.Location = new System.Drawing.Point(12, 126);
            this.buttonOpenGroups.Name = "buttonOpenGroups";
            this.buttonOpenGroups.Size = new System.Drawing.Size(250, 48);
            this.buttonOpenGroups.TabIndex = 0;
            this.buttonOpenGroups.Text = "Группы";
            this.buttonOpenGroups.UseVisualStyleBackColor = false;
            this.buttonOpenGroups.Click += new System.EventHandler(this.buttonOpenGroups_Click);
            // 
            // buttonOpenStudents
            // 
            this.buttonOpenStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonOpenStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenStudents.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenStudents.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenStudents.Location = new System.Drawing.Point(11, 180);
            this.buttonOpenStudents.Name = "buttonOpenStudents";
            this.buttonOpenStudents.Size = new System.Drawing.Size(250, 48);
            this.buttonOpenStudents.TabIndex = 1;
            this.buttonOpenStudents.Text = "Студенты";
            this.buttonOpenStudents.UseVisualStyleBackColor = false;
            this.buttonOpenStudents.Click += new System.EventHandler(this.buttonOpenStudents_Click);
            // 
            // buttonOpenSubject
            // 
            this.buttonOpenSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonOpenSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSubject.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenSubject.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenSubject.Location = new System.Drawing.Point(11, 234);
            this.buttonOpenSubject.Name = "buttonOpenSubject";
            this.buttonOpenSubject.Size = new System.Drawing.Size(250, 48);
            this.buttonOpenSubject.TabIndex = 2;
            this.buttonOpenSubject.Text = "Занятия";
            this.buttonOpenSubject.UseVisualStyleBackColor = false;
            this.buttonOpenSubject.Click += new System.EventHandler(this.buttonOpenSubject_Click);
            // 
            // buttonOpenPoints
            // 
            this.buttonOpenPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonOpenPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenPoints.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenPoints.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenPoints.Location = new System.Drawing.Point(11, 288);
            this.buttonOpenPoints.Name = "buttonOpenPoints";
            this.buttonOpenPoints.Size = new System.Drawing.Size(250, 48);
            this.buttonOpenPoints.TabIndex = 3;
            this.buttonOpenPoints.Text = "Баллы";
            this.buttonOpenPoints.UseVisualStyleBackColor = false;
            this.buttonOpenPoints.Click += new System.EventHandler(this.buttonOpenPoints_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::DekanatSystem.Properties.Resources.Логотип;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(250, 108);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(272, 350);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonOpenPoints);
            this.Controls.Add(this.buttonOpenSubject);
            this.Controls.Add(this.buttonOpenStudents);
            this.Controls.Add(this.buttonOpenGroups);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenGroups;
        private System.Windows.Forms.Button buttonOpenStudents;
        private System.Windows.Forms.Button buttonOpenSubject;
        private System.Windows.Forms.Button buttonOpenPoints;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

