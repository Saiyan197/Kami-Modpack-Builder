﻿using KamiModpackBuilder.Objects;
using System.Collections.Generic;
using System;
using System.IO;
using ZLibNet;
using System.Xml;
using System.Xml.Serialization;

namespace KamiModpackBuilder.Globals
{
    public static class Utils
    {
        internal static ResourceExtension[] _ResourceExtensionsTable = null;

        internal static ResourceExtension[] ResourceExtensionsTable
        {
            get
            { if (_ResourceExtensionsTable == null) return GetExtensionTable(); return _ResourceExtensionsTable; }
        }

        public static string GetRegionFromFilename(string resourceFile)
        {
            if (resourceFile.Contains("resource("))
            {
                return resourceFile.Substring(resourceFile.LastIndexOf("(", StringComparison.Ordinal), 7);
            }
            return string.Empty;
        }

        public static bool IsCompressed(byte[] src)
        {
            if (src.Length < 2)
                return false;

            if (src[0] == 0x78 && (src[1] == 0x9c || src[1] == 0x01 || src[1] == 0xDA))
                return true;
            return false;
        }

        public static byte[] Compress(byte[] src)
        {
            using (var source = new MemoryStream(src))
            {
                using (var destStream = new MemoryStream())
                {
                    using (var compressor = new ZLibStream(destStream, CompressionMode.Compress, CompressionLevel.Level6))
                    {
                        source.CopyTo(compressor);
                    }
                    return destStream.ToArray();
                }
            }
        }

        public static byte[] DeCompress(byte[] src)
        {
            return ZLibCompressor.DeCompress(src);
        }

