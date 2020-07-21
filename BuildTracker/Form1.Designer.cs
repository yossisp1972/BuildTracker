namespace BuildTracker
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noBuild = new System.Windows.Forms.CheckBox();
            this.buildStatus = new System.Windows.Forms.ComboBox();
            this.buildNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kitID = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDetails2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFailure = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtBug = new System.Windows.Forms.TextBox();
            this.btnRemoveIssue = new System.Windows.Forms.Button();
            this.btnAddIssue = new System.Windows.Forms.Button();
            this.addBuild = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noBuild);
            this.groupBox1.Controls.Add(this.buildStatus);
            this.groupBox1.Controls.Add(this.buildNumber);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.kitID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(925, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Build details";
            // 
            // noBuild
            // 
            this.noBuild.AutoSize = true;
            this.noBuild.Location = new System.Drawing.Point(536, 53);
            this.noBuild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noBuild.Name = "noBuild";
            this.noBuild.Size = new System.Drawing.Size(82, 21);
            this.noBuild.TabIndex = 4;
            this.noBuild.Text = "No build";
            this.noBuild.UseVisualStyleBackColor = true;
            this.noBuild.CheckedChanged += new System.EventHandler(this.noBuild_CheckedChanged);
            // 
            // buildStatus
            // 
            this.buildStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildStatus.FormattingEnabled = true;
            this.buildStatus.Location = new System.Drawing.Point(536, 20);
            this.buildStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buildStatus.Name = "buildStatus";
            this.buildStatus.Size = new System.Drawing.Size(173, 26);
            this.buildStatus.TabIndex = 3;
            this.buildStatus.Text = "Build status";
            this.buildStatus.SelectedIndexChanged += new System.EventHandler(this.buildStatus_SelectedIndexChanged);
            // 
            // buildNumber
            // 
            this.buildNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildNumber.Location = new System.Drawing.Point(316, 20);
            this.buildNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buildNumber.Multiline = true;
            this.buildNumber.Name = "buildNumber";
            this.buildNumber.Size = new System.Drawing.Size(212, 26);
            this.buildNumber.TabIndex = 2;
            this.buildNumber.Text = "Build number";
            this.buildNumber.Click += new System.EventHandler(this.buildNumber_Click);
            this.buildNumber.TextChanged += new System.EventHandler(this.buildNumber_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(716, 20);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // kitID
            // 
            this.kitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitID.FormattingEnabled = true;
            this.kitID.Location = new System.Drawing.Point(5, 20);
            this.kitID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kitID.Name = "kitID";
            this.kitID.Size = new System.Drawing.Size(303, 26);
            this.kitID.TabIndex = 0;
            this.kitID.Text = "Kit type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.btnRemoveIssue);
            this.groupBox2.Controls.Add(this.btnAddIssue);
            this.groupBox2.Location = new System.Drawing.Point(13, 134);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(925, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add issue";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDetails2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.cbFailure);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.txtBug);
            this.panel1.Location = new System.Drawing.Point(7, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 201);
            this.panel1.TabIndex = 0;
            // 
            // txtDetails2
            // 
            this.txtDetails2.Location = new System.Drawing.Point(527, 14);
            this.txtDetails2.Multiline = true;
            this.txtDetails2.Name = "txtDetails2";
            this.txtDetails2.Size = new System.Drawing.Size(367, 26);
            this.txtDetails2.TabIndex = 7;
            this.txtDetails2.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(4, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(909, 144);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Bug ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Caused Failure?";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Details";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // cbFailure
            // 
            this.cbFailure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFailure.FormattingEnabled = true;
            this.cbFailure.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbFailure.Location = new System.Drawing.Point(357, 14);
            this.cbFailure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFailure.Name = "cbFailure";
            this.cbFailure.Size = new System.Drawing.Size(164, 26);
            this.cbFailure.TabIndex = 2;
            this.cbFailure.Text = "Caused failure?";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(209, 14);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(141, 26);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.Text = "Select category";
            // 
            // txtBug
            // 
            this.txtBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBug.Location = new System.Drawing.Point(4, 14);
            this.txtBug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBug.Multiline = true;
            this.txtBug.Name = "txtBug";
            this.txtBug.Size = new System.Drawing.Size(199, 26);
            this.txtBug.TabIndex = 0;
            this.txtBug.Text = "Bug ID/ServiceNow";
            this.txtBug.Click += new System.EventHandler(this.txtBug_Click);
            // 
            // btnRemoveIssue
            // 
            this.btnRemoveIssue.Location = new System.Drawing.Point(761, 228);
            this.btnRemoveIssue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveIssue.Name = "btnRemoveIssue";
            this.btnRemoveIssue.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveIssue.TabIndex = 5;
            this.btnRemoveIssue.Text = "Remove";
            this.btnRemoveIssue.UseVisualStyleBackColor = true;
            // 
            // btnAddIssue
            // 
            this.btnAddIssue.Location = new System.Drawing.Point(843, 228);
            this.btnAddIssue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddIssue.Name = "btnAddIssue";
            this.btnAddIssue.Size = new System.Drawing.Size(75, 23);
            this.btnAddIssue.TabIndex = 4;
            this.btnAddIssue.Text = "Add";
            this.btnAddIssue.UseVisualStyleBackColor = true;
            this.btnAddIssue.Click += new System.EventHandler(this.btnAddIssue_Click);
            // 
            // addBuild
            // 
            this.addBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBuild.Location = new System.Drawing.Point(829, 398);
            this.addBuild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBuild.Name = "addBuild";
            this.addBuild.Size = new System.Drawing.Size(104, 38);
            this.addBuild.TabIndex = 2;
            this.addBuild.Text = "Add build";
            this.addBuild.UseVisualStyleBackColor = true;
            this.addBuild.Click += new System.EventHandler(this.addBuild_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 449);
            this.Controls.Add(this.addBuild);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Gatekeepers Build Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox buildNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox kitID;
        private System.Windows.Forms.CheckBox noBuild;
        private System.Windows.Forms.ComboBox buildStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBuild;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRemoveIssue;
        private System.Windows.Forms.Button btnAddIssue;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.ComboBox cbFailure;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtBug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtDetails2;
    }
}

