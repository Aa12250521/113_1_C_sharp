/*-------------------------------------------------------------------------
      �Z��:��ޣ���
      �Ǹ�:A113221049
 */
namespace toturial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //��ܼ��J�P�I��
        private void btnshowback_Click(object sender, EventArgs e)
        {
            pitback.Visible = true;
            pitfront.Visible = false;
        
        }
        //��ܼ��J�P����
        private void pitback_Click(object sender, EventArgs e)
        {
            pitback.Visible = false;
            pitfront.Visible = true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
