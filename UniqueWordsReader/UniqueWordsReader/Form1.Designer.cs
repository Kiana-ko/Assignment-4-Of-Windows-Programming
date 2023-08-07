namespace UniqueWordsReader
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
            UniqueWordsDisplayerButton = new Button();
            CloseButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            listBox1 = new ListBox();
            FilePathReaderTextBox = new RichTextBox();
            label1 = new Label();
            instructionsBox = new RichTextBox();
            SuspendLayout();
            // 
            // UniqueWordsDisplayerButton
            // 
            UniqueWordsDisplayerButton.Location = new Point(525, 303);
            UniqueWordsDisplayerButton.Name = "UniqueWordsDisplayerButton";
            UniqueWordsDisplayerButton.Size = new Size(116, 41);
            UniqueWordsDisplayerButton.TabIndex = 0;
            UniqueWordsDisplayerButton.Text = "Display \r\nUnique Words";
            UniqueWordsDisplayerButton.UseVisualStyleBackColor = true;
            UniqueWordsDisplayerButton.Click += UniqueWordsDisplayerButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.Location = new Point(320, 303);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(113, 41);
            CloseButton.TabIndex = 1;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 25);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(266, 319);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FilePathReaderTextBox
            // 
            FilePathReaderTextBox.Location = new Point(320, 184);
            FilePathReaderTextBox.Name = "FilePathReaderTextBox";
            FilePathReaderTextBox.Size = new Size(321, 106);
            FilePathReaderTextBox.TabIndex = 3;
            FilePathReaderTextBox.Text = "";
            FilePathReaderTextBox.TextChanged += FilePathReaderTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(320, 29);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 4;
            label1.Text = "INSTRUCTIONS:";
            label1.Click += label1_Click;
            // 
            // instructionsBox
            // 
            instructionsBox.BackColor = SystemColors.ControlDark;
            instructionsBox.BorderStyle = BorderStyle.None;
            instructionsBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            instructionsBox.ForeColor = SystemColors.ActiveCaptionText;
            instructionsBox.Location = new Point(320, 52);
            instructionsBox.Name = "instructionsBox";
            instructionsBox.Size = new Size(321, 111);
            instructionsBox.TabIndex = 5;
            instructionsBox.Text = resources.GetString("instructionsBox.Text");
            instructionsBox.TextChanged += instructionsBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(753, 363);
            Controls.Add(instructionsBox);
            Controls.Add(label1);
            Controls.Add(FilePathReaderTextBox);
            Controls.Add(listBox1);
            Controls.Add(CloseButton);
            Controls.Add(UniqueWordsDisplayerButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UniqueWordsDisplayerButton;
        private Button CloseButton;
        private OpenFileDialog openFileDialog1;
        private ListBox listBox1;
        private RichTextBox FilePathReaderTextBox;
        private Label label1;
        private RichTextBox instructionsBox;
    }
}