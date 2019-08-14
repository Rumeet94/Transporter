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
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnClearCon = new System.Windows.Forms.Button();
            this.btnResPar = new System.Windows.Forms.Button();
            this.btnViewPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 372);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 29);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(96, 372);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 29);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnAddDiir
            // 
            this.btnAddDiir.Location = new System.Drawing.Point(428, 32);
            this.btnAddDiir.Name = "btnAddDiir";
            this.btnAddDiir.Size = new System.Drawing.Size(75, 29);
            this.btnAddDiir.TabIndex = 0;
            this.btnAddDiir.Text = "Add";
            this.btnAddDiir.UseVisualStyleBackColor = true;
            this.btnAddDiir.Click += new System.EventHandler(this.BtnAddDiir_Click);
            // 
            // btnAddFormatAndDir
            // 
            this.btnAddFormatAndDir.Location = new System.Drawing.Point(428, 88);
            this.btnAddFormatAndDir.Name = "btnAddFormatAndDir";
            this.btnAddFormatAndDir.Size = new System.Drawing.Size(75, 29);
            this.btnAddFormatAndDir.TabIndex = 0;
            this.btnAddFormatAndDir.Text = "Add";
            this.btnAddFormatAndDir.UseVisualStyleBackColor = true;
            this.btnAddFormatAndDir.Click += new System.EventHandler(this.BtnAddFormatAndDir_Click);
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(12, 37);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(391, 20);
            this.tbDir.TabIndex = 1;
            this.tbDir.TextChanged += new System.EventHandler(this.TbDir_TextChanged);
            // 
            // tbFormat
            // 
            this.tbFormat.Location = new System.Drawing.Point(12, 93);
            this.tbFormat.Name = "tbFormat";
            this.tbFormat.Size = new System.Drawing.Size(75, 20);
            this.tbFormat.TabIndex = 1;
            // 
            // tbFormatDir
            // 
            this.tbFormatDir.Location = new System.Drawing.Point(109, 93);
            this.tbFormatDir.Name = "tbFormatDir";
            this.tbFormatDir.Size = new System.Drawing.Size(294, 20);
            this.tbFormatDir.TabIndex = 1;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 141);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.Size = new System.Drawing.Size(491, 225);
            this.tbMessage.TabIndex = 3;
            // 
            // btnClearCon
            // 
            this.btnClearCon.Location = new System.Drawing.Point(403, 372);
            this.btnClearCon.Name = "btnClearCon";
            this.btnClearCon.Size = new System.Drawing.Size(96, 29);
            this.btnClearCon.TabIndex = 4;
            this.btnClearCon.Text = "Clear console";
            this.btnClearCon.UseVisualStyleBackColor = true;
            // 
            // btnResPar
            // 
            this.btnResPar.Location = new System.Drawing.Point(290, 372);
            this.btnResPar.Name = "btnResPar";
            this.btnResPar.Size = new System.Drawing.Size(107, 29);
            this.btnResPar.TabIndex = 4;
            this.btnResPar.Text = "Reset parameters";
            this.btnResPar.UseVisualStyleBackColor = true;
            // 
            // btnViewPar
            // 
            this.btnViewPar.Location = new System.Drawing.Point(177, 372);
            this.btnViewPar.Name = "btnViewPar";
            this.btnViewPar.Size = new System.Drawing.Size(107, 29);
            this.btnViewPar.TabIndex = 4;
            this.btnViewPar.Text = "View parameters";
            this.btnViewPar.UseVisualStyleBackColor = true;
            this.btnViewPar.Click += new System.EventHandler(this.BtnViewPar_Click);
            // 
            // Transporter
            // 
            this.ClientSize = new System.Drawing.Size(515, 407);
            this.Controls.Add(this.btnViewPar);
            this.Controls.Add(this.btnResPar);
            this.Controls.Add(this.btnClearCon);
            this.Controls.Add(this.tbMessage);
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
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btnClearCon;
        private System.Windows.Forms.Button btnResPar;
        private System.Windows.Forms.Button btnViewPar;
    }
}

