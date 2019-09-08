using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiWapper1
{
    public class CreatePowershell
    {
        //outputblock.inlines.clear();
        //var message = "yeet";
        //background = brushes.aliceblue;
        public static string DewProcess(string directory, string command)
        {

            using (Process process = new Process())
            {
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.Arguments = "cd " + directory +"; " + command;
                process.StartInfo.FileName = "powershell.exe";
                process.Start();
                string text = "";
                int wait = 0;
                while (process.StandardOutput.Peek() > -1 && wait < 1000)
                {
                    text += process.StandardOutput.ReadLine() + "\n";

                    wait++;
                }

                //process.WaitForExit();
                return text;
            }
        }
    }
}
