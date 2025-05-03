using System.Reflection;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace HorrorSpawn
{
    [BepInPlugin("elliot.gorillatag", "HorrorSpawn", "1.0.0")]
    public class Main : BaseUnityPlugin
    {
        private void Start()
        {
            if (PlayerPrefs.HasKey("seenGhostReactor"))
                PlayerPrefs.DeleteKey("seenGhostReactor");
        }
    }
}

