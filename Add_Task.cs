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
    public partial class f_add_task : Form
    {
        public f_add_task()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        SqlDataAdapter ad = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection();
        DataSet ds = new DataSet();

        private void f_add_task_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
        "AttachDbFilename=\"C:\\Users\\Mahdi Khalil Nejad\\source\\repos\\Task Management\\TM Database.mdf\";" +
        "Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT CategoryID, CategoryName FROM dbo.Categories", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_category.DataSource = dt;
            cmb_category.DisplayMember = "CategoryName";

            SqlCommand cmd2 = new SqlCommand("SELECT PriorityName FROM dbo.Priorities", conn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            cmb_priority.DataSource = dt2;
            cmb_priority.DisplayMember = "PriorityName";


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

            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = conn;
            //cmd.CommandText = "SELECT CategoryID FROM dbo.Categories WHERE CategoryName = " + " ' " + cmb_category.Text + " ' ";
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show(dt.Rows[0][0].ToString());
            //    category = int.Parse(dt.Rows[0][0].ToString());
            //};


            if (string.IsNullOrEmpty(txt_task_name.Text) ||
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
                new SqlCommand("exec InsertTask" +
                " @TaskName, @TaskDescription, @TaskDueDate, @PriorityID, @CategoryID", conn))
            {
                command.Parameters.AddWithValue("@TaskName", txt_task_name.Text);
                command.Parameters.AddWithValue("@TaskDescription", txt_description.Text);
                command.Parameters.AddWithValue("@TaskDueDate", dateTimePicker1.Value.Date);
                command.Parameters.AddWithValue("@PriorityID", priority);
                command.Parameters.AddWithValue("@CategoryID", category);
                command.ExecuteNonQuery();
            };
            using (SqlCommand command =
                new SqlCommand ("exec InsertNote @NoteText", conn))
            {
                command.Parameters.AddWithValue("@NoteText", txtNote.Text);
                command.ExecuteNonQuery ();
            }
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}