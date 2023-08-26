using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OP_Net6._0
{
    public class Launcher
    {
        public string fileName = @"E:\Game\原神\Genshin Impact\Genshin Impact Game\YuanShen.exe";
        public ProcessStartInfo startInfo = new ProcessStartInfo();
        public Launcher()
        {
            startInfo.FileName = fileName;
            startInfo.Verb = "runas";
        }
        public void Launch()
        {
            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
                process.Close();
            }
        }
    }
}
