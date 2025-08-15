using System.Collections;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP.Utils.Collections;
using ProjectM.Physics;
using ProjectM.Scripting;
using SleepyTimes.Services;
using Unity.Entities;
using UnityEngine;

namespace SleepyTimes;

internal static class Core{

    public static World Server { get; } = GetWorld("Server") ?? throw new System.Exception("No server found.");

    public static ServerScriptMapper ServerScriptMapper { get; } = Server.GetOrCreateSystemManaged<ServerScriptMapper>();

    public static EntityManager EntityManager { get; } = Server.EntityManager;
    public static ManualLogSource Log { get; } = Plugin.PluginLog;

    public static World GetWorld(string worldName) {
        foreach (var world in World.s_AllWorlds) {
            if (world.Name == worldName) return world;
        }
        return null;
    }
}