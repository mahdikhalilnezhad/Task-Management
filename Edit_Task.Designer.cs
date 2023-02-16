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
            this.SuspendLayout();
            // 
            // txtSteps
            // 
            this.txtSteps.Location = new System.Drawing.Point(115, 144);
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(54, 20);
            this.txtSteps.TabIndex = 34;
            this.txtSteps.Text = "1";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(17, 147);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(34, 13);
            this.lblSteps.TabIndex = 33;
            this.lblSteps.Text = "Steps";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(115, 117);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(213, 21);
            this.cmb_category.TabIndex = 29;
            // 
            // cmb_priority
            // 
            this.cmb_priority.FormattingEnabled = true;
            this.cmb_priority.Location = new System.Drawing.Point(115, 90);
            this.cmb_priority.Name = "cmb_priority";
            this.cmb_priority.Size = new System.Drawing.Size(213, 21);
            this.cmb_priority.TabIndex = 28;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(17, 116);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(49, 13);
            this.lbl_category.TabIndex = 27;
            this.lbl_category.Text = "Category";
            // 
            // lbl_task_priority
            // 
            this.lbl_task_priority.AutoSize = true;
            this.lbl_task_priority.Location = new System.Drawing.Point(17, 90);
            this.lbl_task_priority.Name = "lbl_task_priority";
            this.lbl_task_priority.Size = new System.Drawing.Size(38, 13);
            this.lbl_task_priority.TabIndex = 26;
            this.lbl_task_priority.Text = "Priority";
            // 
            // lbl_due_date
            // 
            this.lbl_due_date.AutoSize = true;
            this.lbl_due_date.Location = new System.Drawing.Point(17, 64);
            this.lbl_due_date.Name = "lbl_due_date";
            this.lbl_due_date.Size = new System.Drawing.Size(53, 13);
            this.lbl_due_date.TabIndex = 25;
            this.lbl_due_date.Text = "Due Date";
            // 
            // lbl_task_description
            // 
            this.lbl_task_description.AutoSize = true;
            this.lbl_task_description.Location = new System.Drawing.Point(17, 41);
            this.lbl_task_description.Name = "lbl_task_description";
            this.lbl_task_description.Size = new System.Drawing.Size(60, 13);
            this.lbl_task_description.TabIndex = 24;
            this.lbl_task_description.Text = "Description";
            // 
            // lbl_task_name
            // 
            this.lbl_task_name.AutoSize = true;
            this.lbl_task_name.Location = new System.Drawing.Point(17, 15);
            this.lbl_task_name.Name = "lbl_task_name";
            this.lbl_task_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_task_name.TabIndex = 23;
            this.lbl_task_name.Text = "Name";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(115, 38);
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
            this.cmbTaskName.Location = new System.Drawing.Point(115, 15);
            this.cmbTaskName.Name = "cmbTaskName";
            this.cmbTaskName.Size = new System.Drawing.Size(213, 21);
            this.cmbTaskName.TabIndex = 35;
            // 
            // Edit_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 276);
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
    }
}