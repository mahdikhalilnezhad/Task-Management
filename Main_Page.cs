using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Task_Management
{
    public partial class Main_Page : Form
    {
        SqlDataAdapter ad = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();
        DataSet ds = new DataSet();



        public Main_Page()
        {
            InitializeComponent();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename=\"C:\\Users\\Mahdi Khalil Nejad\\source\\repos\\Task Management\\TM Database.mdf\";" +
                "Integrated Security=True";
            conn.Open();
        }






        //This code writed with OpenAI
        public class Task
        {
            public int TaskId { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime DueDate { get; set; }
            public int CategoryId { get; set; }

            public Task()
            {
            }

            public Task(int taskId, string title, string description, DateTime dueDate, int categoryId)
            {
                TaskId = taskId;
                Title = title;
                Description = description;
                DueDate = dueDate;
                CategoryId = categoryId;
            }
        }

        public class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }

            public Category()
            {
            }

            public Category(int categoryId, string categoryName)
            {
                CategoryId = categoryId;
                CategoryName = categoryName;
            }
        }

        public class Reminder
        {
            public int ReminderId { get; set; }
            public int TaskId { get; set; }
            public DateTime ReminderDate { get; set; }

            public Reminder()
            {
            }

            public Reminder(int reminderId, int taskId, DateTime reminderDate)
            {
                ReminderId = reminderId;
                TaskId = taskId;
                ReminderDate = reminderDate;
            }
        }

        public class Note
        {
            public int NoteId { get; set; }
            public int TaskId { get; set; }
            public string Content { get; set; }

            public Note()
            {
            }

            public Note(int noteId, int taskId, string content)
            {
                NoteId = noteId;
                TaskId = taskId;
                Content = content;
            }
        }

        public class Database
        {
            private readonly string _connectionString;

            public Database(string connectionString)
            {
                _connectionString = connectionString;
            }

            public void AddTask(Task task)
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand("INSERT INTO dbo.Tasks (Title, Description, DueDate, CategoryId) VALUES (@Title, @Description, @DueDate, @CategoryId)", connection))
                    {
                        command.Parameters.AddWithValue("@Title", task.Title);
                        command.Parameters.AddWithValue("@Description", task.Description);
                        command.Parameters.AddWithValue("@DueDate", task.DueDate);
                        command.Parameters.AddWithValue("@CategoryId", task.CategoryId);

                        command.ExecuteNonQuery();
                    }
                }
            }

            // Similar methods can be added for adding, updating, and deleting categories, reminders, and notes
        }

        private void btn_all_task_Click(object sender, EventArgs e)
        {
            //conn = new SqlConnection("Data Source=(local);Initial Catalog=TaskDB;Integrated Security=True");
            //conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Tasks", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable taskData = new DataTable();
            adapter.Fill(taskData);

            // You can use a DataGridView or a ListView to display the task data
            lv_task_list_viwe.Items.Clear();
            foreach (DataRow row in taskData.Rows)
            {
                ListViewItem item = new ListViewItem(row["TaskName"].ToString());
                item.SubItems.Add(row["DueDate"].ToString());
                item.SubItems.Add(row["Priority"].ToString());
                item.SubItems.Add(row["Status"].ToString());
                lv_task_list_viwe.Items.Add(item);
            }

            //conn.Close();
        }

        private void btn_add_task_Click(object sender, EventArgs e)
        {

           
            // Show a new form for adding a task
            f_add_task addTaskForm = new f_add_task();
            addTaskForm.Show();
        }
    }
}


