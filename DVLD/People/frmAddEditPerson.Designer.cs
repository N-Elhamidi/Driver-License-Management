namespace DVLD.People
{
    partial class frmAddEditPerson
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
            lblAddEditHeader = new Label();
            lblPersonID = new Label();
            lblName = new Label();
            lblNationalNO = new Label();
            lblGender = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            gbPersonDetails = new GroupBox();
            llblRemoveImage = new LinkLabel();
            llblSetImage = new LinkLabel();
            pictureBox2 = new PictureBox();
            pbSave = new PictureBox();
            btnClose = new Button();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            pbCountry = new PictureBox();
            pbDateOfBirth = new PictureBox();
            pbAddress = new PictureBox();
            pbEmail = new PictureBox();
            pbGender_Female = new PictureBox();
            pbGender_Male = new PictureBox();
            pbNationalNO = new PictureBox();
            pbPersonName = new PictureBox();
            pbPersonImage = new PictureBox();
            txtPhone = new TextBox();
            cbCountry = new ComboBox();
            dtDateOfBirth = new DateTimePicker();
            txtAddress = new TextBox();
            lblPhone = new Label();
            lblCountry = new Label();
            txtEmail = new TextBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            lblDateOfBirth = new Label();
            txtNationalNO = new TextBox();
            lblLastName = new Label();
            lblThirdName = new Label();
            txtLastName = new TextBox();
            txtThirdName = new TextBox();
            lblSecondName = new Label();
            lblFirstName = new Label();
            txtSecondName = new TextBox();
            txtFirstName = new TextBox();
            pbPersonID = new PictureBox();
            lblPersonID_result = new Label();
            errorProvider1 = new ErrorProvider(components);
            gbPersonDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCountry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDateOfBirth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGender_Female).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGender_Male).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNationalNO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblAddEditHeader
            // 
            lblAddEditHeader.AutoSize = true;
            lblAddEditHeader.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddEditHeader.Location = new Point(512, 19);
            lblAddEditHeader.Name = "lblAddEditHeader";
            lblAddEditHeader.Size = new Size(272, 37);
            lblAddEditHeader.TabIndex = 0;
            lblAddEditHeader.Text = "Add New Person";
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonID.Location = new Point(42, 98);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(112, 25);
            lblPersonID.TabIndex = 1;
            lblPersonID.Text = "Person ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblName.Location = new Point(28, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 24);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblNationalNO
            // 
            lblNationalNO.AutoSize = true;
            lblNationalNO.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblNationalNO.Location = new Point(28, 117);
            lblNationalNO.Name = "lblNationalNO";
            lblNationalNO.Size = new Size(112, 24);
            lblNationalNO.TabIndex = 3;
            lblNationalNO.Text = "NationalNO:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblGender.Location = new Point(28, 176);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(79, 24);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblEmail.Location = new Point(28, 230);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 24);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblAddress.Location = new Point(28, 287);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(85, 24);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address:";
            // 
            // gbPersonDetails
            // 
            gbPersonDetails.Controls.Add(llblRemoveImage);
            gbPersonDetails.Controls.Add(llblSetImage);
            gbPersonDetails.Controls.Add(pictureBox2);
            gbPersonDetails.Controls.Add(pbSave);
            gbPersonDetails.Controls.Add(btnClose);
            gbPersonDetails.Controls.Add(btnSave);
            gbPersonDetails.Controls.Add(pictureBox1);
            gbPersonDetails.Controls.Add(pbCountry);
            gbPersonDetails.Controls.Add(pbDateOfBirth);
            gbPersonDetails.Controls.Add(pbAddress);
            gbPersonDetails.Controls.Add(pbEmail);
            gbPersonDetails.Controls.Add(pbGender_Female);
            gbPersonDetails.Controls.Add(pbGender_Male);
            gbPersonDetails.Controls.Add(pbNationalNO);
            gbPersonDetails.Controls.Add(pbPersonName);
            gbPersonDetails.Controls.Add(pbPersonImage);
            gbPersonDetails.Controls.Add(txtPhone);
            gbPersonDetails.Controls.Add(cbCountry);
            gbPersonDetails.Controls.Add(dtDateOfBirth);
            gbPersonDetails.Controls.Add(txtAddress);
            gbPersonDetails.Controls.Add(lblPhone);
            gbPersonDetails.Controls.Add(lblCountry);
            gbPersonDetails.Controls.Add(txtEmail);
            gbPersonDetails.Controls.Add(rbFemale);
            gbPersonDetails.Controls.Add(rbMale);
            gbPersonDetails.Controls.Add(lblDateOfBirth);
            gbPersonDetails.Controls.Add(txtNationalNO);
            gbPersonDetails.Controls.Add(lblLastName);
            gbPersonDetails.Controls.Add(lblThirdName);
            gbPersonDetails.Controls.Add(txtLastName);
            gbPersonDetails.Controls.Add(txtThirdName);
            gbPersonDetails.Controls.Add(lblSecondName);
            gbPersonDetails.Controls.Add(lblFirstName);
            gbPersonDetails.Controls.Add(txtSecondName);
            gbPersonDetails.Controls.Add(txtFirstName);
            gbPersonDetails.Controls.Add(lblAddress);
            gbPersonDetails.Controls.Add(lblEmail);
            gbPersonDetails.Controls.Add(lblGender);
            gbPersonDetails.Controls.Add(lblNationalNO);
            gbPersonDetails.Controls.Add(lblName);
            gbPersonDetails.Location = new Point(42, 126);
            gbPersonDetails.Name = "gbPersonDetails";
            gbPersonDetails.Size = new Size(1182, 463);
            gbPersonDetails.TabIndex = 7;
            gbPersonDetails.TabStop = false;
            // 
            // llblRemoveImage
            // 
            llblRemoveImage.AutoSize = true;
            llblRemoveImage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblRemoveImage.Location = new Point(1032, 253);
            llblRemoveImage.Name = "llblRemoveImage";
            llblRemoveImage.Size = new Size(68, 20);
            llblRemoveImage.TabIndex = 39;
            llblRemoveImage.TabStop = true;
            llblRemoveImage.Text = "Remove";
            // 
            // llblSetImage
            // 
            llblSetImage.AutoSize = true;
            llblSetImage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblSetImage.Location = new Point(931, 253);
            llblSetImage.Name = "llblSetImage";
            llblSetImage.Size = new Size(83, 20);
            llblSetImage.TabIndex = 38;
            llblSetImage.TabStop = true;
            llblSetImage.Text = "Set Imgae";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cancel;
            pictureBox2.Location = new Point(591, 403);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // pbSave
            // 
            pbSave.Image = Properties.Resources.save;
            pbSave.Location = new Point(737, 403);
            pbSave.Name = "pbSave";
            pbSave.Size = new Size(35, 25);
            pbSave.SizeMode = PictureBoxSizeMode.Zoom;
            pbSave.TabIndex = 36;
            pbSave.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(589, 399);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(127, 33);
            btnClose.TabIndex = 35;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackgroundImageLayout = ImageLayout.Center;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(734, 399);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(127, 33);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.phone;
            pictureBox1.Location = new Point(639, 227);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // pbCountry
            // 
            pbCountry.Image = Properties.Resources.countries;
            pbCountry.Location = new Point(639, 170);
            pbCountry.Name = "pbCountry";
            pbCountry.Size = new Size(30, 25);
            pbCountry.SizeMode = PictureBoxSizeMode.Zoom;
            pbCountry.TabIndex = 32;
            pbCountry.TabStop = false;
            // 
            // pbDateOfBirth
            // 
            pbDateOfBirth.Image = Properties.Resources.date_of_birth;
            pbDateOfBirth.Location = new Point(639, 112);
            pbDateOfBirth.Name = "pbDateOfBirth";
            pbDateOfBirth.Size = new Size(30, 25);
            pbDateOfBirth.SizeMode = PictureBoxSizeMode.Zoom;
            pbDateOfBirth.TabIndex = 31;
            pbDateOfBirth.TabStop = false;
            // 
            // pbAddress
            // 
            pbAddress.Image = Properties.Resources.address;
            pbAddress.Location = new Point(162, 287);
            pbAddress.Name = "pbAddress";
            pbAddress.Size = new Size(30, 25);
            pbAddress.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddress.TabIndex = 30;
            pbAddress.TabStop = false;
            // 
            // pbEmail
            // 
            pbEmail.Image = Properties.Resources.email;
            pbEmail.Location = new Point(162, 230);
            pbEmail.Name = "pbEmail";
            pbEmail.Size = new Size(30, 25);
            pbEmail.SizeMode = PictureBoxSizeMode.Zoom;
            pbEmail.TabIndex = 29;
            pbEmail.TabStop = false;
            // 
            // pbGender_Female
            // 
            pbGender_Female.Image = Properties.Resources.gender_female;
            pbGender_Female.Location = new Point(275, 171);
            pbGender_Female.Name = "pbGender_Female";
            pbGender_Female.Size = new Size(30, 25);
            pbGender_Female.SizeMode = PictureBoxSizeMode.Zoom;
            pbGender_Female.TabIndex = 28;
            pbGender_Female.TabStop = false;
            // 
            // pbGender_Male
            // 
            pbGender_Male.Image = Properties.Resources.gender_male;
            pbGender_Male.Location = new Point(162, 171);
            pbGender_Male.Name = "pbGender_Male";
            pbGender_Male.Size = new Size(30, 25);
            pbGender_Male.SizeMode = PictureBoxSizeMode.Zoom;
            pbGender_Male.TabIndex = 27;
            pbGender_Male.TabStop = false;
            // 
            // pbNationalNO
            // 
            pbNationalNO.Image = Properties.Resources.person_id;
            pbNationalNO.Location = new Point(162, 117);
            pbNationalNO.Name = "pbNationalNO";
            pbNationalNO.Size = new Size(30, 25);
            pbNationalNO.SizeMode = PictureBoxSizeMode.Zoom;
            pbNationalNO.TabIndex = 26;
            pbNationalNO.TabStop = false;
            // 
            // pbPersonName
            // 
            pbPersonName.Image = Properties.Resources.person_name;
            pbPersonName.Location = new Point(162, 60);
            pbPersonName.Name = "pbPersonName";
            pbPersonName.Size = new Size(30, 25);
            pbPersonName.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonName.TabIndex = 25;
            pbPersonName.TabStop = false;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackgroundImageLayout = ImageLayout.None;
            pbPersonImage.BorderStyle = BorderStyle.FixedSingle;
            pbPersonImage.Image = Properties.Resources.male_image;
            pbPersonImage.Location = new Point(931, 89);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(169, 161);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 24;
            pbPersonImage.TabStop = false;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtPhone.Location = new Point(691, 228);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(169, 24);
            txtPhone.TabIndex = 23;
            txtPhone.Validating += ValidateEmptyTextBox;
            // 
            // cbCountry
            // 
            cbCountry.Font = new Font("Microsoft Sans Serif", 11.25F);
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(691, 170);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(170, 26);
            cbCountry.TabIndex = 22;
            // 
            // dtDateOfBirth
            // 
            dtDateOfBirth.Checked = false;
            dtDateOfBirth.Font = new Font("Microsoft Sans Serif", 11.25F);
            dtDateOfBirth.Format = DateTimePickerFormat.Short;
            dtDateOfBirth.Location = new Point(690, 114);
            dtDateOfBirth.Name = "dtDateOfBirth";
            dtDateOfBirth.Size = new Size(170, 24);
            dtDateOfBirth.TabIndex = 21;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(210, 287);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(651, 106);
            txtAddress.TabIndex = 20;
            txtAddress.Validating += ValidateEmptyTextBox;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblPhone.Location = new Point(538, 224);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(71, 24);
            lblPhone.TabIndex = 19;
            lblPhone.Text = "Phone:";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblCountry.Location = new Point(525, 168);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(80, 24);
            lblCountry.TabIndex = 18;
            lblCountry.Text = "Country:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtEmail.Location = new Point(210, 230);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 24);
            txtEmail.TabIndex = 17;
            txtEmail.Validating += ValidateEmail;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFemale.Location = new Point(311, 176);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(80, 24);
            rbFemale.TabIndex = 16;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.Click += rbFemale_Click;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMale.Location = new Point(210, 176);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(61, 24);
            rbMale.TabIndex = 15;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.Click += rbMale_Click;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblDateOfBirth.Location = new Point(489, 112);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(115, 24);
            lblDateOfBirth.TabIndex = 14;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // txtNationalNO
            // 
            txtNationalNO.BorderStyle = BorderStyle.FixedSingle;
            txtNationalNO.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtNationalNO.Location = new Point(214, 117);
            txtNationalNO.Name = "txtNationalNO";
            txtNationalNO.Size = new Size(169, 24);
            txtNationalNO.TabIndex = 13;
            txtNationalNO.Validating += ValidateNationalNO;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(986, 38);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(40, 20);
            lblLastName.TabIndex = 11;
            lblLastName.Text = "Last";
            // 
            // lblThirdName
            // 
            lblThirdName.AutoSize = true;
            lblThirdName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThirdName.Location = new Point(743, 38);
            lblThirdName.Name = "lblThirdName";
            lblThirdName.Size = new Size(44, 20);
            lblThirdName.TabIndex = 12;
            lblThirdName.Text = "Third";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(931, 61);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(169, 24);
            txtLastName.TabIndex = 11;
            txtLastName.Validating += ValidateEmptyTextBox;
            // 
            // txtThirdName
            // 
            txtThirdName.BorderStyle = BorderStyle.FixedSingle;
            txtThirdName.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtThirdName.Location = new Point(692, 61);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(169, 24);
            txtThirdName.TabIndex = 9;
            // 
            // lblSecondName
            // 
            lblSecondName.AutoSize = true;
            lblSecondName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSecondName.Location = new Point(494, 38);
            lblSecondName.Name = "lblSecondName";
            lblSecondName.Size = new Size(64, 20);
            lblSecondName.TabIndex = 10;
            lblSecondName.Text = "Second";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(270, 38);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(40, 20);
            lblFirstName.TabIndex = 9;
            lblFirstName.Text = "First";
            // 
            // txtSecondName
            // 
            txtSecondName.BorderStyle = BorderStyle.FixedSingle;
            txtSecondName.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtSecondName.Location = new Point(453, 61);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(169, 24);
            txtSecondName.TabIndex = 8;
            txtSecondName.Validating += ValidateEmptyTextBox;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtFirstName.Location = new Point(214, 61);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(169, 24);
            txtFirstName.TabIndex = 7;
            txtFirstName.Validating += ValidateEmptyTextBox;
            // 
            // pbPersonID
            // 
            pbPersonID.Image = Properties.Resources.person_id;
            pbPersonID.Location = new Point(163, 93);
            pbPersonID.Name = "pbPersonID";
            pbPersonID.Size = new Size(35, 30);
            pbPersonID.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonID.TabIndex = 8;
            pbPersonID.TabStop = false;
            // 
            // lblPersonID_result
            // 
            lblPersonID_result.AutoSize = true;
            lblPersonID_result.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonID_result.Location = new Point(204, 99);
            lblPersonID_result.Name = "lblPersonID_result";
            lblPersonID_result.Size = new Size(42, 24);
            lblPersonID_result.TabIndex = 10;
            lblPersonID_result.Text = "N/A";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddEditPerson
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.Window;
            CancelButton = btnClose;
            ClientSize = new Size(1296, 622);
            Controls.Add(lblPersonID_result);
            Controls.Add(pbPersonID);
            Controls.Add(gbPersonDetails);
            Controls.Add(lblPersonID);
            Controls.Add(lblAddEditHeader);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAddEditPerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddEditPerson";
            Load += frmAddEditPerson_Load;
            gbPersonDetails.ResumeLayout(false);
            gbPersonDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCountry).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDateOfBirth).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGender_Female).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGender_Male).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNationalNO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonID).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddEditHeader;
        private Label lblPersonID;
        private Label lblName;
        private Label lblNationalNO;
        private Label lblGender;
        private Label lblEmail;
        private Label lblAddress;
        private GroupBox gbPersonDetails;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtThirdName;
        private Label lblSecondName;
        private Label lblFirstName;
        private TextBox txtSecondName;
        private Label lblDateOfBirth;
        private TextBox txtNationalNO;
        private Label lblLastName;
        private Label lblThirdName;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label lblCountry;
        private TextBox txtEmail;
        private DateTimePicker dtDateOfBirth;
        private TextBox txtAddress;
        private Label lblPhone;
        private ComboBox cbCountry;
        private PictureBox pbPersonImage;
        private TextBox txtPhone;
        private PictureBox pbGender_Male;
        private PictureBox pbNationalNO;
        private PictureBox pbPersonName;
        private PictureBox pbPersonID;
        private PictureBox pbGender_Female;
        private PictureBox pbDateOfBirth;
        private PictureBox pbAddress;
        private PictureBox pbEmail;
        private PictureBox pbCountry;
        private PictureBox pictureBox1;
        private Button btnSave;
        private PictureBox pbSave;
        private Button btnClose;
        private PictureBox pictureBox2;
        private LinkLabel llblRemoveImage;
        private LinkLabel llblSetImage;
        private Label lblPersonID_result;
        private ErrorProvider errorProvider1;
    }
}