using BepInEx;
using HarmonyLib;
using System.Reflection;
using TimberbornAPI;
using UnityEngine;

namespace DroughtManager
{
    [BepInPlugin("jimmzexe.timberborn.drougthmanager", "DroughtManager", "1.0.0")]
    [BepInDependency("com.timberapi.timberapi")]
    [HarmonyPatch]
    public class DroughtManager : BaseUnityPlugin
    {
        public void Awake()
        {
            Logger.LogInfo("Plugin DroughtManager is loaded!");

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
            // TimberAPI.DependecyRegistry.AddConfigurator();
        }
    }
}
