namespace Task_Management
{
    partial class Edit_Task
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
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.lblSteps = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.cmb_priority = new System.Windows.Forms.ComboBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_task_priority = new System.Windows.Forms.Label();
            this.lbl_due_date = new System.Windows.Forms.Label();
            this.lbl_task_description = new System.Windows.Forms.Label();
            this.lbl_task_name = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.cmbTaskName = new System.Windows.Forms.ComboBox();
            this.lbltaskid = new System.Windows.Forms.Label();
            this.lblTaskIdShow = new System.Windows.Forms.Label();
            this.lblDeadLineShow = new System.Windows.Forms.Label();
            this.lblDeadLine = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSteps
            // 
            this.txtSteps.Location = new System.Drawing.Point(110, 174);
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(54, 20);
            this.txtSteps.TabIndex = 34;
            this.txtSteps.Text = "1";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(12, 177);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(34, 13);
            this.lblSteps.TabIndex = 33;
            this.lblSteps.Text = "Steps";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(110, 147);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(213, 21);
            this.cmb_category.TabIndex = 29;
            // 
            // cmb_priority
            // 
            this.cmb_priority.FormattingEnabled = true;
            this.cmb_priority.Location = new System.Drawing.Point(110, 120);
            this.cmb_priority.Name = "cmb_priority";
            this.cmb_priority.Size = new System.Drawing.Size(213, 21);
            this.cmb_priority.TabIndex = 28;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(12, 146);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(49, 13);
            this.lbl_category.TabIndex = 27;
            this.lbl_category.Text = "Category";
            // 
            // lbl_task_priority
            // 
            this.lbl_task_priority.AutoSize = true;
            this.lbl_task_priority.Location = new System.Drawing.Point(12, 120);
            this.lbl_task_priority.Name = "lbl_task_priority";
            this.lbl_task_priority.Size = new System.Drawing.Size(38, 13);
            this.lbl_task_priority.TabIndex = 26;
            this.lbl_task_priority.Text = "Priority";
            // 
            // lbl_due_date
            // 
            this.lbl_due_date.AutoSize = true;
            this.lbl_due_date.Location = new System.Drawing.Point(12, 94);
            this.lbl_due_date.Name = "lbl_due_date";
            this.lbl_due_date.Size = new System.Drawing.Size(53, 13);
            this.lbl_due_date.TabIndex = 25;
            this.lbl_due_date.Text = "Due Date";
            // 
            // lbl_task_description
            // 
            this.lbl_task_description.AutoSize = true;
            this.lbl_task_description.Location = new System.Drawing.Point(12, 71);
            this.lbl_task_description.Name = "lbl_task_description";
            this.lbl_task_description.Size = new System.Drawing.Size(60, 13);
            this.lbl_task_description.TabIndex = 24;
            this.lbl_task_description.Text = "Description";
            // 
            // lbl_task_name
            // 
            this.lbl_task_name.AutoSize = true;
            this.lbl_task_name.Location = new System.Drawing.Point(12, 45);
            this.lbl_task_name.Name = "lbl_task_name";
            this.lbl_task_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_task_name.TabIndex = 23;
            this.lbl_task_name.Text = "Name";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(110, 68);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(213, 20);
            this.txt_description.TabIndex = 22;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(171, 241);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 20;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(252, 241);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 19;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // cmbTaskName
            // 
            this.cmbTaskName.FormattingEnabled = true;
            this.cmbTaskName.Location = new System.Drawing.Point(110, 45);
            this.cmbTaskName.Name = "cmbTaskName";
            this.cmbTaskName.Size = new System.Drawing.Size(213, 21);
            this.cmbTaskName.TabIndex = 35;
            this.cmbTaskName.SelectedIndexChanged += new System.EventHandler(this.cmbTaskName_SelectedIndexChanged);
            // 
            // lbltaskid
            // 
            this.lbltaskid.AutoSize = true;
            this.lbltaskid.Location = new System.Drawing.Point(12, 9);
            this.lbltaskid.Name = "lbltaskid";
            this.lbltaskid.Size = new System.Drawing.Size(45, 13);
            this.lbltaskid.TabIndex = 36;
            this.lbltaskid.Text = "Task ID";
            // 
            // lblTaskIdShow
            // 
            this.lblTaskIdShow.AutoSize = true;
            this.lblTaskIdShow.Location = new System.Drawing.Point(107, 9);
            this.lblTaskIdShow.Name = "lblTaskIdShow";
            this.lblTaskIdShow.Size = new System.Drawing.Size(0, 13);
            this.lblTaskIdShow.TabIndex = 37;
            // 
            // lblDeadLineShow
            // 
            this.lblDeadLineShow.AutoSize = true;
            this.lblDeadLineShow.Location = new System.Drawing.Point(74, 208);
            this.lblDeadLineShow.Name = "lblDeadLineShow";
            this.lblDeadLineShow.Size = new System.Drawing.Size(0, 13);
            this.lblDeadLineShow.TabIndex = 41;
            // 
            // lblDeadLine
            // 
            this.lblDeadLine.AutoSize = true;
            this.lblDeadLine.Location = new System.Drawing.Point(12, 208);
            this.lblDeadLine.Name = "lblDeadLine";
            this.lblDeadLine.Size = new System.Drawing.Size(56, 13);
            this.lblDeadLine.TabIndex = 40;
            this.lblDeadLine.Text = "Dead Line";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(214, 174);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(54, 20);
            this.txtDays.TabIndex = 39;
            this.txtDays.TextChanged += new System.EventHandler(this.txtDays_TextChanged);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(170, 177);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(31, 13);
            this.lblDays.TabIndex = 38;
            this.lblDays.Text = "Days";
            // 
            // Edit_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 276);
            this.Controls.Add(this.lblDeadLineShow);
            this.Controls.Add(this.lblDeadLine);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblTaskIdShow);
            this.Controls.Add(this.lbltaskid);
            this.Controls.Add(this.cmbTaskName);
            this.Controls.Add(this.txtSteps);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.cmb_priority);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_task_priority);
            this.Controls.Add(this.lbl_due_date);
            this.Controls.Add(this.lbl_task_description);
            this.Controls.Add(this.lbl_task_name);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Name = "Edit_Task";
            this.Text = "Edit Task";
            this.Load += new System.EventHandler(this.Edit_Task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.ComboBox cmb_priority;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_task_priority;
        private System.Windows.Forms.Label lbl_due_date;
        private System.Windows.Forms.Label lbl_task_description;
        private System.Windows.Forms.Label lbl_task_name;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ComboBox cmbTaskName;
        private System.Windows.Forms.Label lbltaskid;
        private System.Windows.Forms.Label lblTaskIdShow;
        private System.Windows.Forms.Label lblDeadLineShow;
        private System.Windows.Forms.Label lblDeadLine;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblDays;
    }
}