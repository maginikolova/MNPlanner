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
            //t.TaskDeadline = dtpTaskDeadline.Value;
            t.TaskDeadline = dtpTaskDeadline.Value.ToString("dd-MM-yyyy");
            //t.TaskDeadline = dtpTaskDeadline.Text;
            t.TaskFor = cmbTaskFor.Text;

            //Inserting data into database
            bool success = t.Insert(t);
            if(success == true)
            {
                //Successfully inserted
                MessageBox.Show("New task successfully inserted :)");
            }
            else
            {
                //Failed to add task
                MessageBox.Show("Failed to add new task. Try again :/");
            }

        }

        private void lblTaskDeadline_Click(object sender, EventArgs e)
        {

        }
    }
}
