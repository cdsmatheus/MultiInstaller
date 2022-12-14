using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MultiInstaller
{
    class Install
    {
        Process p = new Process();
        public bool InstalarMSI(string FilePath)
        {
            p.StartInfo.FileName = "msiexec.exe";
            p.StartInfo.Arguments = "/i " + FilePath + " /quiet /qn /norestart";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();

            if (p.HasExited)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void InstalarEXE()
        {

        }
    }
}
