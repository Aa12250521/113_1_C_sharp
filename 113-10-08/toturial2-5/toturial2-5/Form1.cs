/*-------------------------------------------------------------------------
      班級:資管ㄧ甲
      學號:A113221049
 */
namespace toturial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //顯示撲克牌背面
        private void btnshowback_Click(object sender, EventArgs e)
        {
            pitback.Visible = true;
            pitfront.Visible = false;
        
        }
        //顯示撲克牌正面
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
