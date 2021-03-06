﻿namespace KamiModpackBuilder.Forms
{
    partial class ImportFolderOrZip
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelInstuctions = new System.Windows.Forms.Label();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonZip = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose whether the mod you are importing is in a regular folder, or in a Zip File" +
    ".";
            // 
            // labelInstuctions
            // 
            this.labelInstuctions.AutoSize = true;
            this.labelInstuctions.Location = new System.Drawing.Point(20, 68);
            this.labelInstuctions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInstuctions.Name = "labelInstuctions";
            this.labelInstuctions.Size = new System.Drawing.Size(142, 20);
            this.labelInstuctions.TabIndex = 1;
            this.labelInstuctions.Text = "Import Instructions";
            // 
            // buttonFolder
            // 
            this.buttonFolder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFolder.Location = new System.Drawing.Point(140, 206);
            this.buttonFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(112, 35);
            this.buttonFolder.TabIndex = 2;
            this.buttonFolder.Text = "Folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // buttonZip
            // 
            this.buttonZip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonZip.Location = new System.Drawing.Point(321, 206);
            this.buttonZip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonZip.Name = "buttonZip";
            this.buttonZip.Size = new System.Drawing.Size(112, 35);
            this.buttonZip.TabIndex = 3;
            this.buttonZip.Text = "ZIP File";
            this.buttonZip.UseVisualStyleBackColor = true;
            this.buttonZip.Click += new System.EventHandler(this.buttonZip_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "You can also import by dragging and dropping a folder/zip into the Inactive\r\nMod " +
    "List.";
            // 
            // ImportFolderOrZip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonZip);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.labelInstuctions);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImportFolderOrZip";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import New Mod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInstuctions;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button buttonZip;
        private System.Windows.Forms.Label label2;
    }
}