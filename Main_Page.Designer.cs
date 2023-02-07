namespace Task_Management
{
    partial class Main_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_all_task = new System.Windows.Forms.Button();
            this.btn_add_task = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_today_task = new System.Windows.Forms.Button();
            this.lv_task_list_viwe = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_all_task
            // 
            this.btn_all_task.Location = new System.Drawing.Point(12, 41);
            this.btn_all_task.Name = "btn_all_task";
            this.btn_all_task.Size = new System.Drawing.Size(75, 23);
            this.btn_all_task.TabIndex = 0;
            this.btn_all_task.Text = "All Task";
            this.btn_all_task.UseVisualStyleBackColor = true;
            this.btn_all_task.Click += new System.EventHandler(this.btn_all_task_Click);
            // 
            // btn_add_task
            // 
            this.btn_add_task.Location = new System.Drawing.Point(12, 70);
            this.btn_add_task.Name = "btn_add_task";
            this.btn_add_task.Size = new System.Drawing.Size(75, 23);
            this.btn_add_task.TabIndex = 1;
            this.btn_add_task.Text = "Add Task";
            this.btn_add_task.UseVisualStyleBackColor = true;
            this.btn_add_task.Click += new System.EventHandler(this.btn_add_task_Click);
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(12, 99);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(75, 23);
            this.btn_report.TabIndex = 2;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            // 
            // btn_today_task
            // 
            this.btn_today_task.Location = new System.Drawing.Point(12, 12);
            this.btn_today_task.Name = "btn_today_task";
            this.btn_today_task.Size = new System.Drawing.Size(75, 23);
            this.btn_today_task.TabIndex = 3;
            this.btn_today_task.Text = "Today Task";
            this.btn_today_task.UseVisualStyleBackColor = true;
            // 
            // lv_task_list_viwe
            // 
            this.lv_task_list_viwe.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_task_list_viwe.HideSelection = false;
            this.lv_task_list_viwe.Location = new System.Drawing.Point(93, 12);
            this.lv_task_list_viwe.Name = "lv_task_list_viwe";
            this.lv_task_list_viwe.Size = new System.Drawing.Size(257, 413);
            this.lv_task_list_viwe.TabIndex = 4;
            this.lv_task_list_viwe.UseCompatibleStateImageBehavior = false;
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 437);
            this.Controls.Add(this.lv_task_list_viwe);
            this.Controls.Add(this.btn_today_task);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_add_task);
            this.Controls.Add(this.btn_all_task);
            this.Name = "Main_Page";
            this.Text = "Task Management";
            this.Load += new System.EventHandler(this.Main_Page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_all_task;
        private System.Windows.Forms.Button btn_add_task;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_today_task;
        private System.Windows.Forms.ListView lv_task_list_viwe;
    }
}

