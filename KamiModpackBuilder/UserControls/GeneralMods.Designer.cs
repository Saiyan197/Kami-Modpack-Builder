﻿namespace KamiModpackBuilder.UserControls
{
    partial class GeneralMods
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelSlotButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonImportMod = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelSlotButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelSlotButtons, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(561, 298);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active General Mods";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inactive General Mods";
            // 
            // tableLayoutPanelSlotButtons
            // 
            this.tableLayoutPanelSlotButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelSlotButtons.ColumnCount = 1;
            this.tableLayoutPanelSlotButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSlotButtons.Controls.Add(this.buttonDown, 0, 3);
            this.tableLayoutPanelSlotButtons.Controls.Add(this.buttonLeft, 0, 0);
            this.tableLayoutPanelSlotButtons.Controls.Add(this.buttonRight, 0, 1);
            this.tableLayoutPanelSlotButtons.Controls.Add(this.buttonUp, 0, 2);
            this.tableLayoutPanelSlotButtons.Location = new System.Drawing.Point(266, 98);
            this.tableLayoutPanelSlotButtons.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelSlotButtons.Name = "tableLayoutPanelSlotButtons";
            this.tableLayoutPanelSlotButtons.RowCount = 4;
            this.tableLayoutPanelSlotButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSlotButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSlotButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSlotButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSlotButtons.Size = new System.Drawing.Size(29, 120);
            this.tableLayoutPanelSlotButtons.TabIndex = 10;
            // 
            // buttonDown
            // 
            this.buttonDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDown.Enabled = false;
            this.buttonDown.Location = new System.Drawing.Point(0, 92);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(29, 26);
            this.buttonDown.TabIndex = 7;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLeft.Enabled = false;
            this.buttonLeft.Location = new System.Drawing.Point(0, 2);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(29, 26);
            this.buttonLeft.TabIndex = 6;
            this.buttonLeft.Text = "←";
            this.buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            this.buttonRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRight.Enabled = false;
            this.buttonRight.Location = new System.Drawing.Point(0, 32);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(29, 26);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.Text = "→";
            this.buttonRight.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            this.buttonUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUp.Enabled = false;
            this.buttonUp.Location = new System.Drawing.Point(0, 62);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(29, 26);
            this.buttonUp.TabIndex = 4;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.buttonImportMod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 24);
            this.panel1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(178, 1);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(96, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Error Checking";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonImportMod
            // 
            this.buttonImportMod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonImportMod.Location = new System.Drawing.Point(278, 1);
            this.buttonImportMod.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImportMod.Name = "buttonImportMod";
            this.buttonImportMod.Size = new System.Drawing.Size(119, 23);
            this.buttonImportMod.TabIndex = 8;
            this.buttonImportMod.Text = "Import General Mod";
            this.buttonImportMod.UseVisualStyleBackColor = true;
            // 
            // GeneralMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "GeneralMods";
            this.Size = new System.Drawing.Size(561, 322);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelSlotButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSlotButtons;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonImportMod;
    }
}
