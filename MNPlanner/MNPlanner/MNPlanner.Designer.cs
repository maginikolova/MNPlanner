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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MNPlanner));
            this.lblTaskID = new System.Windows.Forms.Label();
            this.txtboxTaskID = new System.Windows.Forms.TextBox();
            this.lblTaskDeadline = new System.Windows.Forms.Label();
            this.txtboxTaskName = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.dtpTaskDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblTaskFor = new System.Windows.Forms.Label();
            this.cmbTaskFor = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTaskList = new System.Windows.Forms.DataGridView();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTaskManager = new System.Windows.Forms.Panel();
            this.pnlTnxbox = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTaskManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaskID.Location = new System.Drawing.Point(33, 38);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(53, 19);
            this.lblTaskID.TabIndex = 1;
            this.lblTaskID.Text = "Task ID";
            this.lblTaskID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxTaskID
            // 
            this.txtboxTaskID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxTaskID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxTaskID.Location = new System.Drawing.Point(39, 67);
            this.txtboxTaskID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxTaskID.Name = "txtboxTaskID";
            this.txtboxTaskID.ReadOnly = true;
            this.txtboxTaskID.Size = new System.Drawing.Size(377, 17);
            this.txtboxTaskID.TabIndex = 2;
            this.txtboxTaskID.TextChanged += new System.EventHandler(this.txtboxTaskID_TextChanged);
            // 
            // lblTaskDeadline
            // 
            this.lblTaskDeadline.AutoSize = true;
            this.lblTaskDeadline.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskDeadline.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaskDeadline.Location = new System.Drawing.Point(33, 211);
            this.lblTaskDeadline.Name = "lblTaskDeadline";
            this.lblTaskDeadline.Size = new System.Drawing.Size(72, 19);
            this.lblTaskDeadline.TabIndex = 5;
            this.lblTaskDeadline.Text = "Deadline";
            this.lblTaskDeadline.Click += new System.EventHandler(this.lblTaskDeadline_Click);
            // 
            // txtboxTaskName
            // 
            this.txtboxTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxTaskName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxTaskName.Location = new System.Drawing.Point(39, 149);
            this.txtboxTaskName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxTaskName.Multiline = true;
            this.txtboxTaskName.Name = "txtboxTaskName";
            this.txtboxTaskName.Size = new System.Drawing.Size(377, 30);
            this.txtboxTaskName.TabIndex = 8;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaskName.Location = new System.Drawing.Point(33, 119);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(82, 19);
            this.lblTaskName.TabIndex = 7;
            this.lblTaskName.Text = "Task Name";
            // 
            // dtpTaskDeadline
            // 
            this.dtpTaskDeadline.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTaskDeadline.Location = new System.Drawing.Point(39, 240);
            this.dtpTaskDeadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTaskDeadline.Name = "dtpTaskDeadline";
            this.dtpTaskDeadline.Size = new System.Drawing.Size(377, 24);
            this.dtpTaskDeadline.TabIndex = 9;
            this.dtpTaskDeadline.ValueChanged += new System.EventHandler(this.dtpDeadline_ValueChanged);
            // 
            // lblTaskFor
            // 
            this.lblTaskFor.AutoSize = true;
            this.lblTaskFor.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskFor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaskFor.Location = new System.Drawing.Point(33, 305);
            this.lblTaskFor.Name = "lblTaskFor";
            this.lblTaskFor.Size = new System.Drawing.Size(147, 19);
            this.lblTaskFor.TabIndex = 10;
            this.lblTaskFor.Text = "What is the task for?";
            this.lblTaskFor.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbTaskFor
            // 
            this.cmbTaskFor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTaskFor.FormattingEnabled = true;
            this.cmbTaskFor.Items.AddRange(new object[] {
            "School",
            "University",
            "Work",
            "Sport",
            "Social",
            "Other"});
            this.cmbTaskFor.Location = new System.Drawing.Point(39, 336);
            this.cmbTaskFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTaskFor.Name = "cmbTaskFor";
            this.cmbTaskFor.Size = new System.Drawing.Size(377, 27);
            this.cmbTaskFor.TabIndex = 11;
            this.cmbTaskFor.SelectedIndexChanged += new System.EventHandler(this.cmbTaskFor_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(61, 404);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 46);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(246, 404);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 48);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(246, 468);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 48);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(61, 468);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 48);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTaskList
            // 
            this.dgvTaskList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaskList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.dgvTaskList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskList.Location = new System.Drawing.Point(490, 230);
            this.dgvTaskList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTaskList.Name = "dgvTaskList";
            this.dgvTaskList.RowTemplate.Height = 24;
            this.dgvTaskList.Size = new System.Drawing.Size(657, 428);
            this.dgvTaskList.TabIndex = 16;
            this.dgvTaskList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaskList_CellContentClick);
            this.dgvTaskList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTaskList_RowHeaderMouseClick);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxSearch.Location = new System.Drawing.Point(565, 172);
            this.txtboxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(581, 17);
            this.txtboxSearch.TabIndex = 17;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearch.Location = new System.Drawing.Point(486, 172);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 19);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Turquoise;
            this.pnlLogo.Controls.Add(this.lblClose);
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Location = new System.Drawing.Point(0, -2);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(1219, 136);
            this.pnlLogo.TabIndex = 20;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1140, 10);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(33, 32);
            this.lblClose.TabIndex = 24;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlTaskManager
            // 
            this.pnlTaskManager.BackColor = System.Drawing.Color.White;
            this.pnlTaskManager.Controls.Add(this.lblTaskID);
            this.pnlTaskManager.Controls.Add(this.txtboxTaskID);
            this.pnlTaskManager.Controls.Add(this.lblTaskDeadline);
            this.pnlTaskManager.Controls.Add(this.lblTaskName);
            this.pnlTaskManager.Controls.Add(this.txtboxTaskName);
            this.pnlTaskManager.Controls.Add(this.btnClear);
            this.pnlTaskManager.Controls.Add(this.dtpTaskDeadline);
            this.pnlTaskManager.Controls.Add(this.btnDelete);
            this.pnlTaskManager.Controls.Add(this.lblTaskFor);
            this.pnlTaskManager.Controls.Add(this.btnUpdate);
            this.pnlTaskManager.Controls.Add(this.cmbTaskFor);
            this.pnlTaskManager.Controls.Add(this.btnAdd);
            this.pnlTaskManager.Location = new System.Drawing.Point(0, 134);
            this.pnlTaskManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTaskManager.Name = "pnlTaskManager";
            this.pnlTaskManager.Size = new System.Drawing.Size(452, 572);
            this.pnlTaskManager.TabIndex = 21;
            this.pnlTaskManager.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnlTnxbox
            // 
            this.pnlTnxbox.BackColor = System.Drawing.Color.Turquoise;
            this.pnlTnxbox.Location = new System.Drawing.Point(453, 133);
            this.pnlTnxbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTnxbox.Name = "pnlTnxbox";
            this.pnlTnxbox.Size = new System.Drawing.Size(2, 575);
            this.pnlTnxbox.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Location = new System.Drawing.Point(565, 192);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 1);
            this.panel2.TabIndex = 23;
            // 
            // MNPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1181, 689);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTnxbox);
            this.Controls.Add(this.pnlTaskManager);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.dgvTaskList);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MNPlanner";
            this.Text = "MNPlanner";
            this.Load += new System.EventHandler(this.MNPlanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTaskManager.ResumeLayout(false);
            this.pnlTaskManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.TextBox txtboxTaskID;
        private System.Windows.Forms.Label lblTaskDeadline;
        private System.Windows.Forms.TextBox txtboxTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.DateTimePicker dtpTaskDeadline;
        private System.Windows.Forms.Label lblTaskFor;
        private System.Windows.Forms.ComboBox cmbTaskFor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTaskList;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTaskManager;
        private System.Windows.Forms.Panel pnlTnxbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClose;
    }
}

