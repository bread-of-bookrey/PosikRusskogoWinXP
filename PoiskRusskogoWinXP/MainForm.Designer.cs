namespace PoiskRusskogoWinXP
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
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.PathInputTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.InstructionLabel.Font = new System.Drawing.Font("ГОСТ тип А", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstructionLabel.Location = new System.Drawing.Point(13, 13);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Padding = new System.Windows.Forms.Padding(4);
            this.InstructionLabel.Size = new System.Drawing.Size(360, 40);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "Путь к проверяемому файлу:";
            // 
            // PathInputTextBox
            // 
            this.PathInputTextBox.Font = new System.Drawing.Font("ГОСТ тип А", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathInputTextBox.Location = new System.Drawing.Point(13, 57);
            this.PathInputTextBox.Name = "PathInputTextBox";
            this.PathInputTextBox.Size = new System.Drawing.Size(360, 41);
            this.PathInputTextBox.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("ГОСТ тип А", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(107, 105);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(150, 45);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // OutputLabel
            // 
            this.OutputLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OutputLabel.Font = new System.Drawing.Font("ГОСТ тип А", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OutputLabel.Location = new System.Drawing.Point(14, 162);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(360, 360);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "Вывод";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("ГОСТ тип А", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(73, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Авто коррекция";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(386, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PathInputTextBox);
            this.Controls.Add(this.InstructionLabel);
            this.Name = "MainForm";
            this.Text = "Poisk Russkogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox PathInputTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button button1;
    }
}

