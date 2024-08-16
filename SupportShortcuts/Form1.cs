using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace SupportShortcuts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void Form1_Load(object sender, EventArgs e)
        {
            //AllocConsole();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
        }

        private void copyAllButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(outputTextBox.Text))
            {
                Clipboard.SetText(outputTextBox.Text);

                MessageBox.Show("Text copied to clipboard.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is no text to copy.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            inputTextBox.SelectAll();
            inputTextBox.Focus();
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addApostropheButton_Click(object sender, EventArgs e)
        {
            string[] inputText = inputTextBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            StringBuilder modifiedText = new StringBuilder();

            for (int i = 0; i < inputText.Length; i++)
            {
                string curr = inputText[i];
                curr = curr.Trim();
                if (curr.Length == 0)
                    continue;

                string modifiedLine = "'" + curr + "'";

                if (i < inputText.Length - 1)
                    modifiedText.AppendLine(modifiedLine);
                else
                    modifiedText.Append(modifiedLine);
            }

            outputTextBox.Text = modifiedText.ToString();
            inputTextBox.Text = modifiedText.ToString();
        }

        private void addUnderScore1Button_Click(object sender, EventArgs e)
        {
            string[] inputText = inputTextBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            StringBuilder modifiedText = new StringBuilder();

            for (int i = 0; i < inputText.Length; i++)
            {
                string curr = inputText[i];
                curr = curr.Trim();
                if (curr.Length == 0)
                    continue;

                string modifiedLine = curr + "_1";

                if (i < inputText.Length - 1)
                    modifiedText.AppendLine(modifiedLine);
                else
                    modifiedText.Append(modifiedLine);
            }

            outputTextBox.Text = modifiedText.ToString();
            inputTextBox.Text = modifiedText.ToString();
        }

        private void addCommaButton_Click(object sender, EventArgs e)
        {
            string[] inputText = inputTextBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            StringBuilder modifiedText = new StringBuilder();

            for (int i = 0; i < inputText.Length; i++)
            {
                string curr = inputText[i];
                curr = curr.Trim();
                if (curr.Length == 0)
                    continue;

                string modifiedLine = curr;

                if (i < inputText.Length - 1)
                    modifiedLine += ",";

                modifiedText.Append(modifiedLine);

                if (i < inputText.Length - 1)
                    modifiedText.AppendLine();
            }

            outputTextBox.Text = modifiedText.ToString();
            inputTextBox.Text = modifiedText.ToString();
        }
    }
}
