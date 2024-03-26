namespace AutoKeyboard
{
    partial class MainForm
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
            txtContent = new TextBox();
            btnStart = new Button();
            txtSleep = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtContent
            // 
            txtContent.Location = new Point(12, 12);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Both;
            txtContent.Size = new Size(574, 194);
            txtContent.TabIndex = 0;
            txtContent.TextChanged += txtContent_TextChanged;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(492, 215);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 30);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtSleep
            // 
            txtSleep.Location = new Point(93, 220);
            txtSleep.MaxLength = 100;
            txtSleep.Name = "txtSleep";
            txtSleep.Size = new Size(70, 23);
            txtSleep.TabIndex = 2;
            txtSleep.Text = "3";
            txtSleep.TextChanged += txtSleep_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 223);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 3;
            label1.Text = "Waiting time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 223);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 4;
            label2.Text = "(s)";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 278);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSleep);
            Controls.Add(btnStart);
            Controls.Add(txtContent);
            MaximizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Keyboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContent;
        private Button btnStart;
        private TextBox txtSleep;
        private Label label1;
        private Label label2;
    }
}
