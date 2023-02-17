using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Management
{
    public partial class Edit_Task : Form
    {
        public Edit_Task()
        {
            InitializeComponent();
        }



        SqlDataAdapter ad = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection();
        DataSet ds = new DataSet();



        private void Edit_Task_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
"AttachDbFilename=\"C:\\Users\\Mahdi Khalil Nejad\\source\\repos\\Task Management\\TM Database.mdf\";" +
"Integrated Security=True";
            conn.Open();


            SqlCommand cmd = new SqlCommand("SELECT TaskID, TaskName FROM dbo.Tasks", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbTaskName.DataSource = dt;
            cmbTaskName.DisplayMember = "TaskName";

            string comdString = "SELECT TaskID FROM dbo.Tasks WHERE TaskName = " 
                                + "'" + cmbTaskName.Text + "'".ToString();
            SqlCommand cmd4 = new SqlCommand(comdString, conn);
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            DataRow dr4 = dt4.Rows[0];
            lblTaskIdShow.Text = dr4["TaskId"].ToString();
            //if (dt.Rows.Count > 0)
            //{
            //    // get the first row of data
            //    DataRow dr = dt.Rows[0];
            //    // set the label text to the value of the "TaskName" column
            //    lblTaskName.Text = dr["TaskID"].ToString();
            //}


            SqlCommand cmd2 = new SqlCommand("SELECT PriorityName FROM dbo.Priorities", conn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmb_priority.DataSource = dt2;
            cmb_priority.DisplayMember = "PriorityName";

            SqlCommand cmd3 = new SqlCommand("SELECT CategoryName FROM dbo.Categories", conn);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            cmb_category.DataSource = dt3;
            cmb_category.DisplayMember = "CategoryName";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            int priority;
            if (cmb_priority.Text == "High") { priority = 1; }
            else if (cmb_priority.Text == "Normal") { priority = 2; }
            else { priority = 3; }

            int category = 0;
            if (cmb_category.Text == "Work") { category = 1; }
            else if (cmb_category.Text == "Personal") { category = 2; }
            else if (cmb_category.Text == "Family") { category = 3; }
            else if (cmb_category.Text == "Home") { category = 4; }
            else { category = 5; }


            if (string.IsNullOrEmpty(cmbTaskName.Text) ||
                string.IsNullOrEmpty(txt_description.Text) ||
                string.IsNullOrEmpty(dateTimePicker1.Text) ||
                string.IsNullOrEmpty(cmb_category.Text) ||
                string.IsNullOrEmpty(cmb_priority.Text)
                )
            {
                MessageBox.Show("Please fill in all required fields!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlCommand command =
                new SqlCommand("exec UpdateTask" +
                " @TaskId, @TaskName, @TaskDescription," +
                " @TaskDueDate, @PriorityID, @CategoryID, @Steps, @Days", conn))
            {
                command.Parameters.AddWithValue("@TaskName", cmbTaskName.Text);
                command.Parameters.AddWithValue("@TaskDescription", txt_description.Text);
                command.Parameters.AddWithValue("@TaskDueDate", dateTimePicker1.Value.Date);
                command.Parameters.AddWithValue("@PriorityID", priority);
                command.Parameters.AddWithValue("@CategoryID", category);
                command.Parameters.AddWithValue("@Steps", int.Parse(txtSteps.Text));
                command.Parameters.AddWithValue("@TaskId", int.Parse(lblTaskIdShow.Text));
                command.Parameters.AddWithValue("@Days", int.Parse(txtDays.Text));
                command.ExecuteNonQuery();
            };
            this.Close();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTaskName_SelectedIndexChanged(object sender, EventArgs e)
        {

            string comdString = "SELECT TaskID FROM dbo.Tasks WHERE TaskName = "
                                + "'" + cmbTaskName.Text + "'".ToString();
            SqlCommand cmd5 = new SqlCommand(comdString, conn);
            SqlDataAdapter da4 = new SqlDataAdapter(cmd5);
            DataTable dt5 = new DataTable();
            da4.Fill(dt5);
            if (dt5.Rows.Count > 0)
            {
                DataRow dr5 = dt5.Rows[0];
                lblTaskIdShow.Text = dr5["TaskId"].ToString();
            }
        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value; // current date and time
            int daysToAdd = int.Parse(txtDays.Text); // number of days to add
            DateTime newDate = date.AddDays(daysToAdd); // add days to the current date ;

            if (newDate != date)
            {
                lblDeadLineShow.Text = newDate.ToString();
            }
        }
    }
}
