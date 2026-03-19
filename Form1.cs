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
            if (txtMsg.Text.Length > 50)
            {
                MessageBox.Show("메시지는 50자까지만 입력 가능합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string rawInput = txtMsg.Text.Trim();

            if (!string.IsNullOrWhiteSpace(rawInput))
            {
                string timestamp = DateTime.Now.ToString("[HH:mm:ss]");
                lsbMsg.Items.Add($"{timestamp} {rawInput}");

                lblCount.Text = $"현재 대화: {lsbMsg.Items.Count}개";

                txtMsg.Clear();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsbMsg.SelectedIndex != -1)
            {

                lsbMsg.Items.RemoveAt(lsbMsg.SelectedIndex);


                lblCount.Text = $"현재 대화: {lsbMsg.Items.Count}개";
            }
            else
            {

                MessageBox.Show("삭제할 항목을 먼저 선택해주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lsbMsg.Items.Clear();

            
            lblCount.Text = "현재 대화: 0개";

            MessageBox.Show("모든 대화 기록이 삭제되었습니다.");
        }
    }
}
