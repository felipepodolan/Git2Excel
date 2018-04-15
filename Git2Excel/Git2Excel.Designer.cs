namespace Git2Excel
{
    partial class Git2Excel
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

        private System.Windows.Forms.FolderBrowserDialog Navegar;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Diretorio = new System.Windows.Forms.Button();
            this.gitinit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Diretorio
            // 
            this.Diretorio.Location = new System.Drawing.Point(13, 13);
            this.Diretorio.Name = "Diretorio";
            this.Diretorio.Size = new System.Drawing.Size(75, 23);
            this.Diretorio.TabIndex = 0;
            this.Diretorio.Text = "Diretório";
            this.Diretorio.UseVisualStyleBackColor = true;
            this.Diretorio.Click += new System.EventHandler(this.button1_Click);
            // 
            // gitinit
            // 
            this.gitinit.Location = new System.Drawing.Point(713, 12);
            this.gitinit.Name = "gitinit";
            this.gitinit.Size = new System.Drawing.Size(75, 23);
            this.gitinit.TabIndex = 1;
            this.gitinit.Text = "Git Init";
            this.gitinit.UseVisualStyleBackColor = true;
            this.gitinit.Click += new System.EventHandler(this.gitinit_Click);
            // 
            // Git2Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gitinit);
            this.Controls.Add(this.Diretorio);
            this.Name = "Git2Excel";
            this.Text = "Git2Excel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Diretorio;
        private System.Windows.Forms.Button gitinit;
    }
}