﻿namespace VirtualHost
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHostname = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnAddToXampp = new System.Windows.Forms.Button();
            this.btnAddToMamp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Location = new System.Drawing.Point(40, 81);
            this.lblHostname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(72, 17);
            this.lblHostname.TabIndex = 0;
            this.lblHostname.Text = "Hostname";
            // 
            // txtHostname
            // 
            this.txtHostname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHostname.Location = new System.Drawing.Point(44, 101);
            this.txtHostname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(467, 22);
            this.txtHostname.TabIndex = 1;
            this.txtHostname.Validating += new System.ComponentModel.CancelEventHandler(this.txtHostname_Validating);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(44, 148);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Copy";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.Enter += new System.EventHandler(this.btnOk_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(40, 16);
            this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(37, 17);
            this.lblPath.TabIndex = 3;
            this.lblPath.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(44, 36);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(467, 22);
            this.txtPath.TabIndex = 4;
            // 
            // btnAddToXampp
            // 
            this.btnAddToXampp.Location = new System.Drawing.Point(168, 148);
            this.btnAddToXampp.Name = "btnAddToXampp";
            this.btnAddToXampp.Size = new System.Drawing.Size(121, 28);
            this.btnAddToXampp.TabIndex = 5;
            this.btnAddToXampp.Text = "Add to XAMPP";
            this.btnAddToXampp.UseVisualStyleBackColor = true;
            this.btnAddToXampp.Click += new System.EventHandler(this.btnAddToXampp_Click);
            // 
            // btnAddToMamp
            // 
            this.btnAddToMamp.Location = new System.Drawing.Point(316, 148);
            this.btnAddToMamp.Name = "btnAddToMamp";
            this.btnAddToMamp.Size = new System.Drawing.Size(130, 28);
            this.btnAddToMamp.TabIndex = 5;
            this.btnAddToMamp.Text = "Add to MAMP";
            this.btnAddToMamp.UseMnemonic = false;
            this.btnAddToMamp.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 214);
            this.Controls.Add(this.btnAddToMamp);
            this.Controls.Add(this.btnAddToXampp);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtHostname);
            this.Controls.Add(this.lblHostname);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Add VirtualHost";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnAddToXampp;
        private System.Windows.Forms.Button btnAddToMamp;
    }
}

