using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string typed_msg;
            typed_msg = txtMsg.Text;
            lsbMsg.Items.Add(typed_msg);
        }

        private void lsbMsg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
