﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KamiModpackBuilder.Sm4shMusic.Objects
{
    [XmlType(TypeName = "sds")]
    public class SoundDBStage
    {
        #region Properties
        public List<SoundDBStageSoundEntry> SoundEntries { get; set; }
        [XmlElement("stid")]
        public int SoundDBStageID { get; set; }

        [XmlIgnore]
        public SoundEntryCollection SoundEntryCollection { get; set; }
        #endregion

        public SoundDBStage(SoundEntryCollection soundEntryCollection, int soundDBStageID)
        {
            SoundEntryCollection = soundEntryCollection;
            SoundDBStageID = soundDBStageID;
            SoundEntries = new List<SoundDBStageSoundEntry>();
        }

        public SoundDBStage()
        {
        }
    }
}
