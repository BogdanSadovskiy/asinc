namespace asinc
{
    partial class Form1
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
            this.CharGenerator = new System.Windows.Forms.Label();
            this.CopyBigFiles = new System.Windows.Forms.Label();
            this.CopyDirectories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CharGenerator
            // 
            this.CharGenerator.Location = new System.Drawing.Point(325, 101);
            this.CharGenerator.Name = "CharGenerator";
            this.CharGenerator.Size = new System.Drawing.Size(100, 23);
            this.CharGenerator.TabIndex = 0;
            this.CharGenerator.Text = "Char generator";
            this.CharGenerator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CharGenerator.UseMnemonic = false;
            this.CharGenerator.Click += new System.EventHandler(this.CharGenerator_Click);
            // 
            // CopyBigFiles
            // 
            this.CopyBigFiles.Location = new System.Drawing.Point(325, 149);
            this.CopyBigFiles.Name = "CopyBigFiles";
            this.CopyBigFiles.Size = new System.Drawing.Size(100, 23);
            this.CopyBigFiles.TabIndex = 1;
            this.CopyBigFiles.Text = "Copy big files";
            this.CopyBigFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CopyBigFiles.UseMnemonic = false;
            // 
            // CopyDirectories
            // 
            this.CopyDirectories.Location = new System.Drawing.Point(325, 200);
            this.CopyDirectories.Name = "CopyDirectories";
            this.CopyDirectories.Size = new System.Drawing.Size(100, 23);
            this.CopyDirectories.TabIndex = 2;
            this.CopyDirectories.Text = "Copy Directories";
            this.CopyDirectories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CopyDirectories.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CopyDirectories);
            this.Controls.Add(this.CopyBigFiles);
            this.Controls.Add(this.CharGenerator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CharGenerator;
        private System.Windows.Forms.Label CopyBigFiles;
        private System.Windows.Forms.Label CopyDirectories;
    }
}

