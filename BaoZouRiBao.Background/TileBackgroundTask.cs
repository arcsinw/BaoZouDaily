﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;

namespace BaoZouRiBao.Background
{
    public sealed class TileBackgroundTask : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            var def = taskInstance.GetDeferral();

            def.Complete();
        }
    }
}
