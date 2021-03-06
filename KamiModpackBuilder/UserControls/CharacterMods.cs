﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KamiModpackBuilder.Objects;
using KamiModpackBuilder.Globals;

namespace KamiModpackBuilder.UserControls
{
    public partial class CharacterMods : UserControl
    {

        private SmashProjectManager _SmashProjectManager;
        private SlotModsList _GridSlots;
        private ModsList _GridSlotsInactive;
        private ModsList _GridGeneral;
        private ModsList _GridGeneralInactive;

        private bool _IsInitialized = false;
        private ModRow SelectedSlotMod = null;
        private ModRow SelectedGeneralMod = null;
        private DB.Fighter _CurrentFighter = null;

        private List<CharacterSlotMod> CurrentFighterActiveSlotMods = new List<CharacterSlotMod>();
        private List<CharacterGeneralMod> CurrentFighterActiveGeneralMods = new List<CharacterGeneralMod>();
        public CharacterAudioSlotSelection CurrentFighterAudioSlotSelections = null;

        public DB.Fighter CurrentFighter { get { return _CurrentFighter; } }

        #region Constructors
        public CharacterMods()
        {
            InitializeComponent();

            _SmashProjectManager = SmashProjectManager.instance;

            InitializeCharactersComboBox();
            CreateDataGrids();

            _IsInitialized = true;

            comboBoxCharacters_SelectedIndexChanged(this, null);
            Globals.EventManager.OnCharSlotModSelectionChanged += CharSlotModSelectionChanged;
            Globals.EventManager.OnCharGeneralModSelectionChanged += CharGeneralModSelectionChanged;
        }
        #endregion

        #region Destructor
        ~CharacterMods()
        {
            Globals.EventManager.OnCharSlotModSelectionChanged -= CharSlotModSelectionChanged;
            Globals.EventManager.OnCharGeneralModSelectionChanged -= CharGeneralModSelectionChanged;
        }
        #endregion

        #region Public Methods

        public void RefreshData()
        {
            InitializeCharactersComboBox();
            comboBoxCharacters_SelectedIndexChanged(this, null);
        }

        public void RefreshSlotModsLists()
        {
            _GridSlots.RefreshRowData();
            _GridSlotsInactive.RefreshRowData();
            Globals.EventManager.CharSlotModSelectionChanged(null);
        }

        public void RefreshGeneralModsLists()
        {
            _GridGeneral.RefreshRowData();
            _GridGeneralInactive.RefreshRowData();
            Globals.EventManager.CharGeneralModSelectionChanged(null);
        }

        public void SelectSlotMod(string a_mod)
        {
            _GridSlots.SelectMod(a_mod);
            _GridSlotsInactive.SelectMod(a_mod);
        }

        public void SelectGeneralMod(string a_mod)
        {
            _GridGeneral.SelectMod(a_mod);
            _GridGeneralInactive.SelectMod(a_mod);
        }
        #endregion

        #region Private Methods

        private void InitializeCharactersComboBox()
        {
            int fighterCount = DB.FightersDB.Fighters.Count;
            String[] chars = new String[fighterCount];

            for (int i = 0; i < fighterCount; ++i)
            {
                chars[i] = DB.FightersDB.Fighters[i].nameHuman;
            }

            comboBoxCharacters.DataSource = chars;
        }

        private void CreateDataGrids()
        {
            _GridSlots = new SlotModsList();
            _GridSlots.Dock = DockStyle.Fill;

            _GridSlotsInactive = new ModsList(false, ModsList.ModListType.CharacterSlots);
            _GridSlotsInactive.Dock = DockStyle.Fill;

            _GridGeneral = new ModsList(true, ModsList.ModListType.CharacterGeneral);
            _GridGeneral.Dock = DockStyle.Fill;

            _GridGeneralInactive = new ModsList(false, ModsList.ModListType.CharacterGeneral);
            _GridGeneralInactive.Dock = DockStyle.Fill;

            tableLayoutPanel1.Controls.Add(_GridSlots, 0, 1);
            tableLayoutPanel1.Controls.Add(_GridSlotsInactive, 2, 1);
            tableLayoutPanel1.Controls.Add(_GridGeneral, 0, 3);
            tableLayoutPanel1.Controls.Add(_GridGeneralInactive, 2, 3);

        }

