﻿using System.Collections.Generic;
using XIVSlothComboX.Combos;
using XIVSlothComboX.Combos.PvE;
using XIVSlothComboX.Services;

namespace XIVSlothComboX.CustomComboNS.Functions
{
    internal abstract partial class CustomComboFunctions
    {
        /// <summary> Determine if the given preset is enabled. </summary>
        /// <param name="preset"> Preset to check. </param>
        /// <returns> A value indicating whether the preset is enabled. </returns>
        public static bool IsEnabled(CustomComboPreset preset) => (int)preset < 100 || Service.Configuration.IsEnabled(preset);

        /// <summary> Determine if the given preset is not enabled. </summary>
        /// <param name="preset"> Preset to check. </param>
        /// <returns> A value indicating whether the preset is not enabled. </returns>
        public static bool IsNotEnabled(CustomComboPreset preset) => !IsEnabled(preset);

        public class JobIDs
        {
            //  Job IDs     ClassIDs (no jobstone) (Lancer, Pugilist, etc)
            public static readonly List<byte> Melee = new()
            {
                DRG.JobID, DRG.ClassID,
                MNK.JobID, MNK.ClassID,
                NIN.JobID, NIN.ClassID,
                RPR.JobID,
                SAM.JobID
            };

            public static readonly List<byte> Ranged = new()
            {
                BLM.JobID, BLM.ClassID,
                BRD.JobID, BRD.ClassID,
                SMN.JobID, SMN.ClassID,
                MCH.JobID,
                RDM.JobID,
                DNC.JobID,
                BLU.JobID
            };

            public static readonly List<byte> Tank = new()
            {
                PLD.JobID, PLD.ClassID,
                WAR.JobID, WAR.ClassID,
                DRK.JobID,
                GNB.JobID
            };

            public static readonly List<byte> Healer = new()
            {
                WHM.JobID, WHM.ClassID,
                SCH.JobID,
                AST.JobID,
                SGE.JobID
            };

        }
    }
}
