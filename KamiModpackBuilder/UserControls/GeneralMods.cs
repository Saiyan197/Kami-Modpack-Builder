﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KamiModpackBuilder.UserControls
{
    public partial class GeneralMods : UserControl
    {
        private SmashProjectManager _SmashProjectManager;
        private DataGridModsList _GridMods;
        private DataGridModsList _GridModsInactive;

        private bool _IsInitialized = false;
        private ModRow SelectedMod = null;

        public GeneralMods(SmashProjectManager a_smashProjectManager)
        {
            InitializeComponent();

            _SmashProjectManager = a_smashProjectManager;
            CreateDataGrids();
        }

        private void CreateDataGrids()
        {
            _GridMods = new DataGridModsList(_SmashProjectManager, true, DataGridModsList.ModListType.General);
            _GridMods.Dock = DockStyle.Fill;

            _GridModsInactive = new DataGridModsList(_SmashProjectManager, false, DataGridModsList.ModListType.General);
            _GridModsInactive.Dock = DockStyle.Fill;

            tableLayoutPanel1.Controls.Add(_GridMods, 0, 1);
            tableLayoutPanel1.Controls.Add(_GridModsInactive, 2, 1);
        }
    }
}
