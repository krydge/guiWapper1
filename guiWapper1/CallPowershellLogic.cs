using guiWapper1.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace guiWapper1
{
    public class CallPowershellLogic
    {
        //public List<OutputLine> StatusReport_Click()
        public string StatusReport_Click(string directory)
        {
            if (directory != "" && directory != null)
            {
                OutputLine outputLineStuff = new OutputLine();
                List<OutputLine> outline = new List<OutputLine>();

                var command = "git status";
                var text = CreatePowershell.DewProcess(directory, command);

                ///////////////////////////////////////////////////////
                //If using List<OutputLine> do this code
                //var textArray = text.Split('\n');
                //foreach  (string line in textArray)
                //{

                //    outputLineStuff.LineText = text;

                //    var textLine = line.TrimStart('\t');
                //    if (textLine.StartsWith("modified:"))
                //    {
                //        outputLineStuff.Color = colors.YELLOW;
                //    }
                //    else if (textLine.StartsWith("deleted:"))
                //    {
                //        outputLineStuff.Color = colors.RED;
                //    }
                //    else if (textLine.StartsWith("added:"))
                //    {
                //        outputLineStuff.Color = colors.GREEN;
                //    }
                //    else
                //    {
                //        outputLineStuff.Color = colors.WHITE;
                //    }
                //    outline.Add(outputLineStuff);
                //}
                return text;
            }
            return "BROKE";

        }
    public string LogReport_Click(string directory)
        {
            if (directory != "" && directory != null)
            {
                OutputLine outputLineStuff = new OutputLine();
                List<OutputLine> outline = new List<OutputLine>();

                var command = "git log --max-count=1 -p";
                var text = CreatePowershell.DewProcess(directory, command);

                return text;
            }
            return "BROKE";
        }
        public string InitReport_Click(string directory)
        {
            if (directory != "" && directory != null)
            {
                OutputLine outputLineStuff = new OutputLine();
                List<OutputLine> outline = new List<OutputLine>();

                var command = "git init";
                var text = CreatePowershell.DewProcess(directory, command);

                return text;
            }
            return "BROKE";
        }
        public string CommitReport_Click(string directory, string message)
        {
            if (directory != "" && directory != null)
            {
                OutputLine outputLineStuff = new OutputLine();
                List<OutputLine> outline = new List<OutputLine>();

                var command = "git commit -m " + message;
                var text = CreatePowershell.DewProcess(directory, command);
                text = CreatePowershell.DewProcess(directory, "git status");

                return text;
            }
            return "BROKE";
        }
        public string AddReport_Click(string directory, string message)
        {
            if (directory != "" && directory != null)
            {
                OutputLine outputLineStuff = new OutputLine();
                List<OutputLine> outline = new List<OutputLine>();

                var command = "git add " + message;
                var text = CreatePowershell.DewProcess(directory, command + "; git status");
                return text;
            }
            return "BROKE";
        }
        public string FileSearch_Click(string directory)
        {
            if (directory != "" && directory != null)
            {
                //OutputLine outputLineStuff = new OutputLine();
                //List<OutputLine> outline = new List<OutputLine>();
                string filePath = directory;
                var openFolderDlg = new FolderBrowserDialog();
                {
                    openFolderDlg.RootFolder = Environment.SpecialFolder.UserProfile;
                    openFolderDlg.ShowNewFolderButton = false;// = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFolderDlg.Description = "Locate the directory for your repository";
                    
                    //var ret = openFileDialog.ShowDialog() == DialogResult.OK;
                    if (openFolderDlg.ShowDialog() == DialogResult.OK)
                    {
                        //Get the pathof specified file
                        filePath = openFolderDlg.SelectedPath;
                        filePath = filePath.Replace("\\", "/");

                    }
                }
                //var text = CreatePowershell.DewProcess(directory);
                return filePath;
            }
            return directory;
        }

    }
}