        internal static ResourceExtension[] GetExtensionTable()
        {
            _ResourceExtensionsTable = new ResourceExtension[0x46];
            _ResourceExtensionsTable[0x00] = new ResourceExtension("", 0x0000000);
            _ResourceExtensionsTable[0x01] = new ResourceExtension(".bin", 0x1000000); //Exception to the 1024Kb rule for compression (bigger files arent compressed)
            _ResourceExtensionsTable[0x02] = new ResourceExtension(".nuf", 0x2000000);
            _ResourceExtensionsTable[0x03] = new ResourceExtension(".nut", 0x3000000); //Exception to the 1024Kb rule for compression (bigger files arent compressed)
            _ResourceExtensionsTable[0x04] = new ResourceExtension(".efc", 0x4000000);
            _ResourceExtensionsTable[0x05] = new ResourceExtension(".ptcl", 0x5000000);
            _ResourceExtensionsTable[0x06] = new ResourceExtension(".mta", 0x6000000); //Exception to the 1024Kb rule for compression (some smaller files are compressed)
            _ResourceExtensionsTable[0x07] = new ResourceExtension(".nud", 0x7000000);
            _ResourceExtensionsTable[0x08] = new ResourceExtension(".omo", 0x8000000); //Exception to the 1024Kb rule for compression (some smaller files are compressed, some bigger files arent compressed)
            _ResourceExtensionsTable[0x09] = new ResourceExtension(".vbn", 0x9000000);
            _ResourceExtensionsTable[0x0a] = new ResourceExtension(".xmb", 0xa000000); //Exception to the 1024Kb rule for compression (some smaller files are compressed)
            _ResourceExtensionsTable[0x0b] = new ResourceExtension(".xmta", 0xb000000);
            _ResourceExtensionsTable[0x0c] = new ResourceExtension(".jtb", 0xc000000);
            _ResourceExtensionsTable[0x0d] = new ResourceExtension(".nhb", 0xd000000);
            _ResourceExtensionsTable[0x0e] = new ResourceExtension(".sb", 0xe000000);
            _ResourceExtensionsTable[0x0f] = new ResourceExtension(".pac", 0xf000000); //Exception to the 1024Kb rule for compression (some smaller files are compressed, some bigger files arent compressed)
            _ResourceExtensionsTable[0x10] = new ResourceExtension(".flp", 0x10000000);
            _ResourceExtensionsTable[0x11] = new ResourceExtension(".ik", 0x11000000);
            _ResourceExtensionsTable[0x12] = new ResourceExtension(".moi", 0x12000000);
            _ResourceExtensionsTable[0x13] = new ResourceExtension(".sbwl", 0x13000000);
            _ResourceExtensionsTable[0x14] = new ResourceExtension(".mtable", 0x14000000); //Exception to the 1024Kb rule for compression (bigger files arent compressed), seems random.
            _ResourceExtensionsTable[0x15] = new ResourceExtension(".mscsb", 0x15000000);
            _ResourceExtensionsTable[0x16] = new ResourceExtension(".nus3bank", 0x16000000); //Exception to the 1024Kb rule for compression (bigger files arent compressed): stage sounds, enemy sounds, se and vc of fighters arent compressed
            _ResourceExtensionsTable[0x17] = new ResourceExtension(".sqb", 0x17000000);
            _ResourceExtensionsTable[0x18] = new ResourceExtension(".vat", 0x18000000);
            _ResourceExtensionsTable[0x19] = new ResourceExtension(".mir", 0x19000000);
            _ResourceExtensionsTable[0x1a] = new ResourceExtension(".cms", 0x1a000000);
            _ResourceExtensionsTable[0x1b] = new ResourceExtension(".lvd", 0x1b000000);
            _ResourceExtensionsTable[0x1c] = new ResourceExtension(".mfp", 0x1c000000);
            _ResourceExtensionsTable[0x1d] = new ResourceExtension(".exi", 0x1d000000);
            _ResourceExtensionsTable[0x1e] = new ResourceExtension(".obt", 0x1e000000);
            _ResourceExtensionsTable[0x1f] = new ResourceExtension(".gya", 0x1f000000);
            _ResourceExtensionsTable[0x20] = new ResourceExtension(".h", 0x20000000);
            _ResourceExtensionsTable[0x21] = new ResourceExtension(".log", 0x21000000);
            _ResourceExtensionsTable[0x22] = new ResourceExtension(".mtmp", 0x22000000);
            _ResourceExtensionsTable[0x23] = new ResourceExtension(".nhbxml", 0x23000000);
            _ResourceExtensionsTable[0x24] = new ResourceExtension(".sa", 0x24000000);
            _ResourceExtensionsTable[0x25] = new ResourceExtension(".tdb", 0x25000000);
            _ResourceExtensionsTable[0x26] = new ResourceExtension(".xmbxml", 0x26000000);
            _ResourceExtensionsTable[0x27] = new ResourceExtension(".hkt", 0x27000000);
            _ResourceExtensionsTable[0x28] = new ResourceExtension(".HKX", 0x28000000);
            _ResourceExtensionsTable[0x29] = new ResourceExtension(".mbm", 0x29000000);
            _ResourceExtensionsTable[0x2a] = new ResourceExtension(".gsh", 0x2a000000);
            _ResourceExtensionsTable[0x2b] = new ResourceExtension(".xtal", 0x2b000000);
            _ResourceExtensionsTable[0x2c] = new ResourceExtension(".nsh", 0x2c000000);
            _ResourceExtensionsTable[0x2d] = new ResourceExtension(".rsm", 0x2d000000);
            _ResourceExtensionsTable[0x2e] = new ResourceExtension(".vew", 0x2e000000);
            _ResourceExtensionsTable[0x2f] = new ResourceExtension(".fbb", 0x2f000000);
            _ResourceExtensionsTable[0x30] = new ResourceExtension(".mmb", 0x30000000);
            _ResourceExtensionsTable[0x31] = new ResourceExtension(".mpb", 0x31000000);
            _ResourceExtensionsTable[0x32] = new ResourceExtension(".csb", 0x32000000);
            _ResourceExtensionsTable[0x33] = new ResourceExtension(".nus3conf", 0x33000000);
            _ResourceExtensionsTable[0x34] = new ResourceExtension(".nus3conf3d", 0x34000000);
            _ResourceExtensionsTable[0x35] = new ResourceExtension(".mtb", 0x35000000);
            _ResourceExtensionsTable[0x36] = new ResourceExtension(".spt", 0x36000000);
            _ResourceExtensionsTable[0x37] = new ResourceExtension(".fnv", 0x37000000);
            _ResourceExtensionsTable[0x38] = new ResourceExtension(".svt", 0x38000000);
            _ResourceExtensionsTable[0x39] = new ResourceExtension(".local", 0x39000000);
            _ResourceExtensionsTable[0x3a] = new ResourceExtension(".brf", 0x3a000000);
            _ResourceExtensionsTable[0x3b] = new ResourceExtension(".tex", 0x3b000000);
            _ResourceExtensionsTable[0x3c] = new ResourceExtension(".texatlas", 0x3c000000);
            _ResourceExtensionsTable[0x3d] = new ResourceExtension(".fgb", 0x3d000000);
            _ResourceExtensionsTable[0x3e] = new ResourceExtension(".flx", 0x3e000000);
            _ResourceExtensionsTable[0x3f] = new ResourceExtension(".lst", 0x3f000000);
            _ResourceExtensionsTable[0x40] = new ResourceExtension(".tinf", 0x40000000);
            _ResourceExtensionsTable[0x41] = new ResourceExtension(".lm", 0x41000000);
            _ResourceExtensionsTable[0x42] = new ResourceExtension(".msb", 0x42000000);
            _ResourceExtensionsTable[0x43] = new ResourceExtension(".msbt", 0x43000000);
            _ResourceExtensionsTable[0x44] = new ResourceExtension(".txt", 0x44000000);
            _ResourceExtensionsTable[0x45] = new ResourceExtension(".tga", 0x45000000);

            return _ResourceExtensionsTable;
        }

