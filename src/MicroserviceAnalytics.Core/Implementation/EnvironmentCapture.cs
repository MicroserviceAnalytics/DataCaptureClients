﻿using MicroserviceAnalytics.Core.Model;
#if NET451
using Microsoft.VisualBasic.Devices;
#endif

namespace MicroserviceAnalytics.Core.Implementation
{
#if NET451
    internal class EnvironmentCapture : IEnvironmentCapture
    {
        public Environment Get()
        {
            ComputerInfo info = new ComputerInfo();
            
            return new Environment
            {
                AvailablePhysicalMemory = info.AvailablePhysicalMemory,
                Locale = info.InstalledUICulture.Name,
                MachineName = System.Environment.MachineName,
                OperatingSystemVerson = System.Environment.OSVersion.VersionString,
                ProcessorCount = System.Environment.ProcessorCount,
                TotalPhysicalMemory = info.TotalPhysicalMemory
            };
        }
    }
#else
    internal class EnvironmentCapture : IEnvironmentCapture
    {
        public Environment Get()
        {
            return null;
        }
    }
#endif
}
