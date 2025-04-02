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
            if (!CheckFileExtension(SourceFileName.Text))
            {
                SourceFileName.Text = "";
                return;
            }

            destinationFileDialog.FileName = Path.GetFileNameWithoutExtension(SourceFileName.Text) + ".converted.ofx";
            var saveFileResult = destinationFileDialog.ShowDialog();
            if (saveFileResult != DialogResult.OK)
            {
                return;
            }

            var convertedOfx = Tool.ConvertToValidOfx(SourceFileName.Text);

            File.WriteAllText(destinationFileDialog.FileName, convertedOfx);

            MessageBox.Show("Conversion completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckFileExtension(string filename)
        {
            if (Path.GetExtension(filename) != ".ofx")
            {
                MessageBox.Show("Please select a valid OFX file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dragZone.BorderStyle = BorderStyle.None;
                return false;
            }
            return true;
        }

        private void dragZone_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            {
                e.Effect = DragDropEffects.Copy;
                dragZone.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                dragZone.BorderStyle = BorderStyle.None;
            }
        }

        private void dragZone_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            {
                string[]? files = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (files?.Length > 0)
                {
                    if (!CheckFileExtension(files[0]))
                    {
                        return;
                    }

                    SourceFileName.Text = files[0];
                }
            }

            dragZone.BorderStyle = BorderStyle.None;
        }

        private void dragZone_DragLeave(object sender, EventArgs e)
        {
            dragZone.BorderStyle = BorderStyle.None;
        }
    }
}
