﻿namespace KamiModpackBuilder.UserControls
{
    partial class CharacterMods
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxCharacters = new System.Windows.Forms.ComboBox();
            this.buttonTextureIDFixAll = new System.Windows.Forms.Button();
            this.buttonCheckErrors = new System.Windows.Forms.Button();
            this.buttonImportSlotMod = new System.Windows.Forms.Button();
            this.buttonImportGeneralMod = new System.Windows.Forms.Button();
            this.buttonDeleteMod = new System.Windows.Forms.Button();
            this.buttonModProperties = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanelGeneralButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGeneralDown = new System.Windows.Forms.Button();
            this.buttonGeneralLeft = new System.Windows.Forms.Button();
            this.buttonGeneralRight = new System.Windows.Forms.Button();
            this.buttonGeneralUp = new System.Windows.Forms.Button();
            this.tableLayoutPanelSlotButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSlotBottom = new System.Windows.Forms.Button();
            this.buttonSlotDown = new System.Windows.Forms.Button();
            this.buttonSlotLeft = new System.Windows.Forms.Button();
            this.buttonSlotRight = new System.Windows.Forms.Button();
            this.buttonSlotUp = new System.Windows.Forms.Button();
            this.openFileDialogImportZip = new System.Windows.Forms.OpenFileDialog();
            this.helpButtons = new System.Windows.Forms.PictureBox();
            this.helpSlotMods = new System.Windows.Forms.PictureBox();
            this.helpGeneralMods = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelGeneralButtons.SuspendLayout();
            this.tableLayoutPanelSlotButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpSlotMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpGeneralMods)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 24);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.comboBoxCharacters);
            this.flowLayoutPanel1.Controls.Add(this.buttonTextureIDFixAll);
            this.flowLayoutPanel1.Controls.Add(this.buttonCheckErrors);
            this.flowLayoutPanel1.Controls.Add(this.buttonImportSlotMod);
            this.flowLayoutPanel1.Controls.Add(this.buttonImportGeneralMod);
            this.flowLayoutPanel1.Controls.Add(this.buttonDeleteMod);
            this.flowLayoutPanel1.Controls.Add(this.buttonModProperties);
            this.flowLayoutPanel1.Controls.Add(this.helpButtons);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(931, 24);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // comboBoxCharacters
            // 
            this.comboBoxCharacters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCharacters.FormattingEnabled = true;
            this.comboBoxCharacters.Location = new System.Drawing.Point(2, 2);
            this.comboBoxCharacters.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCharacters.Name = "comboBoxCharacters";
            this.comboBoxCharacters.Size = new System.Drawing.Size(124, 21);
            this.comboBoxCharacters.TabIndex = 1;
            this.comboBoxCharacters.SelectedIndexChanged += new System.EventHandler(this.comboBoxCharacters_SelectedIndexChanged);
            // 
            // buttonTextureIDFixAll
            // 
            this.buttonTextureIDFixAll.Location = new System.Drawing.Point(130, 2);
            this.buttonTextureIDFixAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTextureIDFixAll.Name = "buttonTextureIDFixAll";
            this.buttonTextureIDFixAll.Size = new System.Drawing.Size(116, 23);
            this.buttonTextureIDFixAll.TabIndex = 3;
            this.buttonTextureIDFixAll.Text = "TextureID Fix Slots";
            this.buttonTextureIDFixAll.Click += new System.EventHandler(this.buttonTextureIDFixAll_Click);
            // 
            // buttonCheckErrors
            // 
            this.buttonCheckErrors.Location = new System.Drawing.Point(250, 2);
            this.buttonCheckErrors.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCheckErrors.Name = "buttonCheckErrors";
            this.buttonCheckErrors.Size = new System.Drawing.Size(124, 23);
            this.buttonCheckErrors.TabIndex = 9;
            this.buttonCheckErrors.Text = "Check Mods for Errors";
            this.buttonCheckErrors.Click += new System.EventHandler(this.buttonCheckErrors_Click);
            // 
            // buttonImportSlotMod
            // 
            this.buttonImportSlotMod.Location = new System.Drawing.Point(378, 2);
            this.buttonImportSlotMod.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImportSlotMod.Name = "buttonImportSlotMod";
            this.buttonImportSlotMod.Size = new System.Drawing.Size(105, 23);
            this.buttonImportSlotMod.TabIndex = 6;
            this.buttonImportSlotMod.Text = "Import Slot Mod";
            this.buttonImportSlotMod.Click += new System.EventHandler(this.buttonImportSlotMod_Click);
            // 
            // buttonImportGeneralMod
            // 
            this.buttonImportGeneralMod.Location = new System.Drawing.Point(487, 2);
            this.buttonImportGeneralMod.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImportGeneralMod.Name = "buttonImportGeneralMod";
            this.buttonImportGeneralMod.Size = new System.Drawing.Size(121, 23);
            this.buttonImportGeneralMod.TabIndex = 7;
            this.buttonImportGeneralMod.Text = "Import General Mod";
            this.buttonImportGeneralMod.Click += new System.EventHandler(this.buttonImportGeneralMod_Click);
            // 
            // buttonDeleteMod
            // 
            this.buttonDeleteMod.Location = new System.Drawing.Point(612, 2);
            this.buttonDeleteMod.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteMod.Name = "buttonDeleteMod";
            this.buttonDeleteMod.Size = new System.Drawing.Size(80, 23);
            this.buttonDeleteMod.TabIndex = 8;
            this.buttonDeleteMod.Text = "Delete Mod";
            this.buttonDeleteMod.Click += new System.EventHandler(this.buttonDeleteMod_Click);
            // 
            // buttonModProperties
            // 
            this.buttonModProperties.Location = new System.Drawing.Point(696, 2);
            this.buttonModProperties.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModProperties.Name = "buttonModProperties";
            this.buttonModProperties.Size = new System.Drawing.Size(80, 23);
            this.buttonModProperties.TabIndex = 10;
            this.buttonModProperties.Text = "Properties";
            this.buttonModProperties.Click += new System.EventHandler(this.buttonModProperties_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 714);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelGeneralButtons, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelSlotButtons, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.helpSlotMods, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.helpGeneralMods, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(931, 714);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active Slot Mods";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inactive Slot Mods";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 440);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Active General Character Mods";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 440);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inactive General Character Mods";
            // 
            // tableLayoutPanelGeneralButtons
            // 
            this.tableLayoutPanelGeneralButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelGeneralButtons.ColumnCount = 1;
            this.tableLayoutPanelGeneralButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGeneralButtons.Controls.Add(this.buttonGeneralDown, 0, 3);
            this.tableLayoutPanelGeneralButtons.Controls.Add(this.buttonGeneralLeft, 0, 0);
            this.tableLayoutPanelGeneralButtons.Controls.Add(this.buttonGeneralRight, 0, 1);
            this.tableLayoutPanelGeneralButtons.Controls.Add(this.buttonGeneralUp, 0, 2);
            this.tableLayoutPanelGeneralButtons.Location = new System.Drawing.Point(451, 531);
            this.tableLayoutPanelGeneralButtons.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelGeneralButtons.Name = "tableLayoutPanelGeneralButtons";
            this.tableLayoutPanelGeneralButtons.RowCount = 4;
            this.tableLayoutPanelGeneralButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelGeneralButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelGeneralButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelGeneralButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelGeneralButtons.Size = new System.Drawing.Size(29, 104);
            this.tableLayoutPanelGeneralButtons.TabIndex = 8;
            // 
            // buttonGeneralDown
            // 
            this.buttonGeneralDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGeneralDown.Enabled = false;
            this.buttonGeneralDown.Location = new System.Drawing.Point(0, 80);
            this.buttonGeneralDown.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonGeneralDown.Name = "buttonGeneralDown";
            this.buttonGeneralDown.Size = new System.Drawing.Size(29, 22);
            this.buttonGeneralDown.TabIndex = 7;
            this.buttonGeneralDown.Text = "↓";
            this.buttonGeneralDown.UseVisualStyleBackColor = true;
            this.buttonGeneralDown.Click += new System.EventHandler(this.buttonGeneralDown_Click);
            // 
            // buttonGeneralLeft
            // 
            this.buttonGeneralLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGeneralLeft.Enabled = false;
            this.buttonGeneralLeft.Location = new System.Drawing.Point(0, 2);
            this.buttonGeneralLeft.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonGeneralLeft.Name = "buttonGeneralLeft";
            this.buttonGeneralLeft.Size = new System.Drawing.Size(29, 22);
            this.buttonGeneralLeft.TabIndex = 6;
            this.buttonGeneralLeft.Text = "←";
            this.buttonGeneralLeft.UseVisualStyleBackColor = true;
            this.buttonGeneralLeft.Click += new System.EventHandler(this.buttonGeneralLeft_Click);
            // 
            // buttonGeneralRight
            // 
            this.buttonGeneralRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGeneralRight.Enabled = false;
            this.buttonGeneralRight.Location = new System.Drawing.Point(0, 28);
            this.buttonGeneralRight.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonGeneralRight.Name = "buttonGeneralRight";
            this.buttonGeneralRight.Size = new System.Drawing.Size(29, 22);
            this.buttonGeneralRight.TabIndex = 5;
            this.buttonGeneralRight.Text = "→";
            this.buttonGeneralRight.UseVisualStyleBackColor = true;
            this.buttonGeneralRight.Click += new System.EventHandler(this.buttonGeneralRight_Click);
            // 
            // buttonGeneralUp
            // 
            this.buttonGeneralUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGeneralUp.Enabled = false;
            this.buttonGeneralUp.Location = new System.Drawing.Point(0, 54);
            this.buttonGeneralUp.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonGeneralUp.Name = "buttonGeneralUp";
            this.buttonGeneralUp.Size = new System.Drawing.Size(29, 22);
            this.buttonGeneralUp.TabIndex = 4;
            this.buttonGeneralUp.Text = "↑";
            this.buttonGeneralUp.UseVisualStyleBackColor = true;
            this.buttonGeneralUp.Click += new System.EventHandler(this.buttonGeneralUp_Click);
            // 
            // tableLayoutPanelSlotButtons
            // 
            this.tableLayoutPanelSlotButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelSlotButtons.ColumnCount = 1;
            this.tableLayoutPanelSlotButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSlotButtons.Controls.Add(this.buttonSlotBottom, 0, 4);
            this.tableLayoutPanelSlotButtons.Controls.Add(this.buttonSlotDown, 0, 3);
            this.tableLayoutPanelSlotButtons.Controls.Add(this.buttonSlotLeft, 0, 0);
            this.tableLayoutPanelSlotButtons.Controls.Add(this.buttonSlotRight, 0, 1);
            this.tableLayoutPanelSlotButtons.Controls.Add(this.buttonSlotUp, 0, 2);
            this.tableLayoutPanelSlotButtons.Location = new System.Drawing.Point(451, 161);
            this.tableLayoutPanelSlotButtons.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelSlotButtons.Name = "tableLayoutPanelSlotButtons";
            this.tableLayoutPanelSlotButtons.RowCount = 5;
            this.tableLayoutPanelSlotButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSlotButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSlotButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSlotButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSlotButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSlotButtons.Size = new System.Drawing.Size(29, 130);
            this.tableLayoutPanelSlotButtons.TabIndex = 9;
            // 
            // buttonSlotBottom
            // 
            this.buttonSlotBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSlotBottom.Enabled = false;
            this.buttonSlotBottom.Location = new System.Drawing.Point(0, 106);
            this.buttonSlotBottom.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonSlotBottom.Name = "buttonSlotBottom";
            this.buttonSlotBottom.Size = new System.Drawing.Size(29, 22);
            this.buttonSlotBottom.TabIndex = 8;
            this.buttonSlotBottom.Text = "↓↓";
            this.buttonSlotBottom.UseVisualStyleBackColor = true;
            this.buttonSlotBottom.Click += new System.EventHandler(this.buttonSlotBottom_Click);
            // 
            // buttonSlotDown
            // 
            this.buttonSlotDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSlotDown.Enabled = false;
            this.buttonSlotDown.Location = new System.Drawing.Point(0, 80);
            this.buttonSlotDown.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonSlotDown.Name = "buttonSlotDown";
            this.buttonSlotDown.Size = new System.Drawing.Size(29, 22);
            this.buttonSlotDown.TabIndex = 7;
            this.buttonSlotDown.Text = "↓";
            this.buttonSlotDown.UseVisualStyleBackColor = true;
            this.buttonSlotDown.Click += new System.EventHandler(this.buttonSlotDown_Click);
            // 
            // buttonSlotLeft
            // 
            this.buttonSlotLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSlotLeft.Enabled = false;
            this.buttonSlotLeft.Location = new System.Drawing.Point(0, 2);
            this.buttonSlotLeft.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonSlotLeft.Name = "buttonSlotLeft";
            this.buttonSlotLeft.Size = new System.Drawing.Size(29, 22);
            this.buttonSlotLeft.TabIndex = 6;
            this.buttonSlotLeft.Text = "←";
            this.buttonSlotLeft.UseVisualStyleBackColor = true;
            this.buttonSlotLeft.Click += new System.EventHandler(this.buttonSlotLeft_Click);
            // 
            // buttonSlotRight
            // 
            this.buttonSlotRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSlotRight.Enabled = false;
            this.buttonSlotRight.Location = new System.Drawing.Point(0, 28);
            this.buttonSlotRight.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonSlotRight.Name = "buttonSlotRight";
            this.buttonSlotRight.Size = new System.Drawing.Size(29, 22);
            this.buttonSlotRight.TabIndex = 5;
            this.buttonSlotRight.Text = "→";
            this.buttonSlotRight.UseVisualStyleBackColor = true;
            this.buttonSlotRight.Click += new System.EventHandler(this.buttonSlotRight_Click);
            // 
            // buttonSlotUp
            // 
            this.buttonSlotUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSlotUp.Enabled = false;
            this.buttonSlotUp.Location = new System.Drawing.Point(0, 54);
            this.buttonSlotUp.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonSlotUp.Name = "buttonSlotUp";
            this.buttonSlotUp.Size = new System.Drawing.Size(29, 22);
            this.buttonSlotUp.TabIndex = 4;
            this.buttonSlotUp.Text = "↑";
            this.buttonSlotUp.UseVisualStyleBackColor = true;
            this.buttonSlotUp.Click += new System.EventHandler(this.buttonSlotUp_Click);
            // 
            // openFileDialogImportZip
            // 
            this.openFileDialogImportZip.Filter = "Zip file|*.zip|RAR Archive|*.rar|7 Zip Archive|*.7z";
            // 
            // helpButtons
            // 
            this.helpButtons.Image = global::KamiModpackBuilder.Properties.Resources.icon_help;
            this.helpButtons.Location = new System.Drawing.Point(781, 3);
            this.helpButtons.Name = "helpButtons";
            this.helpButtons.Size = new System.Drawing.Size(16, 16);
            this.helpButtons.TabIndex = 34;
            this.helpButtons.TabStop = false;
            this.helpButtons.Click += new System.EventHandler(this.help_Click);
            // 
            // helpSlotMods
            // 
            this.helpSlotMods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpSlotMods.Image = global::KamiModpackBuilder.Properties.Resources.icon_help;
            this.helpSlotMods.Location = new System.Drawing.Point(457, 3);
            this.helpSlotMods.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.helpSlotMods.Name = "helpSlotMods";
            this.helpSlotMods.Size = new System.Drawing.Size(16, 16);
            this.helpSlotMods.TabIndex = 35;
            this.helpSlotMods.TabStop = false;
            this.helpSlotMods.Click += new System.EventHandler(this.help_Click);
            // 
            // helpGeneralMods
            // 
            this.helpGeneralMods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpGeneralMods.Image = global::KamiModpackBuilder.Properties.Resources.icon_help;
            this.helpGeneralMods.Location = new System.Drawing.Point(457, 437);
            this.helpGeneralMods.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.helpGeneralMods.Name = "helpGeneralMods";
            this.helpGeneralMods.Size = new System.Drawing.Size(16, 16);
            this.helpGeneralMods.TabIndex = 36;
            this.helpGeneralMods.TabStop = false;
            this.helpGeneralMods.Click += new System.EventHandler(this.help_Click);
            // 
            // CharacterMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CharacterMods";
            this.Size = new System.Drawing.Size(931, 738);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelGeneralButtons.ResumeLayout(false);
            this.tableLayoutPanelSlotButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.helpButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpSlotMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpGeneralMods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxCharacters;
        private System.Windows.Forms.Button buttonTextureIDFixAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGeneralButtons;
        private System.Windows.Forms.Button buttonGeneralDown;
        private System.Windows.Forms.Button buttonGeneralLeft;
        private System.Windows.Forms.Button buttonGeneralRight;
        private System.Windows.Forms.Button buttonGeneralUp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSlotButtons;
        private System.Windows.Forms.Button buttonSlotDown;
        private System.Windows.Forms.Button buttonSlotLeft;
        private System.Windows.Forms.Button buttonSlotRight;
        private System.Windows.Forms.Button buttonSlotUp;
        private System.Windows.Forms.Button buttonSlotBottom;
        private System.Windows.Forms.Button buttonImportSlotMod;
        private System.Windows.Forms.Button buttonImportGeneralMod;
        private System.Windows.Forms.OpenFileDialog openFileDialogImportZip;
        private System.Windows.Forms.Button buttonDeleteMod;
        private System.Windows.Forms.Button buttonCheckErrors;
        private System.Windows.Forms.Button buttonModProperties;
        private System.Windows.Forms.PictureBox helpButtons;
        private System.Windows.Forms.PictureBox helpSlotMods;
        private System.Windows.Forms.PictureBox helpGeneralMods;
    }
}
