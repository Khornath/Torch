﻿using System.Collections.Generic;

namespace Torch
{
    public interface ITorchConfig
    {
        bool Autostart { get; set; }
        bool ForceUpdate { get; set; }
        bool GetPluginUpdates { get; set; }
        bool GetTorchUpdates { get; set; }
        string InstanceName { get; set; }
        string InstancePath { get; set; }
        bool NoGui { get; set; }
        bool NoUpdate { get; set; }
        List<string> Plugins { get; set; }
        bool RestartOnCrash { get; set; }
        bool ShouldUpdatePlugins { get; }
        bool ShouldUpdateTorch { get; }
        int TickTimeout { get; set; }
        string WaitForPID { get; set; }

        bool Save(string path = null);
    }
}