namespace AutoKeyboard
{
    public partial class MainForm : Form
    {
        private bool isProcessRunning = false;

        public MainForm()
        {
            InitializeComponent();
            initControls();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isProcessRunning)
            {
                isProcessRunning = false;
                return;
            }

            DialogResult result = MessageBox.Show("Make sure of the following before starting:\n1. The current typing language is English\n2. The pointer is in a text editor", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            isProcessRunning = true;
            updateStatus();

            try
            {
                Thread.Sleep(Convert.ToInt32(txtSleep.Text) * 1000); // convert to milliseconds

                SendKeys.SendWait("");

                int index = 0;
                string content = txtContent.Text;

                while (isProcessRunning && index < content.Length)
                {
                    char c = content[index];
                    SendKeys.SendWait(convertEscapeChar(c));
                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            isProcessRunning = false;
            updateStatus();
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            initControls();
        }

        private void txtSleep_TextChanged(object sender, EventArgs e)
        {
            initControls();
        }

        private string convertEscapeChar(char c)
        {
            char[] specialChars = ['{', '}', '[', ']', '(', ')', '+', '^', '%', '~'];

            if (specialChars.Contains(c))
            {
                return "{" + c + "}";
            }

            return c.ToString();
        }

        private void updateStatus()
        {
            if (isProcessRunning)
            {
                btnStart.Text = "Stop";
                txtContent.Enabled = false;
                txtSleep.Enabled = false;
            }
            else
            {
                btnStart.Text = "Start";
                txtContent.Enabled = true;
                txtSleep.Enabled = true;
            }
        }

        private void initControls()
        {
            btnStart.Enabled = false;

            if (txtContent.Text != string.Empty && txtSleep.Text != string.Empty && int.TryParse(txtSleep.Text, out int _))
            {
                btnStart.Enabled = true;
            }
        }
    }
}
