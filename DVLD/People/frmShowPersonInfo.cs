using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmShowPersonInfo : Form
    {
        int _PersonID = -1;
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonInformation1.LoadPersonData(_PersonID);
          
        }
    }
}
