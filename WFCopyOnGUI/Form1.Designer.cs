﻿
namespace WFCopyOnGUI
{
    partial class Form1
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
            this.BtnCopy = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.sourceLbl = new System.Windows.Forms.Label();
            this.endPointLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtmCtoL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCopy
            // 
            this.BtnCopy.Location = new System.Drawing.Point(12, 126);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(75, 23);
            this.BtnCopy.TabIndex = 0;
            this.BtnCopy.Text = "Copy";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(197, 126);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // sourceLbl
            // 
            this.sourceLbl.AutoSize = true;
            this.sourceLbl.Location = new System.Drawing.Point(12, 9);
            this.sourceLbl.Name = "sourceLbl";
            this.sourceLbl.Size = new System.Drawing.Size(41, 13);
            this.sourceLbl.TabIndex = 2;
            this.sourceLbl.Text = "Source";
            // 
            // endPointLbl
            // 
            this.endPointLbl.AutoSize = true;
            this.endPointLbl.Location = new System.Drawing.Point(219, 9);
            this.endPointLbl.Name = "endPointLbl";
            this.endPointLbl.Size = new System.Drawing.Size(53, 13);
            this.endPointLbl.TabIndex = 3;
            this.endPointLbl.Text = "End Point";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3 ",
            "Item 4",
            "Item 5"});
            this.comboBox1.Location = new System.Drawing.Point(12, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "List Item1",
            "List Item 2",
            "List Item 3 ",
            "List Item 4",
            "List Item 5"});
            this.listBox1.Location = new System.Drawing.Point(164, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(108, 95);
            this.listBox1.TabIndex = 5;
            // 
            // BtmCtoL
            // 
            this.BtmCtoL.Location = new System.Drawing.Point(105, 126);
            this.BtmCtoL.Name = "BtmCtoL";
            this.BtmCtoL.Size = new System.Drawing.Size(75, 23);
            this.BtmCtoL.TabIndex = 6;
            this.BtmCtoL.Text = "C to L";
            this.BtmCtoL.UseVisualStyleBackColor = true;
            this.BtmCtoL.Click += new System.EventHandler(this.BtnCtoL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.BtmCtoL);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.endPointLbl);
            this.Controls.Add(this.sourceLbl);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnCopy);
            this.Name = "Form1";
            this.Text = "CopyOnGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label sourceLbl;
        private System.Windows.Forms.Label endPointLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtmCtoL;
    }
}