        private void GetCurrentCharacterActiveMods()
        {
            CurrentFighterActiveSlotMods.Clear();
            CurrentFighterActiveGeneralMods.Clear();
            for (int i = 0; i < _SmashProjectManager.CurrentProject.ActiveCharacterSlotMods.Count; ++i) {
                if (_SmashProjectManager.CurrentProject.ActiveCharacterSlotMods[i].CharacterID == _CurrentFighter.id) CurrentFighterActiveSlotMods.Add(_SmashProjectManager.CurrentProject.ActiveCharacterSlotMods[i]);
            }
            for (int i = 0; i < _SmashProjectManager.CurrentProject.ActiveCharacterGeneralMods.Count; ++i)
            {
                if (_SmashProjectManager.CurrentProject.ActiveCharacterGeneralMods[i].CharacterID == _CurrentFighter.id) CurrentFighterActiveGeneralMods.Add(_SmashProjectManager.CurrentProject.ActiveCharacterGeneralMods[i]);
            }
            CurrentFighterAudioSlotSelections = null;
            if (_CurrentFighter.voicePackSlots != DB.Fighter.VoicePackSlots.All || _CurrentFighter.soundPackSlots != DB.Fighter.SoundPackSlots.All)
            {
                for (int i = 0; i < _SmashProjectManager.CurrentProject.CharacterAudioSlotSelections.Count; ++i)
                {
                    if (_SmashProjectManager.CurrentProject.CharacterAudioSlotSelections[i].CharacterID == _CurrentFighter.id)
                    {
                        CurrentFighterAudioSlotSelections = _SmashProjectManager.CurrentProject.CharacterAudioSlotSelections[i];
                        break;
                    }
                }
                if (CurrentFighterAudioSlotSelections == null)
                {
                    CurrentFighterAudioSlotSelections = new CharacterAudioSlotSelection();
                    CurrentFighterAudioSlotSelections.CharacterID = _CurrentFighter.id;
                    _SmashProjectManager.CurrentProject.CharacterAudioSlotSelections.Add(CurrentFighterAudioSlotSelections);
                }
            }
        }

        private int GetAvailableActiveSlot()
        {
            //First, return the 1st additional added slot available if possible.
            int highestModSlot = GetHighestSlotModSlot();
            int maxSlots = _SmashProjectManager.CurrentProject.EnableMoreCustomSlots ? _CurrentFighter.unrestrictedSlots : _CurrentFighter.maxSlots;
            if (highestModSlot < _CurrentFighter.defaultSlots - 1)
            {
                if (_CurrentFighter.defaultSlots < maxSlots) return _CurrentFighter.defaultSlots;
            }
            if (highestModSlot < maxSlots - 1) return highestModSlot + 1;
            //If no additional slots are available, find the highest slot number which still has a default skin.
            int highestDefaultSlotAvailable = _CurrentFighter.defaultSlots - 1;
            while (highestDefaultSlotAvailable > -1)
            {
                bool repeat = false;
                for (int i = 0; i < CurrentFighterActiveSlotMods.Count; ++i)
                {
                    if (CurrentFighterActiveSlotMods[i].SlotID == highestDefaultSlotAvailable)
                    {
                        --highestDefaultSlotAvailable;
                        repeat = true;
                        break;
                    }
                }
                if (repeat) continue;
                return highestDefaultSlotAvailable;
            }
            //If no default slots are available, return -1 as no spots are available.
            return -1;
        }

        private int GetHighestSlotModSlot()
        {
            int highestModSlot = -1;
            for (int i = 0; i < CurrentFighterActiveSlotMods.Count; ++i)
            {
                if (CurrentFighterActiveSlotMods[i].SlotID > highestModSlot) highestModSlot = CurrentFighterActiveSlotMods[i].SlotID;
            }
            return highestModSlot;
        }

        private CharacterSlotMod GetActiveModAtSlot(int slot)
        {
            for (int i = 0; i < CurrentFighterActiveSlotMods.Count; ++i)
            {
                if (CurrentFighterActiveSlotMods[i].SlotID == slot) return CurrentFighterActiveSlotMods[i];
            }
            return null;
        }
        #endregion

        #region Events
        private void comboBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_IsInitialized) return;

