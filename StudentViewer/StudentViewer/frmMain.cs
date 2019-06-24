using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StudentViewer
{
    public partial class frmMain : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBpath);
        OleDbDataAdapter oda;
        OleDbCommand cmd;
        DataTable dt;

        public static string DBpath = Application.StartupPath + "\\Auto.mdb";
        public static string selectedID, selectedStudentName, selectedStudentGroup, selectedProgress, selectedDiplomName, selectedStart_Date, selectedIntroduction, selectedParagraphs, selectedConclusions, selectedLitreture, selectedApplications, selectedEnd_Date, selectedMinRequire, selectedMaxRequire;

        public frmMain()
        {
            InitializeComponent();

            this.Text = "Огляд студентів";

            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new frmAdd()).ShowDialog();

            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            (new frmEdit()).ShowDialog();

            LoadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedID != null) {
                var answer = MessageBox.Show("Ви дійсно бажаєте видлити '" + selectedStudentName + "'?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes) {
                    Delete();

                    LoadData();
                } else {
                    LoadData();
                }
            } 
        }

        private void listStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listStudents.SelectedItems.Count != 0) {
                selectedID = listStudents.SelectedItems[0].SubItems[0].Text;
                selectedStudentName = listStudents.SelectedItems[0].SubItems[1].Text;
                selectedStudentGroup = listStudents.SelectedItems[0].SubItems[2].Text;
                selectedProgress = listStudents.SelectedItems[0].SubItems[3].Text;
                selectedDiplomName = listStudents.SelectedItems[0].SubItems[4].Text;
                selectedStart_Date = listStudents.SelectedItems[0].SubItems[5].Text;
                selectedIntroduction = listStudents.SelectedItems[0].SubItems[6].Text;
                selectedParagraphs = listStudents.SelectedItems[0].SubItems[7].Text;
                selectedConclusions = listStudents.SelectedItems[0].SubItems[8].Text;
                selectedLitreture = listStudents.SelectedItems[0].SubItems[9].Text;
                selectedApplications = listStudents.SelectedItems[0].SubItems[10].Text;
                selectedEnd_Date = listStudents.SelectedItems[0].SubItems[11].Text;
                selectedMinRequire = listStudents.SelectedItems[0].SubItems[12].Text;
                selectedMaxRequire = listStudents.SelectedItems[0].SubItems[13].Text;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();

            System.Environment.Exit(0);
        }

        private void LoadData()
        {
            try {
                conn.Open();

                oda = new OleDbDataAdapter("SELECT * FROM Students", conn);
                dt = new DataTable();

                oda.Fill(dt);

                listStudents.Items.Clear();;

                int itemNum = 1;

                foreach (DataRow row in dt.Rows) {
                    ListViewItem item = new ListViewItem(Convert.ToString(itemNum++));

                    item.SubItems.Add(row["Student_Name"].ToString());
                    item.SubItems.Add(row["Student_Group"].ToString());
                    item.SubItems.Add(row["Project_Progress"].ToString());
                    item.SubItems.Add(row["Diplom_Name"].ToString());
                    item.SubItems.Add(row["Start_Date"].ToString());
                    item.SubItems.Add(row["Introduction"].ToString());
                    item.SubItems.Add(row["Paragraphs"].ToString());
                    item.SubItems.Add(row["Conclusions"].ToString());
                    item.SubItems.Add(row["Litreture"].ToString());
                    item.SubItems.Add(row["Applications"].ToString());
                    item.SubItems.Add(row["End_Date"].ToString());
                    item.SubItems.Add(row["Min_Program_Requie"].ToString());
                    item.SubItems.Add(row["Max_Program_Requie"].ToString());

                    listStudents.Items.Add(item);
                }

                conn.Close();
            } catch (Exception) {
                MessageBox.Show("База даних працює некоректно!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete()
        {
            try {
                if (listStudents.SelectedIndices != null) {
                    foreach (ListViewItem items in listStudents.Items) {
                        conn.Open();

                        cmd = new OleDbCommand("DELETE * FROM Students WHERE Student_Name = '" + selectedStudentName + "'", conn);

                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }

                    LoadData();
                }
            }
            catch (Exception) {
                MessageBox.Show("База даних працює некорректно!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
