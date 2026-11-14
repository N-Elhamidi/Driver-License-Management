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
            People.frmListPeople frmListPeople= new People.frmListPeople();

            frmListPeople.MdiParent = this;

            frmListPeople.Show();
        }
    }
}
