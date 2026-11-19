namespace DVLD.People
{
    partial class frmManagePeople
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblManagePeopleHeader = new Label();
            dgvListPeople = new DataGridView();
            cmsPeople = new ContextMenuStrip(components);
            tsmiShowDetails = new ToolStripMenuItem();
            tsmiAddNewPerson = new ToolStripMenuItem();
            tsmiEdit = new ToolStripMenuItem();
            tsmiDelete = new ToolStripMenuItem();
            lblTotalRecords = new Label();
            lblFilterBy = new Label();
            comboBox1 = new ComboBox();
            lblTotalRecordsResult = new Label();
            btnAddNewPerson = new Button();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvListPeople).BeginInit();
            cmsPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblManagePeopleHeader
            // 
            lblManagePeopleHeader.AutoSize = true;
            lblManagePeopleHeader.BackColor = SystemColors.Window;
            lblManagePeopleHeader.FlatStyle = FlatStyle.System;
            lblManagePeopleHeader.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManagePeopleHeader.ForeColor = SystemColors.WindowText;
            lblManagePeopleHeader.Location = new Point(522, 19);
            lblManagePeopleHeader.Name = "lblManagePeopleHeader";
            lblManagePeopleHeader.Size = new Size(252, 37);
            lblManagePeopleHeader.TabIndex = 1;
            lblManagePeopleHeader.Text = "Manage People";
            // 
            // dgvListPeople
            // 
            dgvListPeople.AllowUserToAddRows = false;
            dgvListPeople.AllowUserToDeleteRows = false;
            dgvListPeople.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dgvListPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListPeople.BackgroundColor = Color.White;
            dgvListPeople.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListPeople.ContextMenuStrip = cmsPeople;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvListPeople.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListPeople.EnableHeadersVisualStyles = false;
            dgvListPeople.GridColor = SystemColors.ActiveCaptionText;
            dgvListPeople.Location = new Point(10, 138);
            dgvListPeople.Name = "dgvListPeople";
            dgvListPeople.ReadOnly = true;
            dgvListPeople.RowHeadersVisible = false;
            dgvListPeople.RowHeadersWidth = 51;
            dgvListPeople.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListPeople.RowTemplate.Height = 35;
            dgvListPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListPeople.Size = new Size(1275, 422);
            dgvListPeople.TabIndex = 2;
            // 
            // cmsPeople
            // 
            cmsPeople.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmsPeople.ImageScalingSize = new Size(30, 30);
            cmsPeople.Items.AddRange(new ToolStripItem[] { tsmiShowDetails, tsmiAddNewPerson, tsmiEdit, tsmiDelete });
            cmsPeople.Name = "cmsPeople";
            cmsPeople.Size = new Size(195, 170);
            // 
            // tsmiShowDetails
            // 
            tsmiShowDetails.Image = Properties.Resources.show_details;
            tsmiShowDetails.Name = "tsmiShowDetails";
            tsmiShowDetails.Size = new Size(194, 36);
            tsmiShowDetails.Text = "Show Details";
            // 
            // tsmiAddNewPerson
            // 
            tsmiAddNewPerson.Image = Properties.Resources.add_new_person;
            tsmiAddNewPerson.Name = "tsmiAddNewPerson";
            tsmiAddNewPerson.Size = new Size(194, 36);
            tsmiAddNewPerson.Text = "Add New Person";
            tsmiAddNewPerson.Click += tsmiAddNewPerson_Click;
            // 
            // tsmiEdit
            // 
            tsmiEdit.Image = Properties.Resources.edit_person;
            tsmiEdit.Name = "tsmiEdit";
            tsmiEdit.Size = new Size(194, 36);
            tsmiEdit.Text = "Edit";
            tsmiEdit.Click += tsmiEdit_Click;
            // 
            // tsmiDelete
            // 
            tsmiDelete.Image = Properties.Resources.delete_person;
            tsmiDelete.Name = "tsmiDelete";
            tsmiDelete.Size = new Size(194, 36);
            tsmiDelete.Text = "Delete";
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRecords.Location = new Point(10, 563);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(112, 20);
            lblTotalRecords.TabIndex = 3;
            lblTotalRecords.Text = "Total Records:";
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilterBy.Location = new Point(12, 106);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(82, 24);
            lblFilterBy.TabIndex = 5;
            lblFilterBy.Text = "Filter By:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(117, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 24);
            comboBox1.TabIndex = 6;
            // 
            // lblTotalRecordsResult
            // 
            lblTotalRecordsResult.AutoSize = true;
            lblTotalRecordsResult.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRecordsResult.Location = new Point(139, 563);
            lblTotalRecordsResult.Name = "lblTotalRecordsResult";
            lblTotalRecordsResult.Size = new Size(36, 20);
            lblTotalRecordsResult.TabIndex = 7;
            lblTotalRecordsResult.Text = "???";
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.BackgroundImage = Properties.Resources.add_person;
            btnAddNewPerson.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewPerson.FlatStyle = FlatStyle.Flat;
            btnAddNewPerson.Location = new Point(1221, 100);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(63, 35);
            btnAddNewPerson.TabIndex = 8;
            btnAddNewPerson.UseVisualStyleBackColor = true;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1157, 563);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(127, 33);
            btnClose.TabIndex = 36;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cancel;
            pictureBox2.Location = new Point(1160, 567);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // frmManagePeople
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1296, 622);
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(btnAddNewPerson);
            Controls.Add(lblTotalRecordsResult);
            Controls.Add(comboBox1);
            Controls.Add(lblFilterBy);
            Controls.Add(lblTotalRecords);
            Controls.Add(dgvListPeople);
            Controls.Add(lblManagePeopleHeader);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "frmManagePeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage People";
            Load += frmListPeople_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListPeople).EndInit();
            cmsPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblManagePeopleHeader;
        private DataGridView dgvListPeople;
        private Label lblTotalRecords;
        private Label lblPeopleList;
        private Label lblFilterBy;
        private ComboBox comboBox1;
        private Label lblTotalRecordsResult;
        private Button btnAddNewPerson;
        private ContextMenuStrip cmsPeople;
        private ToolStripMenuItem tsmiShowDetails;
        private ToolStripMenuItem tsmiAddNewPerson;
        private ToolStripMenuItem tsmiEdit;
        private ToolStripMenuItem tsmiDelete;
        private Button btnClose;
        private PictureBox pictureBox2;
    }
}