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
using System.Xml.Linq;

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
            public int _TaskId { get; set; }
            public string _TaskName { get; set; }
            public string _Description { get; set; }
            public DateTime _DueDate { get; set; }
            public int _CategoryId { get; set; }
            public int _PriorityId { get; set; }

            public Task()
            {
            }

            public Task(int taskId, string TaskName,
                        string description, DateTime dueDate, 
                        int categoryId, int priorityId)
            {
                _TaskId = taskId;
                _TaskName = TaskName;
                _Description = description;
                _DueDate = dueDate;
                _CategoryId = categoryId;
                _PriorityId = priorityId;
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

        }

        private void btn_all_task_Click(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void btn_add_task_Click(object sender, EventArgs e)
        {
            // Show a new form for adding a task
            f_add_task addTaskForm = new f_add_task();
            addTaskForm.Show();
        }

        void fillgrid(string s = "exec GetAllTasks")
        {

            cmd.CommandText = s;
            cmd.Connection = conn;
            ad.SelectCommand = cmd;
            ds.Clear();
            ad.Fill(ds, "T1");
            dataGridView_mainPage.DataBindings.Clear();
            dataGridView_mainPage.DataBindings.Add("datasource", ds, "T1");
        }

        private void btn_today_task_Click(object sender, EventArgs e)
        {
            fillgrid("exec GetTodaysTasks");
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            Edit_Task edit_Task = new Edit_Task();
            edit_Task.Show();
        }
    }
}


