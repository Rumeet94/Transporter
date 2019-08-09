namespace Transporter
{
    partial class Transporter
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAddDiir = new System.Windows.Forms.Button();
            this.btnAddFormatAndDir = new System.Windows.Forms.Button();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.tbFormat = new System.Windows.Forms.TextBox();
            this.tbFormatDir = new System.Windows.Forms.TextBox();
            this.lblAddFormAndPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(117, 372);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(259, 372);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnAddDiir
            // 
            this.btnAddDiir.Location = new System.Drawing.Point(403, 30);
            this.btnAddDiir.Name = "btnAddDiir";
            this.btnAddDiir.Size = new System.Drawing.Size(75, 23);
            this.btnAddDiir.TabIndex = 0;
            this.btnAddDiir.Text = "Add";
            this.btnAddDiir.UseVisualStyleBackColor = true;
            this.btnAddDiir.Click += new System.EventHandler(this.BtnAddDiir_Click);
            // 
            // btnAddFormatAndDir
            // 
            this.btnAddFormatAndDir.Location = new System.Drawing.Point(403, 91);
            this.btnAddFormatAndDir.Name = "btnAddFormatAndDir";
            this.btnAddFormatAndDir.Size = new System.Drawing.Size(75, 23);
            this.btnAddFormatAndDir.TabIndex = 0;
            this.btnAddFormatAndDir.Text = "Add";
            this.btnAddFormatAndDir.UseVisualStyleBackColor = true;
            this.btnAddFormatAndDir.Click += new System.EventHandler(this.BtnAddFormatAndDir_Click);
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(34, 32);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(346, 20);
            this.tbDir.TabIndex = 1;
            // 
            // tbFormat
            // 
            this.tbFormat.Location = new System.Drawing.Point(34, 93);
            this.tbFormat.Name = "tbFormat";
            this.tbFormat.Size = new System.Drawing.Size(66, 20);
            this.tbFormat.TabIndex = 1;
            // 
            // tbFormatDir
            // 
            this.tbFormatDir.Location = new System.Drawing.Point(117, 93);
            this.tbFormatDir.Name = "tbFormatDir";
            this.tbFormatDir.Size = new System.Drawing.Size(263, 20);
            this.tbFormatDir.TabIndex = 1;
            // 
            // lblAddFormAndPath
            // 
            this.lblAddFormAndPath.AutoSize = true;
            this.lblAddFormAndPath.Location = new System.Drawing.Point(50, 125);
            this.lblAddFormAndPath.Name = "lblAddFormAndPath";
            this.lblAddFormAndPath.Size = new System.Drawing.Size(13, 13);
            this.lblAddFormAndPath.TabIndex = 2;
            this.lblAddFormAndPath.Text = "1";
            // 
            // Transporter
            // 
            this.ClientSize = new System.Drawing.Size(515, 407);
            this.Controls.Add(this.lblAddFormAndPath);
            this.Controls.Add(this.tbFormatDir);
            this.Controls.Add(this.tbFormat);
            this.Controls.Add(this.tbDir);
            this.Controls.Add(this.btnAddFormatAndDir);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnAddDiir);
            this.Controls.Add(this.btnStart);
            this.Name = "Transporter";
            this.Text = "Transporter";
            this.Load += new System.EventHandler(this.Transporter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAddDiir;
        private System.Windows.Forms.Button btnAddFormatAndDir;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.TextBox tbFormat;
        private System.Windows.Forms.TextBox tbFormatDir;
        private System.Windows.Forms.Label lblAddFormAndPath;
    }
}

