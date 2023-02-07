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
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            using (SqlCommand command = 
                new SqlCommand("INSERT INTO dbo.Tasks (TaskName, TaskDescription, TaskDueDate, TaskPriority, CategoryID)" +
                " VALUES (@TaskName, @TaskDescription, @TaskDueDate, @TaskPriority, @CategoryID)", conn))
            {
                command.Parameters.AddWithValue("@TaskName", txt_task_name.Text);
                command.Parameters.AddWithValue("@TaskDescription", txt_description.Text);
                command.Parameters.AddWithValue("@TaskDueDate", txt_due_date.Text);
                command.Parameters.AddWithValue("@TaskPriority", "0" /*cmb_priority.SelectedIndex*/);
                command.Parameters.AddWithValue("@CategoryID", "0" /*cmb_category.SelectedIndex*/);

                command.ExecuteNonQuery();
            }; 
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}