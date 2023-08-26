using System;
using System.IO;
using OP_Net6._0;


while (true)
{
    ScreenWatcher screenWatcher = new ScreenWatcher();
    screenWatcher.Watch();
    if (screenWatcher.IsWhite())
    {
        Launcher launcher = new Launcher();
        launcher.Launch();
        break;
    }
}


