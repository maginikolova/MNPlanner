using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MNPlanner.MNPlannerClasses;

namespace MNPlanner
{
    public partial class MNPlanner : Form
    {
        MNPlannerClasses.Task t = new MNPlannerClasses.Task();

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        public MNPlanner()
        {
            InitializeComponent();
        }

        private void MNPlanner_Load(object sender, EventArgs e)
        {
            //Load data on Data Gridview
            DataTable dt = t.Select();
            dgvTaskList.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the data from the textboxes
            t.TaskID = int.Parse(txtboxTaskID.Text);
            t.TaskName = txtboxTaskName.Text;
            //t.TaskDeadline = DateTime.Parse(dtpTaskDeadline.Text);
            t.TaskDeadline = dtpTaskDeadline.Value;
            t.TaskFor = cmbTaskFor.Text;

            //Update data in database
            bool success = t.Update(t);
            if (success == true)
            {
                //Updated successfully
                MessageBox.Show("Task has been successfully updated :)");
                //Load data on Data Gridview
                DataTable dt = t.Select();
                dgvTaskList.DataSource = dt;
                Clear();
            }
            else
            {
                //Failed to add task
                MessageBox.Show("Failed to update task. Try again :/");
            }

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dtpDeadline_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            t.TaskName = txtboxTaskName.Text;
            t.TaskDeadline = dtpTaskDeadline.Value;
            //t.TaskDeadline = dtpTaskDeadline.Value.ToString("dd-MM-yyyy");
            //t.TaskDeadline = dtpTaskDeadline.Text;
            t.TaskFor = cmbTaskFor.Text;

            //Inserting data into database
            bool success = t.Insert(t);
            if(success == true)
            {
                //Successfully inserted
                MessageBox.Show("New task has been successfully inserted :)");
                Clear();
            }
            else
            {
                //Failed to add task
                MessageBox.Show("Failed to add new task. Try again :/");
            }
            //Load data on Data Gridview
            DataTable dt = t.Select();
            dgvTaskList.DataSource = dt;
        }

        private void lblTaskDeadline_Click(object sender, EventArgs e)
        {

        }

        private void dgvTaskList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTaskList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data drom DataGridView and load it to the textboxes
            //Identify the row on which the mouse has clicked
            int rowIndex = e.RowIndex;
            txtboxTaskID.Text = dgvTaskList.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxTaskName.Text = dgvTaskList.Rows[rowIndex].Cells[1].Value.ToString();
            dtpTaskDeadline.Text = dgvTaskList.Rows[rowIndex].Cells[2].Value.ToString();
            cmbTaskFor.Text = dgvTaskList.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTaskFor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get TaskID from the application
            t.TaskID = Convert.ToInt32(txtboxTaskID.Text);
            bool success = t.Delete(t);
            if (success == true)
            {
                //Successfully deleted
                MessageBox.Show("Task has been successfully deleted :)");
                //Load data on Data Gridview
                DataTable dt = t.Select();
                dgvTaskList.DataSource = dt;
                Clear();
            }
            else
            {
                //Failed to delete task
                MessageBox.Show("Failed to delete task. Try again :/");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Method to clear the fields
        public void Clear()
        {
            txtboxTaskID.Text = "";
            txtboxTaskName.Text = "";
            cmbTaskFor.Text = "";
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the value from the text box
            string keyword = txtboxSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tasks WHERE TaskName LIKE '%" + keyword + "%' OR TaskFor LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvTaskList.DataSource = dt;
        }
    }
}