        public static bool IsAnAcceptedExtension(string file)
        {
            string extension = Path.GetExtension(file);

            if (Array.Exists(ResourceExtensionsTable, p => p.Name == extension))
                return true;
            return false;

        }

        public static string[] FindFilesByFilename(string[] filesToSearch, string stringToContain)
        {
            List<string> foundFiles = new List<string>();
            foreach (string fileToSearch in filesToSearch)
            {
                if (Path.GetFileName(fileToSearch).Contains(stringToContain)) foundFiles.Add(fileToSearch);
            }
            return foundFiles.ToArray();
        }
        
        /// <summary>
        /// Goes over every file to see if any are located in the desired directory name. If it is found, returns the full path of the found directory.
        /// </summary>
        /// <param name="filesToSearch">List of files to search for the directory using.</param>
        /// <param name="directoryName">The exact name of the directory to find.</param>
        /// <param name="baseDirectory">The base part of the directory to exclude in name searching.</param>
        /// <returns></returns>
        public static string FindDirectoryInFiles(string[] filesToSearch, string directoryName, string baseDirectory)
        {
            if (baseDirectory.EndsWith(Path.DirectorySeparatorChar.ToString())) baseDirectory = baseDirectory.Remove(baseDirectory.Length - 1);
            foreach (string fileToSearch in filesToSearch)
            {
                string relativePath = fileToSearch.Replace(baseDirectory, String.Empty);
                if (relativePath.Contains(Path.DirectorySeparatorChar + directoryName + Path.DirectorySeparatorChar))
                {
                    int position = relativePath.IndexOf(directoryName) + directoryName.Length + baseDirectory.Length;
                    return fileToSearch.Remove(position);
                }
            }
            return String.Empty;
        }

        /// <summary>
        /// Goes over every file to see if any are located in a desired directory name of many. If one is found, returns the full path of the first found directory.
        /// </summary>
        /// <param name="filesToSearch">List of files to search for the directory using.</param>
        /// <param name="directoryNames">The exact names of the directories to find.</param>
        /// <param name="baseDirectory">The base part of the directory to exclude in name searching.</param>
        /// <returns></returns>
        public static string FindDirectoryInFiles(string[] filesToSearch, string[] directoryNames, string baseDirectory)
        {
            if (baseDirectory.EndsWith(Path.DirectorySeparatorChar.ToString())) baseDirectory = baseDirectory.Remove(baseDirectory.Length - 1);
            foreach (string fileToSearch in filesToSearch)
            {
                string relativePath = fileToSearch.Replace(baseDirectory, String.Empty);
                for (int i = 0; i < directoryNames.Length; ++i)
                {
                    if (relativePath.Contains(Path.DirectorySeparatorChar + directoryNames[i] + Path.DirectorySeparatorChar))
                    {
                        int position = relativePath.IndexOf(directoryNames[i]) + directoryNames[i].Length + baseDirectory.Length;
                        return fileToSearch.Remove(position);
                    }
                }
            }
            return String.Empty;
        }

