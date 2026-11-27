using DVLD.People.Controls;
namespace DVLD.People
{
    partial class frmShowPersonInfo
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
            lblPersonDetailsHeader = new Label();
            ctrlPersonInformation1 = new ctrlPersonInformation();
            pbClose = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // lblPersonDetailsHeader
            // 
            lblPersonDetailsHeader.AutoSize = true;
            lblPersonDetailsHeader.BackColor = SystemColors.Window;
            lblPersonDetailsHeader.FlatStyle = FlatStyle.System;
            lblPersonDetailsHeader.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonDetailsHeader.ForeColor = SystemColors.WindowText;
            lblPersonDetailsHeader.Location = new Point(363, 9);
            lblPersonDetailsHeader.Name = "lblPersonDetailsHeader";
            lblPersonDetailsHeader.Size = new Size(205, 31);
            lblPersonDetailsHeader.TabIndex = 2;
            lblPersonDetailsHeader.Text = "Person Details";
            // 
            // ctrlPersonInformation1
            // 
            ctrlPersonInformation1.BackColor = SystemColors.Window;
            ctrlPersonInformation1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonInformation1.Location = new Point(10, 69);
            ctrlPersonInformation1.Name = "ctrlPersonInformation1";
            ctrlPersonInformation1.Size = new Size(910, 346);
            ctrlPersonInformation1.TabIndex = 3;
            // 
            // pbClose
            // 
            pbClose.Image = Properties.Resources.cancel;
            pbClose.Location = new Point(796, 415);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(30, 25);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 39;
            pbClose.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(793, 411);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(119, 33);
            btnClose.TabIndex = 37;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmShowPersonInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            CancelButton = btnClose;
            ClientSize = new Size(932, 456);
            Controls.Add(pbClose);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonInformation1);
            Controls.Add(lblPersonDetailsHeader);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmShowPersonInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person Details";
            Load += frmShowPersonInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPersonDetailsHeader;
        private ctrlPersonInformation ctrlPersonInformation1;
        private PictureBox pbClose;
        private Button btnClose;
    }
}