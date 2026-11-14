namespace DVLD.People
{
    partial class frmListPeople
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblManagePeopleHeader = new Label();
            dgvListPeople = new DataGridView();
            lblTotalRecords = new Label();
            lblFilterBy = new Label();
            comboBox1 = new ComboBox();
            lblTotalRecordsResult = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListPeople).BeginInit();
            SuspendLayout();
            // 
            // lblManagePeopleHeader
            // 
            lblManagePeopleHeader.AutoSize = true;
            lblManagePeopleHeader.BackColor = SystemColors.Window;
            lblManagePeopleHeader.FlatStyle = FlatStyle.System;
            lblManagePeopleHeader.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblManagePeopleHeader.ForeColor = SystemColors.WindowText;
            lblManagePeopleHeader.Location = new Point(444, 8);
            lblManagePeopleHeader.Name = "lblManagePeopleHeader";
            lblManagePeopleHeader.Size = new Size(233, 36);
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
            dgvListPeople.Location = new Point(9, 138);
            dgvListPeople.Name = "dgvListPeople";
            dgvListPeople.ReadOnly = true;
            dgvListPeople.RowHeadersVisible = false;
            dgvListPeople.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListPeople.RowTemplate.Height = 35;
            dgvListPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListPeople.Size = new Size(1116, 422);
            dgvListPeople.TabIndex = 2;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRecords.Location = new Point(9, 563);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(107, 18);
            lblTotalRecords.TabIndex = 3;
            lblTotalRecords.Text = "Total Records:";
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilterBy.Location = new Point(12, 109);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(84, 22);
            lblFilterBy.TabIndex = 5;
            lblFilterBy.Text = "Filter By:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(105, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 24);
            comboBox1.TabIndex = 6;
            // 
            // lblTotalRecordsResult
            // 
            lblTotalRecordsResult.AutoSize = true;
            lblTotalRecordsResult.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRecordsResult.Location = new Point(122, 563);
            lblTotalRecordsResult.Name = "lblTotalRecordsResult";
            lblTotalRecordsResult.Size = new Size(35, 18);
            lblTotalRecordsResult.TabIndex = 7;
            lblTotalRecordsResult.Text = "???";
            // 
            // frmListPeople
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1134, 622);
            Controls.Add(lblTotalRecordsResult);
            Controls.Add(comboBox1);
            Controls.Add(lblFilterBy);
            Controls.Add(lblTotalRecords);
            Controls.Add(dgvListPeople);
            Controls.Add(lblManagePeopleHeader);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmListPeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage People";
            Load += frmListPeople_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListPeople).EndInit();
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
    }
}