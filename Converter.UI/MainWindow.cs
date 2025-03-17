namespace Converter.UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            var openFileResult = sourceFileDialog.ShowDialog();
            if (openFileResult != DialogResult.OK)
            {
                return;
            }

            SourceFileName.Text = sourceFileDialog.FileName;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            destinationFileDialog.FileName = Path.GetFileNameWithoutExtension(SourceFileName.Text) + ".converted.ofx";
            var saveFileResult =  destinationFileDialog.ShowDialog();
            if (saveFileResult != DialogResult.OK)
            {
                return;
            }

            var convertedOfx = Tool.ConvertToValidOfx(SourceFileName.Text);

            File.WriteAllText(destinationFileDialog.FileName, convertedOfx);

            MessageBox.Show("Conversion completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
