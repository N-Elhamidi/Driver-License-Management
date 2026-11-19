namespace DVLD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsmiPeople_Click(object sender, EventArgs e)
        {
            People.frmManagePeople ManagePeople= new People.frmManagePeople();

            ManagePeople.MdiParent = this;

           ManagePeople.Show();
        }
    }
}
