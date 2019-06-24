namespace StudentViewer
{
    partial class frmEdit
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
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentGroup = new System.Windows.Forms.TextBox();
            this.txtDiplomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtProjectProgress = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtIntroduction = new System.Windows.Forms.TextBox();
            this.txtParagraphs = new System.Windows.Forms.TextBox();
            this.txtConclusions = new System.Windows.Forms.TextBox();
            this.txtLitreture = new System.Windows.Forms.TextBox();
            this.txtApplications = new System.Windows.Forms.TextBox();
            this.txtMaxProgramRequie = new System.Windows.Forms.TextBox();
            this.txtMinProgramRequie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(225, 96);
            this.txtStudentName.MaxLength = 200;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(133, 20);
            this.txtStudentName.TabIndex = 0;
            // 
            // txtStudentGroup
            // 
            this.txtStudentGroup.Location = new System.Drawing.Point(225, 170);
            this.txtStudentGroup.MaxLength = 2;
            this.txtStudentGroup.Name = "txtStudentGroup";
            this.txtStudentGroup.Size = new System.Drawing.Size(133, 20);
            this.txtStudentGroup.TabIndex = 1;
            // 
            // txtDiplomName
            // 
            this.txtDiplomName.Location = new System.Drawing.Point(225, 312);
            this.txtDiplomName.MaxLength = 200;
            this.txtDiplomName.Name = "txtDiplomName";
            this.txtDiplomName.Size = new System.Drawing.Size(133, 20);
            this.txtDiplomName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата початку дипломного проекту";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(332, 496);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 32);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Оновити";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(450, 496);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtProjectProgress
            // 
            this.txtProjectProgress.Location = new System.Drawing.Point(225, 239);
            this.txtProjectProgress.MaxLength = 4;
            this.txtProjectProgress.Name = "txtProjectProgress";
            this.txtProjectProgress.Size = new System.Drawing.Size(133, 20);
            this.txtProjectProgress.TabIndex = 6;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(722, 239);
            this.txtEndDate.MaxLength = 50;
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(133, 20);
            this.txtEndDate.TabIndex = 15;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(225, 25);
            this.txtStartDate.MaxLength = 50;
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(133, 20);
            this.txtStartDate.TabIndex = 16;
            // 
            // txtIntroduction
            // 
            this.txtIntroduction.Location = new System.Drawing.Point(225, 389);
            this.txtIntroduction.MaxLength = 3;
            this.txtIntroduction.Name = "txtIntroduction";
            this.txtIntroduction.Size = new System.Drawing.Size(133, 20);
            this.txtIntroduction.TabIndex = 17;
            // 
            // txtParagraphs
            // 
            this.txtParagraphs.Location = new System.Drawing.Point(225, 451);
            this.txtParagraphs.MaxLength = 3;
            this.txtParagraphs.Name = "txtParagraphs";
            this.txtParagraphs.Size = new System.Drawing.Size(133, 20);
            this.txtParagraphs.TabIndex = 18;
            // 
            // txtConclusions
            // 
            this.txtConclusions.Location = new System.Drawing.Point(722, 25);
            this.txtConclusions.MaxLength = 3;
            this.txtConclusions.Name = "txtConclusions";
            this.txtConclusions.Size = new System.Drawing.Size(133, 20);
            this.txtConclusions.TabIndex = 19;
            // 
            // txtLitreture
            // 
            this.txtLitreture.Location = new System.Drawing.Point(722, 96);
            this.txtLitreture.MaxLength = 3;
            this.txtLitreture.Name = "txtLitreture";
            this.txtLitreture.Size = new System.Drawing.Size(133, 20);
            this.txtLitreture.TabIndex = 20;
            // 
            // txtApplications
            // 
            this.txtApplications.Location = new System.Drawing.Point(722, 170);
            this.txtApplications.MaxLength = 3;
            this.txtApplications.Name = "txtApplications";
            this.txtApplications.Size = new System.Drawing.Size(133, 20);
            this.txtApplications.TabIndex = 21;
            // 
            // txtMaxProgramRequie
            // 
            this.txtMaxProgramRequie.Location = new System.Drawing.Point(722, 389);
            this.txtMaxProgramRequie.MaxLength = 3;
            this.txtMaxProgramRequie.Name = "txtMaxProgramRequie";
            this.txtMaxProgramRequie.Size = new System.Drawing.Size(133, 20);
            this.txtMaxProgramRequie.TabIndex = 22;
            // 
            // txtMinProgramRequie
            // 
            this.txtMinProgramRequie.Location = new System.Drawing.Point(722, 312);
            this.txtMinProgramRequie.MaxLength = 3;
            this.txtMinProgramRequie.Name = "txtMinProgramRequie";
            this.txtMinProgramRequie.Size = new System.Drawing.Size(133, 20);
            this.txtMinProgramRequie.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Прізвище та ім\'я студента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Група студента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Тема дипломного проекту";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Прогрес студента";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Вступ ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Розділи дипломного проекту";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Висновок";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Література";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Додатки";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(490, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Дата кінця дипломного проекту";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(490, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Мінімальні вимоги до програми виконані";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(490, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Всі вимоги до програми виконані";
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 539);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinProgramRequie);
            this.Controls.Add(this.txtMaxProgramRequie);
            this.Controls.Add(this.txtApplications);
            this.Controls.Add(this.txtLitreture);
            this.Controls.Add(this.txtConclusions);
            this.Controls.Add(this.txtParagraphs);
            this.Controls.Add(this.txtIntroduction);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtProjectProgress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiplomName);
            this.Controls.Add(this.txtStudentGroup);
            this.Controls.Add(this.txtStudentName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "%title%";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentGroup;
        private System.Windows.Forms.TextBox txtDiplomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtProjectProgress;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtIntroduction;
        private System.Windows.Forms.TextBox txtParagraphs;
        private System.Windows.Forms.TextBox txtConclusions;
        private System.Windows.Forms.TextBox txtLitreture;
        private System.Windows.Forms.TextBox txtApplications;
        private System.Windows.Forms.TextBox txtMaxProgramRequie;
        private System.Windows.Forms.TextBox txtMinProgramRequie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}