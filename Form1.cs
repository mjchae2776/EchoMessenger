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
            string rawInput = txtMsg.Text.Trim();

            
            if (!string.IsNullOrWhiteSpace(rawInput))
            {
               
                string timestamp = DateTime.Now.ToString("[HH:mm:ss]");

                
                string fullMessage = $"{timestamp} {rawInput}";
                lsbMsg.Items.Add(fullMessage);

                
                lblCount.Text = $"현재 대화: {lsbMsg.Items.Count}개";

                
                txtMsg.Clear();
                txtMsg.Focus();
            }
            else
            {
                
                txtMsg.Focus();
            }
        }

        private void lsbMsg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                btnSend_Click(sender, e);

            
            }
        }
    }
}
