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
            this.AutoCorrectButton = new System.Windows.Forms.Button();
            this.LogWindow = new System.Windows.Forms.TextBox();
            this.PathShower = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // СhooseFileButton
            // 
            this.СhooseFileButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.СhooseFileButton, "СhooseFileButton");
            this.СhooseFileButton.Name = "СhooseFileButton";
            this.СhooseFileButton.UseVisualStyleBackColor = false;
            this.СhooseFileButton.Click += new System.EventHandler(this.СhooseFileButton_Click);
            // 
            // AutoCorrectButton
            // 
            resources.ApplyResources(this.AutoCorrectButton, "AutoCorrectButton");
            this.AutoCorrectButton.Name = "AutoCorrectButton";
            this.AutoCorrectButton.UseVisualStyleBackColor = true;
            // 
            // LogWindow
            // 
            this.LogWindow.BackColor = System.Drawing.SystemColors.MenuText;
            resources.ApplyResources(this.LogWindow, "LogWindow");
            this.LogWindow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogWindow.Name = "LogWindow";
            this.LogWindow.ReadOnly = true;
            // 
            // PathShower
            // 
            resources.ApplyResources(this.PathShower, "PathShower");
            this.PathShower.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PathShower.Name = "PathShower";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::PoiskRusskogoXP.Properties.Resources.BG;
            this.Controls.Add(this.PathShower);
            this.Controls.Add(this.LogWindow);
            this.Controls.Add(this.AutoCorrectButton);
            this.Controls.Add(this.СhooseFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button СhooseFileButton;
        public System.Windows.Forms.Button AutoCorrectButton;
        public System.Windows.Forms.TextBox LogWindow;
        public System.Windows.Forms.TextBox PathShower;
    }
}

