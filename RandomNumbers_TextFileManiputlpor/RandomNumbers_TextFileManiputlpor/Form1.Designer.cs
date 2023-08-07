namespace RandomNumbers_TextFileManiputlpor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            CloseButton = new Button();
            FileReaderButton = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(30, 62);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(226, 199);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.Location = new Point(455, 223);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(97, 39);
            CloseButton.TabIndex = 1;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // FileReaderButton
            // 
            FileReaderButton.Location = new Point(290, 223);
            FileReaderButton.Name = "FileReaderButton";
            FileReaderButton.Size = new Size(97, 39);
            FileReaderButton.TabIndex = 2;
            FileReaderButton.Text = "Read File";
            FileReaderButton.UseVisualStyleBackColor = true;
            FileReaderButton.Click += FileReaderButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ControlDark;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(299, 75);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(262, 129);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "\n INSTRUCTIONS:\n\nClick the \"Read File\" button to view values falling within the range of 1 through 10. Afterward, select the file of your choice.\n";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(213, 15);
            label1.TabIndex = 5;
            label1.Text = "Values within the range of 1 through 10\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(587, 307);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(FileReaderButton);
            Controls.Add(CloseButton);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Ranom Number Displayer";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button CloseButton;
        private Button FileReaderButton;
        private RichTextBox richTextBox1;
        private Label label1;
        private OpenFileDialog openFileDialog1;
    }
}