using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNPlanner.MNPlannerClasses
{
    class Task
    {
        //Getter and setter properties
        //Acts as a data carrier in our application
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public DateTime TaskDeadline { get; set; }
        public string TaskFor { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting data from Database
        public DataTable Select()
        {
            //Step1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step2: Writing the SQL Query
                string sql = "SELECT * FROM Tasks";
                //Creating SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                //Close connection
                conn.Close();
            }
            return dt;
        }

        //Inserting data into Database
        public bool Insert (Task t)
        {
            //Creating a default return type and setting it's value to false
            bool isSuccess = false;
            //Step1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2: Create an SQL Query to insert data
                string sql = "INSERT INTO Tasks (TaskName, TaskDeadline, TaskFor) VALUES (@TaskName, @TaskDeadline, @TaskFor)";
                //Creating SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add data
                cmd.Parameters.AddWithValue("@TaskName", t.TaskName);
                cmd.Parameters.AddWithValue("@TaskDeadline", t.TaskDeadline);
                cmd.Parameters.AddWithValue("@TaskFor", t.TaskFor);

                //Connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successgully then the value of rows will be greater than zero else it's value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                //Close connection
                conn.Close();
            }
            return isSuccess;
        }

        //Method to update data in database from our application
        public bool Update(Task t)
        {
            //Create default return type and set it's default value to false
            bool isSuccess = false;
            //Step1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2: Create an SQL Query to update the data in the Database
                string sql = "UPDATE Tasks SET TaskName=@TaskName, TaskDeadline=@TaskDeadline, TaskFor=@TaskFor WHERE TaskID=@TaskID";
                //Creating SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add data
                cmd.Parameters.AddWithValue("@TaskName", t.TaskName);
                cmd.Parameters.AddWithValue("@TaskDeadline", t.TaskDeadline);
                cmd.Parameters.AddWithValue("@TaskFor", t.TaskFor);
                
                //Connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successgully then the value of rows will be greater than zero else it's value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Close connection
                conn.Close();
            }
            return isSuccess;
        }

        //Method to delete data from Database
        public bool Delete(Task t)
        {
            //Create default return type and set it's default value to false
            bool isSuccess = false;
            //Step1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2: Create an SQL Query to delete data
                string sql = "DELETE FROM Tasks WHERE TaskID=@TaskID";
                //Creating SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Pass the parameters
                cmd.Parameters.AddWithValue("@TaskID", t.TaskID);

                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successgully then the value of rows will be greater than zero else it's value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Close connection
                conn.Close();
            }
            return isSuccess;
        }
    }
}
