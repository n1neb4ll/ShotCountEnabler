﻿using Harmony;
using System.Reflection;


namespace ShotCountEnabler
{
    public class ShotCountEnabler
    {
        internal static string ModDirectory;
        public static void Init(string directory, string settingsJSON) {
            var harmony = HarmonyInstance.Create("de.morphyum.ShotCountEnabler");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            ModDirectory = directory;
        }

    }
}
