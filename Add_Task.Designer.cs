namespace Task_Management
{
    partial class f_add_task
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_task_name = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_due_date = new System.Windows.Forms.TextBox();
            this.lbl_task_name = new System.Windows.Forms.Label();
            this.lbl_task_description = new System.Windows.Forms.Label();
            this.lbl_due_date = new System.Windows.Forms.Label();
            this.lbl_task_priority = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cmb_priority = new System.Windows.Forms.ComboBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(324, 204);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(243, 204);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_task_name
            // 
            this.txt_task_name.Location = new System.Drawing.Point(189, 12);
            this.txt_task_name.Name = "txt_task_name";
            this.txt_task_name.Size = new System.Drawing.Size(213, 20);
            this.txt_task_name.TabIndex = 2;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(189, 38);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(213, 20);
            this.txt_description.TabIndex = 3;
            // 
            // txt_due_date
            // 
            this.txt_due_date.Location = new System.Drawing.Point(189, 64);
            this.txt_due_date.Name = "txt_due_date";
            this.txt_due_date.Size = new System.Drawing.Size(213, 20);
            this.txt_due_date.TabIndex = 4;
            // 
            // lbl_task_name
            // 
            this.lbl_task_name.AutoSize = true;
            this.lbl_task_name.Location = new System.Drawing.Point(12, 15);
            this.lbl_task_name.Name = "lbl_task_name";
            this.lbl_task_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_task_name.TabIndex = 5;
            this.lbl_task_name.Text = "Name";
            // 
            // lbl_task_description
            // 
            this.lbl_task_description.AutoSize = true;
            this.lbl_task_description.Location = new System.Drawing.Point(12, 41);
            this.lbl_task_description.Name = "lbl_task_description";
            this.lbl_task_description.Size = new System.Drawing.Size(60, 13);
            this.lbl_task_description.TabIndex = 6;
            this.lbl_task_description.Text = "Description";
            // 
            // lbl_due_date
            // 
            this.lbl_due_date.AutoSize = true;
            this.lbl_due_date.Location = new System.Drawing.Point(12, 64);
            this.lbl_due_date.Name = "lbl_due_date";
            this.lbl_due_date.Size = new System.Drawing.Size(53, 13);
            this.lbl_due_date.TabIndex = 7;
            this.lbl_due_date.Text = "Due Date";
            // 
            // lbl_task_priority
            // 
            this.lbl_task_priority.AutoSize = true;
            this.lbl_task_priority.Location = new System.Drawing.Point(12, 90);
            this.lbl_task_priority.Name = "lbl_task_priority";
            this.lbl_task_priority.Size = new System.Drawing.Size(38, 13);
            this.lbl_task_priority.TabIndex = 9;
            this.lbl_task_priority.Text = "Priority";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(12, 116);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(49, 13);
            this.lbl_category.TabIndex = 11;
            this.lbl_category.Text = "Category";
            // 
            // cmb_priority
            // 
            this.cmb_priority.FormattingEnabled = true;
            this.cmb_priority.Location = new System.Drawing.Point(189, 90);
            this.cmb_priority.Name = "cmb_priority";
            this.cmb_priority.Size = new System.Drawing.Size(213, 21);
            this.cmb_priority.TabIndex = 12;
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(189, 117);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(213, 21);
            this.cmb_category.TabIndex = 13;
            // 
            // f_add_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 239);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.cmb_priority);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_task_priority);
            this.Controls.Add(this.lbl_due_date);
            this.Controls.Add(this.lbl_task_description);
            this.Controls.Add(this.lbl_task_name);
            this.Controls.Add(this.txt_due_date);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_task_name);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Name = "f_add_task";
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.f_add_task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_task_name;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_due_date;
        private System.Windows.Forms.Label lbl_task_name;
        private System.Windows.Forms.Label lbl_task_description;
        private System.Windows.Forms.Label lbl_due_date;
        private System.Windows.Forms.Label lbl_task_priority;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cmb_priority;
        private System.Windows.Forms.ComboBox cmb_category;
    }
}