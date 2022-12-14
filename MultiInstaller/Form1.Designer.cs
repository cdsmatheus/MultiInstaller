namespace MultiInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAviso = new System.Windows.Forms.Label();
            this.lstProgramas = new System.Windows.Forms.ListBox();
            this.btnSelInstal = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.Location = new System.Drawing.Point(21, 9);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(0, 29);
            this.lblAviso.TabIndex = 0;
            // 
            // lstProgramas
            // 
            this.lstProgramas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProgramas.FormattingEnabled = true;
            this.lstProgramas.ItemHeight = 23;
            this.lstProgramas.Location = new System.Drawing.Point(14, 74);
            this.lstProgramas.Name = "lstProgramas";
            this.lstProgramas.Size = new System.Drawing.Size(374, 395);
            this.lstProgramas.TabIndex = 1;
            // 
            // btnSelInstal
            // 
            this.btnSelInstal.Location = new System.Drawing.Point(394, 74);
            this.btnSelInstal.Name = "btnSelInstal";
            this.btnSelInstal.Size = new System.Drawing.Size(133, 38);
            this.btnSelInstal.TabIndex = 2;
            this.btnSelInstal.Text = "Escolher...";
            this.btnSelInstal.UseVisualStyleBackColor = true;
            this.btnSelInstal.Click += new System.EventHandler(this.btnSelInstal_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(394, 134);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(133, 36);
            this.btnInstall.TabIndex = 3;
            this.btnInstall.Text = "Instalar";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 502);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.btnSelInstal);
            this.Controls.Add(this.lstProgramas);
            this.Controls.Add(this.lblAviso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 558);
            this.MinimumSize = new System.Drawing.Size(566, 558);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.ListBox lstProgramas;
        private System.Windows.Forms.Button btnSelInstal;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

