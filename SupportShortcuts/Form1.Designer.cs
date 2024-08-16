namespace SupportShortcuts
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputTextBox = new RichTextBox();
            outputTextBox = new RichTextBox();
            clearAllButton = new Button();
            copyAllButton = new Button();
            selectAllButton = new Button();
            addApostropheButton = new Button();
            addUnderScore1Button = new Button();
            addCommaButton = new Button();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(0, 0);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(326, 591);
            inputTextBox.TabIndex = 0;
            inputTextBox.Text = "";
            inputTextBox.WordWrap = false;
            inputTextBox.TextChanged += inputTextBox_TextChanged;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(605, 0);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(326, 591);
            outputTextBox.TabIndex = 1;
            outputTextBox.Text = "";
            outputTextBox.WordWrap = false;
            outputTextBox.TextChanged += outputTextBox_TextChanged;
            // 
            // clearAllButton
            // 
            clearAllButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            clearAllButton.Location = new Point(371, 441);
            clearAllButton.Name = "clearAllButton";
            clearAllButton.Size = new Size(188, 42);
            clearAllButton.TabIndex = 2;
            clearAllButton.Text = "Temizle";
            clearAllButton.UseVisualStyleBackColor = true;
            clearAllButton.Click += clearAllButton_Click;
            // 
            // copyAllButton
            // 
            copyAllButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            copyAllButton.Location = new Point(371, 393);
            copyAllButton.Name = "copyAllButton";
            copyAllButton.Size = new Size(188, 42);
            copyAllButton.TabIndex = 3;
            copyAllButton.Text = "Kopyala";
            copyAllButton.UseVisualStyleBackColor = true;
            copyAllButton.Click += copyAllButton_Click;
            // 
            // selectAllButton
            // 
            selectAllButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            selectAllButton.Location = new Point(371, 345);
            selectAllButton.Name = "selectAllButton";
            selectAllButton.Size = new Size(188, 42);
            selectAllButton.TabIndex = 4;
            selectAllButton.Text = "Hepsini Seç";
            selectAllButton.UseVisualStyleBackColor = true;
            selectAllButton.Click += selectAllButton_Click;
            // 
            // addApostropheButton
            // 
            addApostropheButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addApostropheButton.Location = new Point(371, 297);
            addApostropheButton.Name = "addApostropheButton";
            addApostropheButton.Size = new Size(188, 42);
            addApostropheButton.TabIndex = 5;
            addApostropheButton.Text = "Tirnak ekle";
            addApostropheButton.UseVisualStyleBackColor = true;
            addApostropheButton.Click += addApostropheButton_Click;
            // 
            // addUnderScore1Button
            // 
            addUnderScore1Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addUnderScore1Button.Location = new Point(371, 250);
            addUnderScore1Button.Name = "addUnderScore1Button";
            addUnderScore1Button.Size = new Size(188, 42);
            addUnderScore1Button.TabIndex = 6;
            addUnderScore1Button.Text = "_1 ekle";
            addUnderScore1Button.UseVisualStyleBackColor = true;
            addUnderScore1Button.Click += addUnderScore1Button_Click;
            // 
            // addCommaButton
            // 
            addCommaButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addCommaButton.Location = new Point(371, 202);
            addCommaButton.Name = "addCommaButton";
            addCommaButton.Size = new Size(188, 42);
            addCommaButton.TabIndex = 7;
            addCommaButton.Text = "virgül ekle";
            addCommaButton.UseVisualStyleBackColor = true;
            addCommaButton.Click += addCommaButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 592);
            Controls.Add(addCommaButton);
            Controls.Add(addUnderScore1Button);
            Controls.Add(addApostropheButton);
            Controls.Add(selectAllButton);
            Controls.Add(copyAllButton);
            Controls.Add(clearAllButton);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox inputTextBox;
        private RichTextBox outputTextBox;
        private Button clearAllButton;
        private Button copyAllButton;
        private Button selectAllButton;
        private Button addApostropheButton;
        private Button addUnderScore1Button;
        private Button addCommaButton;
    }
}
