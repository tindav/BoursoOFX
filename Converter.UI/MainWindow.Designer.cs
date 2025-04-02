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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            sourceFileDialog = new OpenFileDialog();
            destinationFileDialog = new SaveFileDialog();
            dragZone = new Label();
            OpenFileButton = new Button();
            convertButton = new Button();
            label1 = new Label();
            SourceFileName = new TextBox();
            SuspendLayout();
            // 
            // sourceFileDialog
            // 
            sourceFileDialog.FileName = "*.ofx";
            sourceFileDialog.Filter = "OFX Files|*.ofx;*.qfx|All files|*.*";
            // 
            // destinationFileDialog
            // 
            destinationFileDialog.DefaultExt = "ofx";
            destinationFileDialog.FileName = "money.ofx";
            destinationFileDialog.Filter = "OFX File|*.ofx|All files|*.*";
            // 
            // dragZone
            // 
            dragZone.AllowDrop = true;
            dragZone.Dock = DockStyle.Top;
            dragZone.Font = new Font("Segoe UI", 24F);
            dragZone.Location = new Point(0, 0);
            dragZone.Name = "dragZone";
            dragZone.Size = new Size(597, 56);
            dragZone.TabIndex = 8;
            dragZone.Text = "Drop your file here ...";
            dragZone.TextAlign = ContentAlignment.TopCenter;
            dragZone.DragDrop += dragZone_DragDrop;
            dragZone.DragOver += dragZone_DragOver;
            dragZone.DragLeave += dragZone_DragLeave;
            // 
            // OpenFileButton
            // 
            OpenFileButton.Location = new Point(478, 74);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(94, 29);
            OpenFileButton.TabIndex = 10;
            OpenFileButton.Text = "&Browse...";
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(25, 109);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(547, 29);
            convertButton.TabIndex = 11;
            convertButton.Text = "&Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 78);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 12;
            label1.Text = "Source OFX File";
            // 
            // SourceFileName
            // 
            SourceFileName.Location = new Point(135, 76);
            SourceFileName.Name = "SourceFileName";
            SourceFileName.ReadOnly = true;
            SourceFileName.Size = new Size(337, 27);
            SourceFileName.TabIndex = 9;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 163);
            Controls.Add(dragZone);
            Controls.Add(OpenFileButton);
            Controls.Add(convertButton);
            Controls.Add(label1);
            Controls.Add(SourceFileName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            Text = "BoursoBank OFX Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog sourceFileDialog;
        private SaveFileDialog destinationFileDialog;
        private Label dragZone;
        private Button OpenFileButton;
        private Button convertButton;
        private Label label1;
        private TextBox SourceFileName;
    }
}
