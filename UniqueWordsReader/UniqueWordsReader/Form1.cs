using System.IO;

namespace UniqueWordsReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UniqueWordsDisplayerButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    FilePathReaderTextBox.Text = selectedFilePath;
                    DisplayUniqueWords(selectedFilePath);
                }
            }
        }
        public void DisplayUniqueWords(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                var wordFrequency = new Dictionary<string, int>();

                foreach (var line in lines)
                {
                    var words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        var cleanedWord = word.Trim(new char[] { '.', ',', '!', '?', '(', ')', '[', ']', '{', '}', '"', '\'' }).ToLower();
                        if (wordFrequency.ContainsKey(cleanedWord))
                        {
                            wordFrequency[cleanedWord]++;
                        }
                        else
                        {
                            wordFrequency[cleanedWord] = 1;
                        }
                    }
                }

                var uniqueWordsRepeatedOnce = wordFrequency
                     .Where(pair => pair.Value == 1)
                     .Select(pair => pair.Key)
                     .Distinct();


                listBox1.Items.Clear();
                listBox1.Items.AddRange(uniqueWordsRepeatedOnce.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilePathReaderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void instructionsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}