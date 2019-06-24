namespace StudentViewer
{
    partial class frmMain
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
            this.listStudents = new System.Windows.Forms.ListView();
            this.columnStudentNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDiplomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIntroduction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnParagraphs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnConclusions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLitreture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnApplications = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlControlPanel = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.columnMinRequire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaxRequier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listStudents
            // 
            this.listStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnStudentNum,
            this.columnStudentName,
            this.columnGroup,
            this.columnProgress,
            this.columnDiplomName,
            this.columnStartDate,
            this.columnIntroduction,
            this.columnParagraphs,
            this.columnConclusions,
            this.columnLitreture,
            this.columnApplications,
            this.columnEndDate,
            this.columnMinRequire,
            this.columnMaxRequier});
            this.listStudents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listStudents.HideSelection = false;
            this.listStudents.Location = new System.Drawing.Point(53, -1);
            this.listStudents.MultiSelect = false;
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(966, 520);
            this.listStudents.TabIndex = 0;
            this.listStudents.UseCompatibleStateImageBehavior = false;
            this.listStudents.View = System.Windows.Forms.View.Details;
            this.listStudents.SelectedIndexChanged += new System.EventHandler(this.listStudents_SelectedIndexChanged);
            // 
            // columnStudentNum
            // 
            this.columnStudentNum.Text = "№ Студента";
            this.columnStudentNum.Width = 200;
            // 
            // columnStudentName
            // 
            this.columnStudentName.Text = "Ім\'я студента";
            this.columnStudentName.Width = 160;
            // 
            // columnGroup
            // 
            this.columnGroup.Text = "Група";
            this.columnGroup.Width = 100;
            // 
            // columnProgress
            // 
            this.columnProgress.Text = "Прогрес проекту";
            this.columnProgress.Width = 170;
            // 
            // columnDiplomName
            // 
            this.columnDiplomName.Text = "Назва дипломного проекту";
            this.columnDiplomName.Width = 300;
            // 
            // columnStartDate
            // 
            this.columnStartDate.Text = "Початок";
            this.columnStartDate.Width = 0;
            // 
            // columnIntroduction
            // 
            this.columnIntroduction.Text = "Вступ";
            this.columnIntroduction.Width = 0;
            // 
            // columnParagraphs
            // 
            this.columnParagraphs.Text = "Параграф";
            this.columnParagraphs.Width = 0;
            // 
            // columnConclusions
            // 
            this.columnConclusions.Text = "Висновок";
            this.columnConclusions.Width = 0;
            // 
            // columnLitreture
            // 
            this.columnLitreture.Text = "Література";
            this.columnLitreture.Width = 0;
            // 
            // columnApplications
            // 
            this.columnApplications.Text = "Додатки";
            this.columnApplications.Width = 0;
            // 
            // columnEndDate
            // 
            this.columnEndDate.Text = "Кінець";
            this.columnEndDate.Width = 0;
            // 
            // pnlControlPanel
            // 
            this.pnlControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlControlPanel.Controls.Add(this.btnRemove);
            this.pnlControlPanel.Controls.Add(this.btnEdit);
            this.pnlControlPanel.Controls.Add(this.btnAdd);
            this.pnlControlPanel.Location = new System.Drawing.Point(-1, 0);
            this.pnlControlPanel.Name = "pnlControlPanel";
            this.pnlControlPanel.Size = new System.Drawing.Size(55, 505);
            this.pnlControlPanel.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(5, 97);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(45, 40);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "✕";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(5, 51);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "✎";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // columnMinRequire
            // 
            this.columnMinRequire.Text = "Мінімальні вимоги";
            this.columnMinRequire.Width = 0;
            // 
            // columnMaxRequier
            // 
            this.columnMaxRequier.Text = "Усі вимоги";
            this.columnMaxRequier.Width = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 505);
            this.Controls.Add(this.pnlControlPanel);
            this.Controls.Add(this.listStudents);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "%title%";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listStudents;
        private System.Windows.Forms.ColumnHeader columnStudentNum;
        private System.Windows.Forms.ColumnHeader columnStudentName;
        private System.Windows.Forms.ColumnHeader columnGroup;
        private System.Windows.Forms.Panel pnlControlPanel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ColumnHeader columnProgress;
        private System.Windows.Forms.ColumnHeader columnDiplomName;
        private System.Windows.Forms.ColumnHeader columnStartDate;
        private System.Windows.Forms.ColumnHeader columnIntroduction;
        private System.Windows.Forms.ColumnHeader columnParagraphs;
        private System.Windows.Forms.ColumnHeader columnConclusions;
        private System.Windows.Forms.ColumnHeader columnLitreture;
        private System.Windows.Forms.ColumnHeader columnApplications;
        private System.Windows.Forms.ColumnHeader columnEndDate;
        private System.Windows.Forms.ColumnHeader columnMinRequire;
        private System.Windows.Forms.ColumnHeader columnMaxRequier;
    }
}

