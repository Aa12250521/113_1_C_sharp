namespace testbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncomfirm_Click(object sender, EventArgs e)
        {
            string fullname;
            string firstname;
            stringv lastname;

            firstname = txtfirstname.Text;
            lastname = txtlastname.Text;
            fullname = lastname + "" + firstname;

            LBL.Text = fullname;
        }

        private void LBL_Click(object sender, EventArgs e)
        {

        }
    }
}
