namespace PoiskRusskogoXP
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.СhooseFileButton = new System.Windows.Forms.Button();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.LabelLogWindow = new System.Windows.Forms.Label();
            this.AutoCorrectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // СhooseFileButton
            // 
            this.СhooseFileButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.СhooseFileButton, "СhooseFileButton");
            this.СhooseFileButton.Name = "СhooseFileButton";
            this.СhooseFileButton.UseVisualStyleBackColor = false;
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FilePathLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.FilePathLabel, "FilePathLabel");
            this.FilePathLabel.Name = "FilePathLabel";
            // 
            // LabelLogWindow
            // 
            this.LabelLogWindow.BackColor = System.Drawing.SystemColors.MenuText;
            this.LabelLogWindow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.LabelLogWindow, "LabelLogWindow");
            this.LabelLogWindow.Name = "LabelLogWindow";
            // 
            // AutoCorrectButton
            // 
            resources.ApplyResources(this.AutoCorrectButton, "AutoCorrectButton");
            this.AutoCorrectButton.Name = "AutoCorrectButton";
            this.AutoCorrectButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.AutoCorrectButton);
            this.Controls.Add(this.LabelLogWindow);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.СhooseFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button СhooseFileButton;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Label LabelLogWindow;
        private System.Windows.Forms.Button AutoCorrectButton;
    }
}

