namespace Converter.UI
{
    partial class MainWindow
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
            sourceFileDialog = new OpenFileDialog();
            SourceFileName = new TextBox();
            destinationFileDialog = new SaveFileDialog();
            OpenFileButton = new Button();
            label1 = new Label();
            convertButton = new Button();
            SuspendLayout();
            // 
            // sourceFileDialog
            // 
            sourceFileDialog.FileName = "*.ofx";
            sourceFileDialog.Filter = "OFX Files|*.ofx;*.qfx|All files|*.*";
            // 
            // SourceFileName
            // 
            SourceFileName.Location = new Point(128, 66);
            SourceFileName.Name = "SourceFileName";
            SourceFileName.ReadOnly = true;
            SourceFileName.Size = new Size(331, 27);
            SourceFileName.TabIndex = 0;
            SourceFileName.Click += OpenFileButton_Click;
            // 
            // destinationFileDialog
            // 
            destinationFileDialog.DefaultExt = "ofx";
            destinationFileDialog.FileName = "money.ofx";
            destinationFileDialog.Filter = "OFX File|*.ofx|All files|*.*";
            // 
            // OpenFileButton
            // 
            OpenFileButton.Location = new Point(465, 65);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(94, 29);
            OpenFileButton.TabIndex = 1;
            OpenFileButton.Text = "&Browse...";
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 2;
            label1.Text = "Source OFX File";
            // 
            // convertButton
            // 
            convertButton.Location = new Point(12, 93);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(547, 29);
            convertButton.TabIndex = 3;
            convertButton.Text = "&Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 163);
            Controls.Add(convertButton);
            Controls.Add(label1);
            Controls.Add(OpenFileButton);
            Controls.Add(SourceFileName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            Text = "BoursoBank OFX Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog sourceFileDialog;
        private TextBox SourceFileName;
        private SaveFileDialog destinationFileDialog;
        private Button OpenFileButton;
        private Label label1;
        private Button convertButton;
    }
}
