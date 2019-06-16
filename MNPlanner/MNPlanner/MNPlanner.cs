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
        public MNPlanner()
        {
            InitializeComponent();
        }

        MNPlannerClasses.Task t = new MNPlannerClasses.Task();

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

        private void button2_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("New task successfully inserted :)");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        //Method to clear the fields
        public void Clear()
        {
            txtboxTaskName.Text = "";
            cmbTaskFor.Text = "";
        }
    }
}
