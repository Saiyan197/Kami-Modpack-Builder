﻿using KamiModpackBuilder.DB;
using KamiModpackBuilder.Sm4shMusic.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KamiModpackBuilder.Sm4shMusic.Forms
{
    public partial class CharacterRotation : Form
    {
        private EnumEntity[] _EnumChars;
        private bool _Loaded;

        public SoundEntry CurrentSoundEntry { get; set; }
        public string FormTitle { get { return this.Text; } set { this.Text = value; } }

        public CharacterRotation()
        {
            InitializeComponent();

            _EnumChars = (EnumEntity[])CharsDB.Chars.Select(c => new EnumEntity() { Value = (int)c.Key, Name = c.Value }).ToArray();

            for (int i = 1; i <= 8; i++)
            {
                ComboBox ddlList = (ComboBox)(this.Controls.Find("ddlChar" + i, true)[0]);
                ddlList.Items.Add(new EnumEntity() { Name = "NULL", Value = -1 });
                ddlList.Items.AddRange(_EnumChars);
            }
        }

        #region Methods
        private void PopulateData(SoundEntry sEntry)
        {
            for (int i = 1; i <= 8; i++)
            {
                ComboBox ddlList = (ComboBox)(this.Controls.Find("ddlChar" + i, true)[0]);
                if (CurrentSoundEntry.AssociatedFightersIDs.Count >= i)
                    ddlList.SelectedItem = _EnumChars.FirstOrDefault(p => p.Value == (int)sEntry.AssociatedFightersIDs[i - 1]);
                else
                    ddlList.SelectedIndex = 0;
            }
        }
        #endregion

        #region Event Handlers
        private void CharacterRotation_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                _Loaded = false;
                PopulateData(CurrentSoundEntry);
                _Loaded = true;
            }
        }

        private void ddlChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_Loaded)
                return;

            CurrentSoundEntry.AssociatedFightersIDs = new List<int>();

            for (int i = 1; i <= 8; i++)
            {
                ComboBox ddlList = (ComboBox)(this.Controls.Find("ddlChar" + i, true)[0]);
                if (ddlList.SelectedItem != null && ((EnumEntity)(ddlList.SelectedItem)).Value != -1)
                    CurrentSoundEntry.AssociatedFightersIDs.Add(((EnumEntity)(ddlList.SelectedItem)).Value);
            }
        }
        #endregion
    }
}
