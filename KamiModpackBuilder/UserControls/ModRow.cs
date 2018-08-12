﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KamiModpackBuilder.Objects;
using System.IO;
using ZLibNet;
using KamiModpackBuilder.Globals;
using KamiModpackBuilder.Properties;

namespace KamiModpackBuilder.UserControls
{
    public partial class ModRow : UserControl
    {
        #region Members
        private bool _IsActiveList = false;
        private DataGridModsList.ModListType _ModListType = DataGridModsList.ModListType.General;
        private SmashProjectManager _SmashProjectManager;
        private DB.Fighter _CurrentFighter;
        #endregion

        #region Properties
        public int slotNum = 0;
        public string name = "";
        public int textureID = -1;
        public string warningText = "";
        public bool hasWarning = false;
        public string errorText = "";
        public bool hasError = false;
        public string modFolder = "";
        #endregion

        #region Constructors
        public ModRow(SmashProjectManager a_smashProjectManager, bool a_isActiveList, DataGridModsList.ModListType a_modListType)
        {
            InitializeComponent();

            _SmashProjectManager = a_smashProjectManager;
            _IsActiveList = a_isActiveList;
            _ModListType = a_modListType;
        }
        #endregion

        #region Public Methods
        public void ChangeSelectedFighter(DB.Fighter a_fighter)
        {
            _CurrentFighter = a_fighter;
        }

        public void UpdateData(DataGridModsList.RowData rowData)
        {
            name = rowData.name;
            textureID = rowData.textureID;
            warningText = rowData.warningText;
            hasWarning = rowData.hasWarning;
            errorText = rowData.errorText;
            hasError = rowData.hasError;
            modFolder = rowData.modFolder;
            UpdateData();
        }

        public void UpdateData(DataGridSlotModList.SlotRowData rowData)
        {
            slotNum = rowData.slotNum;
            name = rowData.name;
            textureID = rowData.textureID;
            warningText = rowData.warningText;
            hasWarning = rowData.hasWarning;
            errorText = rowData.errorText;
            hasError = rowData.hasError;
            modFolder = rowData.modFolder;
            UpdateData();
        }

        public void UpdateData()
        {
            if (_IsActiveList && _ModListType == DataGridModsList.ModListType.CharacterSlots)
            {
                labelSlotNumber.Text = slotNum.ToString();
            }
            labelModName.Text = name;
            if (hasError)
            {
                buttonError.Visible = true;
                buttonError.Image = Resources.icon_error;
            }
            else if (hasWarning)
            {
                buttonError.Visible = true;
                buttonError.Image = Resources.icon_warning;
            }
            else
            {
                buttonError.Visible = false;
            }
        }
        #endregion

        #region Private Methods

        #endregion

        private void panelModList_Click(object sender, EventArgs e)
        {
            panelModList.BackColor = Color.LightBlue;
            //TODO: Make this select the control and deselect the others
        }

        private void labelModName_Click(object sender, EventArgs e)
        {
            panelModList_Click(null, null);
            return;
        }

        private void labelSlotNumber_Click(object sender, EventArgs e)
        {
            panelModList_Click(null, null);
            return;
        }
    }
}
