using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StudentViewer
{
    public partial class frmAdd : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbCommand cmd;

        public frmAdd()
        {
            InitializeComponent();

            this.Text = "Додати студента";

            ////txtStartDate.Text = DateTime.Now.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStudentName.Text)) {
                if (!string.IsNullOrEmpty(txtStudentGroup.Text)) {
                    if (!string.IsNullOrEmpty(txtProjectProgress.Text)) {
                        if (!string.IsNullOrEmpty(txtDiplomName.Text)) {
                            conn.Open();

                            cmd = new OleDbCommand("INSERT INTO Students (Student_Name, Student_Group, Project_Progress, DIplom_Name) VALUES ('" + txtStudentName.Text + "', '" + txtStudentGroup.Text + "', '" + txtProjectProgress.Text + "', '" + txtDiplomName.Text + "')", conn);

                            cmd.ExecuteNonQuery();

                            conn.Close();

                            this.Close();
                        } else {
                            MessageBox.Show("Поле з темою дипломної роботи пусте! Заповніть!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            txtStudentName.Focus();
                        }
                    } else {
                        MessageBox.Show("Поле з прогресом студента пусте! Заповніть!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtStudentName.Focus();
                    }
                } else {
                    MessageBox.Show("Поле з групою студента пусте! Заповніть!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtStudentName.Focus();
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