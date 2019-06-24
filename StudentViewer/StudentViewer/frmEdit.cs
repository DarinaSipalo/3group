using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StudentViewer
{
    public partial class frmEdit : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbCommand cmd;

        public frmEdit()
        {
            InitializeComponent();

            this.Text = "Редагувати дані про студента: " + frmMain.selectedStudentName + ", " + frmMain.selectedID;

            txtStartDate.Text = frmMain.selectedStart_Date;
            txtStartDate.Enabled = false;

            txtStudentName.Text = frmMain.selectedStudentName;
            txtStudentGroup.Text = frmMain.selectedStudentGroup;
            txtProjectProgress.Text = frmMain.selectedProgress;
            txtDiplomName.Text = frmMain.selectedDiplomName;
            txtIntroduction.Text = frmMain.selectedIntroduction;
            txtParagraphs.Text = frmMain.selectedParagraphs;
            txtConclusions.Text = frmMain.selectedConclusions;
            txtLitreture.Text = frmMain.selectedLitreture;
            txtApplications.Text = frmMain.selectedApplications;

            txtEndDate.Text = frmMain.selectedEnd_Date;

            txtMinProgramRequie.Text = frmMain.selectedMaxRequire;
            txtMaxProgramRequie.Text = frmMain.selectedMinRequire;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStudentName.Text)) {
                if (!string.IsNullOrEmpty(txtStudentGroup.Text)) {
                    if (!string.IsNullOrEmpty(txtProjectProgress.Text)) {
                        if (!string.IsNullOrEmpty(txtDiplomName.Text)) {
                            conn.Open();

                            cmd = new OleDbCommand("UPDATE Students SET Student_Name = '" + txtStudentName.Text + 
                                "', Student_Group = '" + txtStudentGroup.Text + 
                                "', Project_Progress = '" + txtProjectProgress.Text + 
                                "', DIplom_Name = '" + txtDiplomName.Text + 
                                "', Introduction = '" + txtIntroduction.Text + 
                                "', Paragraphs = '" + txtParagraphs.Text + 
                                "', Conclusions = '" + txtConclusions.Text + 
                                "', Litreture = '" + txtLitreture.Text + 
                                "', Applications = '" + txtApplications.Text + 
                                "', End_Date = '" + txtEndDate.Text + 
                                "', Min_Program_Requie = '" + txtMinProgramRequie.Text + 
                                "', Max_Program_Requie = '" + txtMaxProgramRequie.Text + 
                                "' WHERE Student_Name = '" + frmMain.selectedStudentName + "'", conn);

                            cmd.ExecuteNonQuery();

                            conn.Close();

                            this.Close();
                        } else {
                            MessageBox.Show("Поле з темою дипломної роботи студента пусте! Заповніть!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            txtDiplomName.Focus();
                        }
                    } else{
                        MessageBox.Show("Поле з прогресом студента пусте! Заповніть!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtProjectProgress.Focus();
                    }
                } else {
                    MessageBox.Show("Поле з групою студента пусте! Заповніть!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtStudentGroup.Focus();
                }
            } else {
                MessageBox.Show("Поле з ім'ям студента пусте! Заповніть!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtStudentName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}