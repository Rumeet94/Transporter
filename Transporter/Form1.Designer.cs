namespace Rumeet94_Transporter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transporter));
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 372);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 29);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 372);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 29);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnAddDiir
            // 
            this.btnAddDiir.Location = new System.Drawing.Point(485, 34);
            this.btnAddDiir.Name = "btnAddDiir";
            this.btnAddDiir.Size = new System.Drawing.Size(75, 29);
            this.btnAddDiir.TabIndex = 0;
            this.btnAddDiir.Text = "Add";
            this.btnAddDiir.UseVisualStyleBackColor = true;
            this.btnAddDiir.Click += new System.EventHandler(this.BtnAddDiir_Click);
            // 
            // btnAddFormatAndDir
            // 
            this.btnAddFormatAndDir.Location = new System.Drawing.Point(485, 90);
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
            this.tbDir.Size = new System.Drawing.Size(467, 20);
            this.tbDir.TabIndex = 1;
            // 
            // tbFormat
            // 
            this.tbFormat.Location = new System.Drawing.Point(12, 93);
            this.tbFormat.Name = "tbFormat";
            this.tbFormat.Size = new System.Drawing.Size(108, 20);
            this.tbFormat.TabIndex = 1;
            // 
            // tbFormatDir
            // 
            this.tbFormatDir.Location = new System.Drawing.Point(126, 93);
            this.tbFormatDir.Name = "tbFormatDir";
            this.tbFormatDir.Size = new System.Drawing.Size(353, 20);
            this.tbFormatDir.TabIndex = 1;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 141);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.Size = new System.Drawing.Size(548, 225);
            this.tbMessage.TabIndex = 3;
            // 
            // btnClearCon
            // 
            this.btnClearCon.Location = new System.Drawing.Point(242, 372);
            this.btnClearCon.Name = "btnClearCon";
            this.btnClearCon.Size = new System.Drawing.Size(75, 29);
            this.btnClearCon.TabIndex = 4;
            this.btnClearCon.Text = "Clear";
            this.btnClearCon.UseVisualStyleBackColor = true;
            this.btnClearCon.Click += new System.EventHandler(this.BtnClearCon_Click);
            // 
            // btnResPar
            // 
            this.btnResPar.Location = new System.Drawing.Point(404, 372);
            this.btnResPar.Name = "btnResPar";
            this.btnResPar.Size = new System.Drawing.Size(75, 29);
            this.btnResPar.TabIndex = 4;
            this.btnResPar.Text = "Reset";
            this.btnResPar.UseVisualStyleBackColor = true;
            this.btnResPar.Click += new System.EventHandler(this.BtnResPar_Click);
            // 
            // btnViewPar
            // 
            this.btnViewPar.Location = new System.Drawing.Point(323, 372);
            this.btnViewPar.Name = "btnViewPar";
            this.btnViewPar.Size = new System.Drawing.Size(75, 29);
            this.btnViewPar.TabIndex = 4;
            this.btnViewPar.Text = "View";
            this.btnViewPar.UseVisualStyleBackColor = true;
            this.btnViewPar.Click += new System.EventHandler(this.BtnViewPar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исходный каталог";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Формат файла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Каталог для переноса файлов данного формата";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(485, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Transporter";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClicks);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClicks);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStart,
            this.toolStripMenuItemStop});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(99, 48);
            // 
            // toolStripMenuItemStart
            // 
            this.toolStripMenuItemStart.Name = "toolStripMenuItemStart";
            this.toolStripMenuItemStart.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItemStart.Text = "Start";
            this.toolStripMenuItemStart.Click += new System.EventHandler(this.ToolStripMenuItemStart_Click);
            // 
            // toolStripMenuItemStop
            // 
            this.toolStripMenuItemStop.Name = "toolStripMenuItemStop";
            this.toolStripMenuItemStop.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItemStop.Text = "Stop";
            this.toolStripMenuItemStop.Click += new System.EventHandler(this.ToolStripMenuItemStop_Click);
            // 
            // Transporter
            // 
            this.ClientSize = new System.Drawing.Size(574, 415);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(590, 454);
            this.MinimumSize = new System.Drawing.Size(590, 454);
            this.Name = "Transporter";
            this.Text = "Transporter";
            this.contextMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStop;
    }
}

