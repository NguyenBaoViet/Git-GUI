using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_GUI
{
    public class Control
    {
        string output;

        public string loading(string path, string command)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.WorkingDirectory = path;
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.UseShellExecute = false;
            ps.RedirectStandardOutput = true;
            ps.FileName = "cmd.exe";
            ps.Arguments = "/c " + command;
            ps.CreateNoWindow = true;
            Process proc = new Process();
            proc.StartInfo = ps;
            proc.Start();
            output = proc.StandardOutput.ReadToEnd();
            proc.Close();
            return output;
        }

    }
}