        public static T DeserializeXML<T>(string file)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                T loadedxml;
                using (StreamReader reader = new StreamReader(file))
                    loadedxml = (T)(ser.Deserialize(reader));
                return loadedxml;
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        public static void SerializeXMLToFile<T>(T data, string filename)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filename));
                XmlSerializer ser = new XmlSerializer(typeof(T));
                using (TextWriter writer = new StreamWriter(filename, false))
                    ser.Serialize(writer, data);
            }
            catch (Exception e)
            {
                LogHelper.Error(string.Format("Error while serializing file! {0}", e.Message));
            }
        }

        public static void CopyAllValidFilesBetweenDirectories(string fromDirectory, string toDirectory)
        {
            string[] filelist = Directory.GetFiles(fromDirectory, "*", SearchOption.AllDirectories);
            foreach (string file in filelist)
            {
                if ((!IsAnAcceptedExtension(file) && !file.EndsWith("kamimod.xml")) || file.EndsWith("packed"))
                    LogHelper.Error(string.Format("The file '{0}' has a forbidden extension, skipping...", file));
                else
                {
                    string newfile = file.Replace(fromDirectory, toDirectory);

                    FileAttributes pathAttrs = File.GetAttributes(file);
                    if (!pathAttrs.HasFlag(FileAttributes.Directory))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(newfile));
                        File.Copy(file, newfile, true);
                    }
                }
            }
        }

        #region Open/Save KamiMod Files
        public static CharacterSlotModXML OpenCharacterSlotKamiModFile(string characterName, string modName)
        {
            CharacterSlotModXML data = DeserializeXML<CharacterSlotModXML>(PathHelper.FolderCharSlotsMods + characterName + Path.DirectorySeparatorChar + modName + Path.DirectorySeparatorChar + "kamimod.xml");
            return data;
        }

        public static void SaveCharacterSlotKamiModFile(string characterName, string modName, CharacterSlotModXML data)
        {
            SerializeXMLToFile(data, PathHelper.FolderCharSlotsMods + characterName + Path.DirectorySeparatorChar + modName + Path.DirectorySeparatorChar + "kamimod.xml");
        }

        public static CharacterGeneralModXML OpenCharacterGeneralKamiModFile(string characterName, string modName)
        {
            CharacterGeneralModXML data = DeserializeXML<CharacterGeneralModXML>(PathHelper.FolderCharGeneralMods + characterName + Path.DirectorySeparatorChar + modName + Path.DirectorySeparatorChar + "kamimod.xml");
            return data;
        }

        public static void SaveCharacterGeneralKamiModFile(string characterName, string modName, CharacterGeneralModXML data)
        {
            SerializeXMLToFile(data, PathHelper.FolderCharGeneralMods + characterName + Path.DirectorySeparatorChar + modName + Path.DirectorySeparatorChar + "kamimod.xml");
        }

        public static StageModXML OpenStageKamiModFile(string modName)
        {
            StageModXML data = DeserializeXML<StageModXML>(PathHelper.FolderStageMods + modName + Path.DirectorySeparatorChar + "kamimod.xml");
            return data;
        }

        public static void SaveStageKamiModFile(string modName, StageModXML data)
        {
            SerializeXMLToFile(data, PathHelper.FolderStageMods + modName + Path.DirectorySeparatorChar + "kamimod.xml");
        }

        public static GeneralModXML OpenGeneralKamiModFile(string modName)
        {
            GeneralModXML data = DeserializeXML<GeneralModXML>(PathHelper.FolderGeneralMods + modName + Path.DirectorySeparatorChar + "kamimod.xml");
            return data;
        }

        public static void SaveGeneralKamiModFile(string modName, GeneralModXML data)
        {
            SerializeXMLToFile(data, PathHelper.FolderGeneralMods + modName + Path.DirectorySeparatorChar + "kamimod.xml");
        }
        #endregion
    }
}
