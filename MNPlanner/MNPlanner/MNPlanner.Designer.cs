namespace MNPlanner
{
    partial class MNPlanner
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.txtboxTaskID = new System.Windows.Forms.TextBox();
            this.lblTaskDeadline = new System.Windows.Forms.Label();
            this.txtboxTaskName = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblTaskFor = new System.Windows.Forms.Label();
            this.cmbTaskFor = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(355, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaskID.Location = new System.Drawing.Point(24, 115);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(67, 20);
            this.lblTaskID.TabIndex = 1;
            this.lblTaskID.Text = "Task ID";
            this.lblTaskID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxTaskID
            // 
            this.txtboxTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxTaskID.Location = new System.Drawing.Point(143, 113);
            this.txtboxTaskID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxTaskID.Name = "txtboxTaskID";
            this.txtboxTaskID.Size = new System.Drawing.Size(72, 27);
            this.txtboxTaskID.TabIndex = 2;
            // 
            // lblTaskDeadline
            // 
            this.lblTaskDeadline.AutoSize = true;
            this.lblTaskDeadline.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaskDeadline.Location = new System.Drawing.Point(24, 275);
            this.lblTaskDeadline.Name = "lblTaskDeadline";
            this.lblTaskDeadline.Size = new System.Drawing.Size(75, 20);
            this.lblTaskDeadline.TabIndex = 5;
            this.lblTaskDeadline.Text = "Deadline";
            this.lblTaskDeadline.Click += new System.EventHandler(this.lblTaskDeadline_Click);
            // 
            // txtboxTaskName
            // 
            this.txtboxTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxTaskName.Location = new System.Drawing.Point(143, 162);
            this.txtboxTaskName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxTaskName.Multiline = true;
            this.txtboxTaskName.Name = "txtboxTaskName";
            this.txtboxTaskName.Size = new System.Drawing.Size(272, 84);
            this.txtboxTaskName.TabIndex = 8;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaskName.Location = new System.Drawing.Point(24, 165);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(94, 20);
            this.lblTaskName.TabIndex = 7;
            this.lblTaskName.Text = "Task Name";
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDeadline.Location = new System.Drawing.Point(143, 271);
            this.dtpDeadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(272, 27);
            this.dtpDeadline.TabIndex = 9;
            this.dtpDeadline.ValueChanged += new System.EventHandler(this.dtpDeadline_ValueChanged);
            // 
            // lblTaskFor
            // 
            this.lblTaskFor.AutoSize = true;
            this.lblTaskFor.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaskFor.Location = new System.Drawing.Point(24, 324);
            this.lblTaskFor.Name = "lblTaskFor";
            this.lblTaskFor.Size = new System.Drawing.Size(164, 20);
            this.lblTaskFor.TabIndex = 10;
            this.lblTaskFor.Text = "What is the task for?";
            this.lblTaskFor.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbTaskFor
            // 
            this.cmbTaskFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTaskFor.FormattingEnabled = true;
            this.cmbTaskFor.Items.AddRange(new object[] {
            "School",
            "University",
            "Work",
            "Sport",
            "Social",
            "Other"});
            this.cmbTaskFor.Location = new System.Drawing.Point(225, 321);
            this.cmbTaskFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTaskFor.Name = "cmbTaskFor";
            this.cmbTaskFor.Size = new System.Drawing.Size(190, 28);
            this.cmbTaskFor.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(126, 393);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 38);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(276, 393);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 38);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(573, 393);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 38);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(424, 393);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 38);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(462, 160);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(380, 189);
            this.dataGridView1.TabIndex = 16;
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxSearch.Location = new System.Drawing.Point(533, 112);
            this.txtboxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(309, 27);
            this.txtboxSearch.TabIndex = 17;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearch.Location = new System.Drawing.Point(461, 116);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(62, 20);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(831, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 31);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // MNPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 463);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbTaskFor);
            this.Controls.Add(this.lblTaskFor);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.txtboxTaskName);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblTaskDeadline);
            this.Controls.Add(this.txtboxTaskID);
            this.Controls.Add(this.lblTaskID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MNPlanner";
            this.Text = "MNPlanner";
            this.Load += new System.EventHandler(this.MNPlanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.TextBox txtboxTaskID;
        private System.Windows.Forms.Label lblTaskDeadline;
        private System.Windows.Forms.TextBox txtboxTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label lblTaskFor;
        private System.Windows.Forms.ComboBox cmbTaskFor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

