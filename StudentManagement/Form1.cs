namespace StudentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddst_Click(object sender, EventArgs e)
        {
            lblResult.Text = txtStName.Text + " " + txtStSrname.Text;
        }
    }
}