﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace IHS.MvvmCross.Plugins.Keychain
{
    public class PluginLoader : IMvxPluginLoader
    {
        public static readonly PluginLoader Instance = new PluginLoader();
        public void EnsureLoaded()
        {
            var manager = Mvx.Resolve<IMvxPluginManager>();
            manager.EnsurePlatformAdaptionLoaded<PluginLoader>();
        }
    }
}
