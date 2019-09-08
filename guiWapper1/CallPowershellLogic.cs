using guiWapper1.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

                var command = "git commit -am " + message;
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

    }
}