            _CurrentFighter = DB.FightersDB.Fighters[comboBoxCharacters.SelectedIndex];
            GetCurrentCharacterActiveMods();
            _GridSlots.ChangeSelectedFighter(_CurrentFighter);
            _GridSlotsInactive.ChangeSelectedFighter(_CurrentFighter);
            _GridGeneral.ChangeSelectedFighter(_CurrentFighter);
            _GridGeneralInactive.ChangeSelectedFighter(_CurrentFighter);
            Globals.EventManager.CharSlotModSelectionChanged(null);
        }

        private void CharSlotModSelectionChanged(ModRow selectedMod)
        {
            SelectedSlotMod = selectedMod;
            if (SelectedSlotMod == null)
            {
                buttonSlotUp.Enabled = false;
                buttonSlotDown.Enabled = false;
                buttonSlotLeft.Enabled = false;
                buttonSlotRight.Enabled = false;
                buttonSlotBottom.Enabled = false;
            }
            else
            {
                CharGeneralModSelectionChanged(null);
                if (!SelectedSlotMod.isActiveList)
                {
                    buttonSlotUp.Enabled = false;
                    buttonSlotDown.Enabled = false;
                    buttonSlotRight.Enabled = false;
                    if (GetAvailableActiveSlot() > -1) buttonSlotLeft.Enabled = true;
                    else buttonSlotLeft.Enabled = false;
                    buttonSlotBottom.Enabled = false;
                }
                else
                {
                    int maxSlots = _SmashProjectManager.CurrentProject.EnableMoreCustomSlots ? _CurrentFighter.unrestrictedSlots : _CurrentFighter.maxSlots;
                    buttonSlotRight.Enabled = true;
                    buttonSlotLeft.Enabled = false;
                    if (SelectedSlotMod.slotNum <= 0) buttonSlotUp.Enabled = false;
                    else buttonSlotUp.Enabled = true;
                    if (SelectedSlotMod.slotNum >= maxSlots - 1 || (SelectedSlotMod.slotNum >= GetHighestSlotModSlot() && SelectedSlotMod.slotNum > _CurrentFighter.defaultSlots - 1)) buttonSlotDown.Enabled = false;
                    else buttonSlotDown.Enabled = true;
                    if ((_CurrentFighter.defaultSlots == maxSlots) || (SelectedSlotMod.slotNum >= _CurrentFighter.defaultSlots) || (GetHighestSlotModSlot() >= maxSlots - 1))
                        buttonSlotBottom.Enabled = false;
                    else buttonSlotBottom.Enabled = true;
                }
            }
        }

        private void CharGeneralModSelectionChanged(ModRow selectedMod)
        {
            SelectedGeneralMod = selectedMod;
            if (SelectedGeneralMod == null)
            {
                buttonGeneralUp.Enabled = false;
                buttonGeneralDown.Enabled = false;
                buttonGeneralLeft.Enabled = false;
                buttonGeneralRight.Enabled = false;
            }
            else
            {
                CharSlotModSelectionChanged(null);
                if (!SelectedGeneralMod.isActiveList)
                {
                    buttonGeneralUp.Enabled = false;
                    buttonGeneralDown.Enabled = false;
                    buttonGeneralRight.Enabled = false;
                    buttonGeneralLeft.Enabled = true;
                }
                else
                {
                    buttonGeneralRight.Enabled = true;
                    buttonGeneralLeft.Enabled = false;
                    for (int i = 0; i < CurrentFighterActiveGeneralMods.Count; ++i) {
                        if (!SelectedGeneralMod.modFolder.Equals(CurrentFighterActiveGeneralMods[i].FolderName)) continue;
                        buttonGeneralUp.Enabled = (i > 0);
                        buttonGeneralDown.Enabled = (i < CurrentFighterActiveGeneralMods.Count - 1);
                        break;
                    }
                }
            }
        }

        private void buttonSlotLeft_Click(object sender, EventArgs e)
        {
            if (SelectedSlotMod == null) return;
            if (SelectedSlotMod.isActiveList) return;

            //Get the slot to place the mod in
            int newSlot = GetAvailableActiveSlot();
            if (newSlot == -1) return;

            CharacterSlotMod newActiveMod = new CharacterSlotMod();
            newActiveMod.CharacterID = _CurrentFighter.id;
            newActiveMod.SlotID = newSlot;
            newActiveMod.FolderName = SelectedSlotMod.modFolder;
            _SmashProjectManager.CurrentProject.ActiveCharacterSlotMods.Add(newActiveMod);
            CurrentFighterActiveSlotMods.Add(newActiveMod);
            RefreshSlotModsLists();
            _GridSlots.SelectMod(newActiveMod.FolderName);
        }

        private void buttonSlotRight_Click(object sender, EventArgs e)
        {
            if (SelectedSlotMod == null) return;
            if (!SelectedSlotMod.isActiveList) return;
            string modFolder = SelectedSlotMod.modFolder;
            int slot = SelectedSlotMod.slotNum;
            for (int i = 0; i < CurrentFighterActiveSlotMods.Count; ++i)
            {
                if (CurrentFighterActiveSlotMods[i].FolderName.Equals(modFolder))
                {
                    _SmashProjectManager.CurrentProject.ActiveCharacterSlotMods.Remove(CurrentFighterActiveSlotMods[i]);
                    CurrentFighterActiveSlotMods.RemoveAt(i);
                    break;
                }
            }
            if (slot > _CurrentFighter.defaultSlots - 1)
            {
                for (int i = 0; i < CurrentFighterActiveSlotMods.Count; ++i)
                {
                    if (CurrentFighterActiveSlotMods[i].SlotID > slot) --CurrentFighterActiveSlotMods[i].SlotID;
                }
            }
            RefreshSlotModsLists();
            _GridSlotsInactive.SelectMod(modFolder);
        }

        private void buttonSlotUp_Click(object sender, EventArgs e)
        {
            if (SelectedSlotMod == null) return;
            if (!SelectedSlotMod.isActiveList) return;
            string modFolder = SelectedSlotMod.modFolder;
            int slot = SelectedSlotMod.slotNum;
            if (slot < 1) return;
            CharacterSlotMod originalSlot = GetActiveModAtSlot(slot);
            CharacterSlotMod newSlot = GetActiveModAtSlot(slot - 1);
            --originalSlot.SlotID;
            if (newSlot != null) ++newSlot.SlotID;
            else if (slot > _CurrentFighter.defaultSlots - 1)
            {
                for (int i = 0; i < CurrentFighterActiveSlotMods.Count; ++i)
                {
                    if (CurrentFighterActiveSlotMods[i].SlotID > slot) --CurrentFighterActiveSlotMods[i].SlotID;
                }
            }

            RefreshSlotModsLists();
            _GridSlots.SelectMod(modFolder);
        }

        private void buttonSlotDown_Click(object sender, EventArgs e)
        {
            if (SelectedSlotMod == null) return;
            if (!SelectedSlotMod.isActiveList) return;
            int maxSlots = _SmashProjectManager.CurrentProject.EnableMoreCustomSlots ? _CurrentFighter.unrestrictedSlots : _CurrentFighter.maxSlots;
            string modFolder = SelectedSlotMod.modFolder;
            int slot = SelectedSlotMod.slotNum;
            if (slot >= maxSlots - 1) return;
            if (slot >= GetHighestSlotModSlot() && slot > _CurrentFighter.defaultSlots - 1) return;

            CharacterSlotMod originalSlot = GetActiveModAtSlot(slot);
            CharacterSlotMod newSlot = GetActiveModAtSlot(slot + 1);
            ++originalSlot.SlotID;
            if (newSlot != null) --newSlot.SlotID;

            RefreshSlotModsLists();
            _GridSlots.SelectMod(modFolder);
        }

        private void buttonSlotBottom_Click(object sender, EventArgs e)
        {
            if (SelectedSlotMod == null) return;
            if (!SelectedSlotMod.isActiveList) return;
            int maxSlots = _SmashProjectManager.CurrentProject.EnableMoreCustomSlots ? _CurrentFighter.unrestrictedSlots : _CurrentFighter.maxSlots;
            if (_CurrentFighter.defaultSlots == maxSlots) return;
            int slot = SelectedSlotMod.slotNum;
            if (slot >= _CurrentFighter.defaultSlots) return;
            int newslot = GetHighestSlotModSlot();
            if (newslot >= maxSlots - 1) return;
            if (newslot < _CurrentFighter.defaultSlots) newslot = _CurrentFighter.defaultSlots;
            else ++newslot;
            CharacterSlotMod originalSlot = GetActiveModAtSlot(slot);
            originalSlot.SlotID = newslot;

            RefreshSlotModsLists();
            _GridSlots.SelectMod(originalSlot.FolderName);
        }

        private void buttonGeneralLeft_Click(object sender, EventArgs e)
        {
            if (SelectedGeneralMod == null) return;
            if (SelectedGeneralMod.isActiveList) return;
            
            CharacterGeneralMod newActiveMod = new CharacterGeneralMod();
            newActiveMod.CharacterID = _CurrentFighter.id;
            newActiveMod.FolderName = SelectedGeneralMod.modFolder;
            _SmashProjectManager.CurrentProject.ActiveCharacterGeneralMods.Add(newActiveMod);
            CurrentFighterActiveGeneralMods.Add(newActiveMod);
            RefreshGeneralModsLists();
            _GridGeneral.SelectMod(newActiveMod.FolderName);
        }

        private void buttonGeneralRight_Click(object sender, EventArgs e)
        {
            if (SelectedGeneralMod == null) return;
            if (!SelectedGeneralMod.isActiveList) return;
            string modFolder = SelectedGeneralMod.modFolder;
            for (int i = 0; i < CurrentFighterActiveGeneralMods.Count; ++i)
            {
                if (CurrentFighterActiveGeneralMods[i].FolderName.Equals(modFolder))
                {
                    _SmashProjectManager.CurrentProject.ActiveCharacterGeneralMods.Remove(CurrentFighterActiveGeneralMods[i]);
                    CurrentFighterActiveGeneralMods.RemoveAt(i);
                    break;
                }
            }
            RefreshGeneralModsLists();
            _GridGeneralInactive.SelectMod(modFolder);
        }

        private void buttonGeneralUp_Click(object sender, EventArgs e)
        {
            if (SelectedGeneralMod == null) return;
            if (!SelectedGeneralMod.isActiveList) return;
            string modFolder = SelectedGeneralMod.modFolder;
            for (int i = 0; i < CurrentFighterActiveGeneralMods.Count; ++i)
            {
                if (!CurrentFighterActiveGeneralMods[i].FolderName.Equals(modFolder)) continue;
                CharacterGeneralMod mod = CurrentFighterActiveGeneralMods[i];
                int index = _SmashProjectManager.CurrentProject.ActiveCharacterGeneralMods.IndexOf(mod);
                _SmashProjectManager.CurrentProject.ActiveCharacterGeneralMods.RemoveAt(index);
                _SmashProjectManager.CurrentProject.ActiveCharacterGeneralMods.Insert(index - 1, mod);
                CurrentFighterActiveGeneralMods.RemoveAt(i);
                CurrentFighterActiveGeneralMods.Insert(i - 1, mod);
                break;
            }
            RefreshGeneralModsLists();
            _GridGeneral.SelectMod(modFolder);
        }

        private void buttonGeneralDown_Click(object sender, EventArgs e)
        {
            if (SelectedGeneralMod == null) return;
            if (!SelectedGeneralMod.isActiveList) return;
            string modFolder = SelectedGeneralMod.modFolder;
            for (int i = 0; i < CurrentFighterActiveGeneralMods.Count; ++i)
            {
                if (!CurrentFighterActiveGeneralMods[i].FolderName.Equals(modFolder)) continue;
                CharacterGeneralMod mod = CurrentFighterActiveGeneralMods[i];
                int index = _SmashProjectManager.CurrentProject.ActiveCharacterGeneralMods.IndexOf(mod);
                _SmashProjectManager.CurrentProject.ActiveCharacterGeneralMods.RemoveAt(index);
                _SmashProjectManager.CurrentProject.ActiveCharacterGeneralMods.Insert(index + 1, mod);
                CurrentFighterActiveGeneralMods.RemoveAt(i);
                CurrentFighterActiveGeneralMods.Insert(i + 1, mod);
                break;
            }
            RefreshGeneralModsLists();
            _GridGeneral.SelectMod(modFolder);
        }

        private void buttonImportSlotMod_Click(object sender, EventArgs e)
        {
            Forms.ImportFolderOrZip popup = new Forms.ImportFolderOrZip();
            popup.textInstuctions = "Mod can contain model data, portrait data, and audio data.";
            popup.ShowDialog();
            String path = String.Empty;
            if (popup.choseZip)
            {
                if (openFileDialogImportZip.ShowDialog() == DialogResult.OK)
                {
                    _GridSlotsInactive.BeginImport(openFileDialogImportZip.FileName);
                }
            }
            else if (popup.choseFolder)
            {
                FolderSelectDialog ofd = new FolderSelectDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _GridSlotsInactive.BeginImport(ofd.SelectedPath);
                }
            }
        }

        private void buttonImportGeneralMod_Click(object sender, EventArgs e)
        {
            Forms.ImportFolderOrZip popup = new Forms.ImportFolderOrZip();
            popup.textInstuctions = "Folder must have at least one of the following folders (Based on the\r\nSm4shExplorer hierarchy in the fighter folder) so Kami Modpack Builder\r\nknows where to place the files: model, sound, motion, effect, script, camera.";
            popup.ShowDialog();
            String path = String.Empty;
            if (popup.choseZip)
            {
                if (openFileDialogImportZip.ShowDialog() == DialogResult.OK)
                {
                    _GridGeneralInactive.BeginImport(openFileDialogImportZip.FileName);
                }
            }
            else if (popup.choseFolder)
            {
                FolderSelectDialog ofd = new FolderSelectDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _GridGeneralInactive.BeginImport(ofd.SelectedPath);
                }
            }
        }

        private void buttonTextureIDFixAll_Click(object sender, EventArgs e)
        {
            Globals.LogHelper.Info(string.Format("Beginning Texture ID Fixing for character: {0}.", _CurrentFighter.nameHuman));

            List<ushort> usedIDs = new List<ushort>();
            foreach (CharacterSlotMod slot in CurrentFighterActiveSlotMods)
            {
                string kamiPath = Globals.PathHelper.GetCharacterSlotModKamiPath(_CurrentFighter.name, slot.FolderName);
                string modPath = Globals.PathHelper.GetCharacterSlotModPath(_CurrentFighter.name, slot.FolderName);
                CharacterSlotModXML xml = Globals.Utils.DeserializeXML<CharacterSlotModXML>(kamiPath);
                ushort currentID = (ushort)xml.TextureID;

                if ((currentID % 4 == 0 && currentID < 128) || usedIDs.Contains(currentID))
                {
                    xml.TextureID = 255;
                    while (usedIDs.Contains((ushort)xml.TextureID))
                    {
                        --xml.TextureID;
                        if (xml.TextureID < 1)
                        {
                            Globals.LogHelper.Error(Globals.UIStrings.TEXTURE_ID_FIX_NO_IDS_AVAILABLE);
                            return;
                        }
                    }
                    
                    TextureIDFix.ChangeTextureID(modPath + "model", _CurrentFighter.id, (ushort)xml.TextureID);
                    Globals.Utils.SerializeXMLToFile(xml, kamiPath);
                    Globals.LogHelper.Info(String.Format("Changed Texture ID of {0} to {1} successfully.", slot.FolderName, xml.TextureID));
                }
                usedIDs.Add((ushort)xml.TextureID);
            }
            Globals.LogHelper.Info(string.Format("Finished Texture ID Fixing for character: {0}.", _CurrentFighter.nameHuman));
        }

        private void buttonCheckErrors_Click(object sender, EventArgs e)
        {
            Globals.LogHelper.Info(string.Format("Beginning Error Checking for character: {0}.", _CurrentFighter.nameHuman));
            
            string baseDirectory = Globals.PathHelper.FolderCharSlotsMods + _CurrentFighter.name + Path.DirectorySeparatorChar;
            string[] kamiFiles = Directory.GetFiles(baseDirectory, "kamimod.xml", SearchOption.AllDirectories);

            for (int i = 0; i < kamiFiles.Length; ++i)
            {
                string modPath = kamiFiles[i].Replace("kamimod.xml", String.Empty);
                TextureIDFix.CheckForErrors(modPath);

                CharacterSlotModXML xml = Globals.Utils.DeserializeXML<CharacterSlotModXML>(kamiFiles[i]);
                if (xml == null)
                {
                    Globals.LogHelper.Error(String.Format("There was a problem opening the xml file of mod {0}.", xml.DisplayName));
                    continue;
                }
                if (xml.UseCustomName)
                {
                    if (string.IsNullOrEmpty(xml.CharacterName)) Globals.LogHelper.Warning(String.Format("Custom Name of mod {0} is empty. Mods which have Use Custom Name enabled must have a Custom Name!", xml.DisplayName));
                    if (string.IsNullOrEmpty(xml.BoxingRingText)) Globals.LogHelper.Warning(String.Format("Boxing Ring Text of mod {0} is empty. Mods which have Use Custom Name enabled must have Boxing Ring Text!", xml.DisplayName));
                }
            }

            Globals.LogHelper.Info(string.Format("Finished Error Checking for character: {0}.", _CurrentFighter.nameHuman));
        }

        private void buttonDeleteMod_Click(object sender, EventArgs e)
        {
            if (SelectedSlotMod != null)
            {
                if (MessageBox.Show(string.Format("Are you sure you want to delete the mod '{0}'?", SelectedSlotMod.name),"Delete Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                if (SelectedSlotMod.isActiveList)
                {
                    string modFolder = SelectedSlotMod.modFolder;
                    int slotNum = SelectedSlotMod.slotNum;
                    for (int i = 0; i < CurrentFighterActiveSlotMods.Count; ++i)
                    {
                        if (CurrentFighterActiveSlotMods[i].FolderName.Equals(modFolder))
                        {
                            _SmashProjectManager.CurrentProject.ActiveCharacterSlotMods.Remove(CurrentFighterActiveSlotMods[i]);
                            CurrentFighterActiveSlotMods.RemoveAt(i);
                            break;
                        }
                    }
                    if (slotNum > _CurrentFighter.defaultSlots - 1)
                    {
                        for (int i = 0; i < CurrentFighterActiveSlotMods.Count; ++i)
                        {
                            if (CurrentFighterActiveSlotMods[i].SlotID > slotNum) --CurrentFighterActiveSlotMods[i].SlotID;
                        }
                    }
                }
                string path = Globals.PathHelper.GetCharacterSlotModPath(CurrentFighter.name, SelectedSlotMod.modFolder);
                if (Directory.Exists(path)) Directory.Delete(path, true);
                RefreshSlotModsLists();
            }
            if (SelectedGeneralMod != null)
            {
                if (MessageBox.Show(string.Format("Are you sure you want to delete the mod '{0}'?", SelectedGeneralMod.name), "Delete Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                if (SelectedGeneralMod.isActiveList)
                {
                    string modFolder = SelectedGeneralMod.modFolder;
                    for (int i = 0; i < CurrentFighterActiveGeneralMods.Count; ++i)
                    {
                        if (CurrentFighterActiveGeneralMods[i].FolderName.Equals(modFolder))
                        {
                            _SmashProjectManager.CurrentProject.ActiveCharacterGeneralMods.Remove(CurrentFighterActiveGeneralMods[i]);
                            CurrentFighterActiveGeneralMods.RemoveAt(i);
                            break;
                        }
                    }
                }
                string path = Globals.PathHelper.GetCharacterGeneralModPath(CurrentFighter.name, SelectedGeneralMod.modFolder);
                if (Directory.Exists(path)) Directory.Delete(path, true);
                RefreshGeneralModsLists();
            }
        }

        private void buttonModProperties_Click(object sender, EventArgs e)
        {
            if (SelectedSlotMod != null)
            {
                SelectedSlotMod.OpenProperties();
            }
            if (SelectedGeneralMod != null)
            {
                SelectedGeneralMod.OpenProperties();
            }
        }
        #endregion

        private void help_Click(object sender, EventArgs e)
        {
            PictureBox helpBtn = sender as PictureBox;
            if (helpBtn == null)
                return;

            switch (helpBtn.Name)
            {
                case "helpButtons":
                    MessageBox.Show(UIStrings.HELP_CHARACTERMODS_BUTTONS, UIStrings.CAPTION_HELP);
                    break;
                case "helpSlotMods":
                    MessageBox.Show(UIStrings.HELP_CHARACTERMODS_SLOTMODS, UIStrings.CAPTION_HELP);
                    break;
                case "helpGeneralMods":
                    MessageBox.Show(UIStrings.HELP_CHARACTERMODS_GENERALMODS, UIStrings.CAPTION_HELP);
                    break;
            }
        }
    }
}
