namespace DVLD
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msMain = new MenuStrip();
            tsmiApplications = new ToolStripMenuItem();
            tsmiLicenseServices = new ToolStripMenuItem();
            tsmiNewDrivingLicense = new ToolStripMenuItem();
            tsmiLocalLicenseApplication = new ToolStripMenuItem();
            tsmiInternationalLicenseApplication = new ToolStripMenuItem();
            tsmiRenewDrivingLicense = new ToolStripMenuItem();
            tsmiReplacementForLostOrDamagedLicense = new ToolStripMenuItem();
            tsmiReleaseDetainedLicense = new ToolStripMenuItem();
            tsmiRetakeTest = new ToolStripMenuItem();
            tsmiManageApplications = new ToolStripMenuItem();
            tsmiLocalDrivingLicenseApplication = new ToolStripMenuItem();
            tsmiInternationalDrivingLicenseApplication = new ToolStripMenuItem();
            tsmiDetainLicenses = new ToolStripMenuItem();
            tsmiManageDetainedLicenses = new ToolStripMenuItem();
            tsmiDetainLicense = new ToolStripMenuItem();
            tsmi_ReleaseDetainedLicense = new ToolStripMenuItem();
            tsmiManageApplication = new ToolStripMenuItem();
            tsmiManageTestTypes = new ToolStripMenuItem();
            tsmiPeople = new ToolStripMenuItem();
            tsmiDrivers = new ToolStripMenuItem();
            tsmiUsers = new ToolStripMenuItem();
            tsmiAccountSettings = new ToolStripMenuItem();
            tsmiCurrentUserInfo = new ToolStripMenuItem();
            tsmiChangePassword = new ToolStripMenuItem();
            tsmiSignOut = new ToolStripMenuItem();
            msMain.SuspendLayout();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msMain.ImageScalingSize = new Size(32, 32);
            msMain.Items.AddRange(new ToolStripItem[] { tsmiApplications, tsmiPeople, tsmiDrivers, tsmiUsers, tsmiAccountSettings });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(984, 40);
            msMain.TabIndex = 1;
            msMain.Text = "menuStrip1";
            // 
            // tsmiApplications
            // 
            tsmiApplications.DropDownItems.AddRange(new ToolStripItem[] { tsmiLicenseServices, tsmiManageApplications, tsmiDetainLicenses, tsmiManageApplication, tsmiManageTestTypes });
            tsmiApplications.Image = Properties.Resources.applications;
            tsmiApplications.Name = "tsmiApplications";
            tsmiApplications.Size = new Size(139, 36);
            tsmiApplications.Text = "Applications";
            // 
            // tsmiLicenseServices
            // 
            tsmiLicenseServices.DropDownItems.AddRange(new ToolStripItem[] { tsmiNewDrivingLicense, tsmiRenewDrivingLicense, tsmiReplacementForLostOrDamagedLicense, tsmiReleaseDetainedLicense, tsmiRetakeTest });
            tsmiLicenseServices.Image = Properties.Resources.driving_license_services;
            tsmiLicenseServices.Name = "tsmiLicenseServices";
            tsmiLicenseServices.Size = new Size(277, 38);
            tsmiLicenseServices.Text = "Driving License Services";
            // 
            // tsmiNewDrivingLicense
            // 
            tsmiNewDrivingLicense.DropDownItems.AddRange(new ToolStripItem[] { tsmiLocalLicenseApplication, tsmiInternationalLicenseApplication });
            tsmiNewDrivingLicense.Image = Properties.Resources.new_driving_license;
            tsmiNewDrivingLicense.Name = "tsmiNewDrivingLicense";
            tsmiNewDrivingLicense.Size = new Size(388, 38);
            tsmiNewDrivingLicense.Text = "New Driving License";
            // 
            // tsmiLocalLicenseApplication
            // 
            tsmiLocalLicenseApplication.Image = Properties.Resources.local_license;
            tsmiLocalLicenseApplication.Name = "tsmiLocalLicenseApplication";
            tsmiLocalLicenseApplication.Size = new Size(239, 38);
            tsmiLocalLicenseApplication.Text = "Local License";
            // 
            // tsmiInternationalLicenseApplication
            // 
            tsmiInternationalLicenseApplication.Image = Properties.Resources.international_license;
            tsmiInternationalLicenseApplication.Name = "tsmiInternationalLicenseApplication";
            tsmiInternationalLicenseApplication.Size = new Size(239, 38);
            tsmiInternationalLicenseApplication.Text = "International License";
            // 
            // tsmiRenewDrivingLicense
            // 
            tsmiRenewDrivingLicense.Image = Properties.Resources.renew_driving_license;
            tsmiRenewDrivingLicense.Name = "tsmiRenewDrivingLicense";
            tsmiRenewDrivingLicense.Size = new Size(388, 38);
            tsmiRenewDrivingLicense.Text = "Renew Driving License";
            // 
            // tsmiReplacementForLostOrDamagedLicense
            // 
            tsmiReplacementForLostOrDamagedLicense.Image = Properties.Resources.replacement_for_lost_or_damaged_license;
            tsmiReplacementForLostOrDamagedLicense.Name = "tsmiReplacementForLostOrDamagedLicense";
            tsmiReplacementForLostOrDamagedLicense.Size = new Size(388, 38);
            tsmiReplacementForLostOrDamagedLicense.Text = "Replacement for Lost or Damaged License";
            // 
            // tsmiReleaseDetainedLicense
            // 
            tsmiReleaseDetainedLicense.Image = Properties.Resources.release_detained_driving_license;
            tsmiReleaseDetainedLicense.Name = "tsmiReleaseDetainedLicense";
            tsmiReleaseDetainedLicense.Size = new Size(388, 38);
            tsmiReleaseDetainedLicense.Text = "Release Detained Driver License";
            // 
            // tsmiRetakeTest
            // 
            tsmiRetakeTest.Image = Properties.Resources.retake_test;
            tsmiRetakeTest.Name = "tsmiRetakeTest";
            tsmiRetakeTest.Size = new Size(388, 38);
            tsmiRetakeTest.Text = "Retake Test";
            // 
            // tsmiManageApplications
            // 
            tsmiManageApplications.DropDownItems.AddRange(new ToolStripItem[] { tsmiLocalDrivingLicenseApplication, tsmiInternationalDrivingLicenseApplication });
            tsmiManageApplications.Image = Properties.Resources.manage_applications;
            tsmiManageApplications.Name = "tsmiManageApplications";
            tsmiManageApplications.Size = new Size(277, 38);
            tsmiManageApplications.Text = "Manage Applications";
            // 
            // tsmiLocalDrivingLicenseApplication
            // 
            tsmiLocalDrivingLicenseApplication.Image = Properties.Resources.local_driving_license_application;
            tsmiLocalDrivingLicenseApplication.Name = "tsmiLocalDrivingLicenseApplication";
            tsmiLocalDrivingLicenseApplication.Size = new Size(376, 38);
            tsmiLocalDrivingLicenseApplication.Text = "Local Driving License Application";
            // 
            // tsmiInternationalDrivingLicenseApplication
            // 
            tsmiInternationalDrivingLicenseApplication.Image = Properties.Resources.international_driving_license_applications;
            tsmiInternationalDrivingLicenseApplication.Name = "tsmiInternationalDrivingLicenseApplication";
            tsmiInternationalDrivingLicenseApplication.Size = new Size(376, 38);
            tsmiInternationalDrivingLicenseApplication.Text = "International Driving License Application";
            // 
            // tsmiDetainLicenses
            // 
            tsmiDetainLicenses.DropDownItems.AddRange(new ToolStripItem[] { tsmiManageDetainedLicenses, tsmiDetainLicense, tsmi_ReleaseDetainedLicense });
            tsmiDetainLicenses.Image = Properties.Resources.detain_licenses;
            tsmiDetainLicenses.Name = "tsmiDetainLicenses";
            tsmiDetainLicenses.Size = new Size(277, 38);
            tsmiDetainLicenses.Text = "Detain Licenses";
            // 
            // tsmiManageDetainedLicenses
            // 
            tsmiManageDetainedLicenses.Image = Properties.Resources.manage_detained_licenses;
            tsmiManageDetainedLicenses.Name = "tsmiManageDetainedLicenses";
            tsmiManageDetainedLicenses.Size = new Size(280, 38);
            tsmiManageDetainedLicenses.Text = "Manage Detained Licenses";
            // 
            // tsmiDetainLicense
            // 
            tsmiDetainLicense.Image = Properties.Resources.detain_license;
            tsmiDetainLicense.Name = "tsmiDetainLicense";
            tsmiDetainLicense.Size = new Size(280, 38);
            tsmiDetainLicense.Text = "Detain License";
            // 
            // tsmi_ReleaseDetainedLicense
            // 
            tsmi_ReleaseDetainedLicense.Image = Properties.Resources.release_detained_driving_license;
            tsmi_ReleaseDetainedLicense.Name = "tsmi_ReleaseDetainedLicense";
            tsmi_ReleaseDetainedLicense.Size = new Size(280, 38);
            tsmi_ReleaseDetainedLicense.Text = "Release Detained License";
            // 
            // tsmiManageApplication
            // 
            tsmiManageApplication.Image = Properties.Resources.manage_application_types;
            tsmiManageApplication.Name = "tsmiManageApplication";
            tsmiManageApplication.Size = new Size(277, 38);
            tsmiManageApplication.Text = "Manage Application Types";
            // 
            // tsmiManageTestTypes
            // 
            tsmiManageTestTypes.Image = Properties.Resources.manage_test_types;
            tsmiManageTestTypes.Name = "tsmiManageTestTypes";
            tsmiManageTestTypes.Size = new Size(277, 38);
            tsmiManageTestTypes.Text = "Manage Test Types";
            // 
            // tsmiPeople
            // 
            tsmiPeople.Image = Properties.Resources.people;
            tsmiPeople.Name = "tsmiPeople";
            tsmiPeople.Size = new Size(100, 36);
            tsmiPeople.Text = "People";
            // 
            // tsmiDrivers
            // 
            tsmiDrivers.Image = Properties.Resources.drivers;
            tsmiDrivers.Name = "tsmiDrivers";
            tsmiDrivers.Size = new Size(104, 36);
            tsmiDrivers.Text = "Drivers";
            // 
            // tsmiUsers
            // 
            tsmiUsers.Image = Properties.Resources.users;
            tsmiUsers.Name = "tsmiUsers";
            tsmiUsers.Size = new Size(93, 36);
            tsmiUsers.Text = "Users";
            // 
            // tsmiAccountSettings
            // 
            tsmiAccountSettings.DropDownItems.AddRange(new ToolStripItem[] { tsmiCurrentUserInfo, tsmiChangePassword, tsmiSignOut });
            tsmiAccountSettings.Image = Properties.Resources.account_settings;
            tsmiAccountSettings.Name = "tsmiAccountSettings";
            tsmiAccountSettings.Size = new Size(170, 36);
            tsmiAccountSettings.Text = "Account Settings";
            // 
            // tsmiCurrentUserInfo
            // 
            tsmiCurrentUserInfo.Image = Properties.Resources.current_user_info;
            tsmiCurrentUserInfo.Name = "tsmiCurrentUserInfo";
            tsmiCurrentUserInfo.Size = new Size(219, 38);
            tsmiCurrentUserInfo.Text = "Current User Info";
            // 
            // tsmiChangePassword
            // 
            tsmiChangePassword.Image = Properties.Resources.change_password;
            tsmiChangePassword.Name = "tsmiChangePassword";
            tsmiChangePassword.Size = new Size(219, 38);
            tsmiChangePassword.Text = "Change Password";
            // 
            // tsmiSignOut
            // 
            tsmiSignOut.Image = Properties.Resources.sign_out;
            tsmiSignOut.Name = "tsmiSignOut";
            tsmiSignOut.Size = new Size(219, 38);
            tsmiSignOut.Text = "Sign Out";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Driving_Licence_App_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 561);
            Controls.Add(msMain);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = msMain;
            MinimumSize = new Size(1000, 600);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Driver License Management";
            WindowState = FormWindowState.Maximized;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem tsmiApplications;
        private ToolStripMenuItem tsmiLicenseServices;
        private ToolStripMenuItem tsmiManageApplications;
        private ToolStripMenuItem tsmiDetainLicenses;
        private ToolStripMenuItem tsmiManageApplication;
        private ToolStripMenuItem tsmiManageTestTypes;
        private ToolStripMenuItem tsmiPeople;
        private ToolStripMenuItem tsmiDrivers;
        private ToolStripMenuItem tsmiUsers;
        private ToolStripMenuItem tsmiAccountSettings;
        private ToolStripMenuItem tsmiNewDrivingLicense;
        private ToolStripMenuItem tsmiLocalLicenseApplication;
        private ToolStripMenuItem tsmiInternationalLicenseApplication;
        private ToolStripMenuItem tsmiRenewDrivingLicense;
        private ToolStripMenuItem tsmiReplacementForLostOrDamagedLicense;
        private ToolStripMenuItem tsmiReleaseDetainedLicense;
        private ToolStripMenuItem tsmiRetakeTest;
        private ToolStripMenuItem tsmiLocalDrivingLicenseApplication;
        private ToolStripMenuItem tsmiInternationalDrivingLicenseApplication;
        private ToolStripMenuItem tsmiManageDetainedLicenses;
        private ToolStripMenuItem tsmiDetainLicense;
        private ToolStripMenuItem tsmi_ReleaseDetainedLicense;
        private ToolStripMenuItem tsmiCurrentUserInfo;
        private ToolStripMenuItem tsmiChangePassword;
        private ToolStripMenuItem tsmiSignOut;
    }
}
