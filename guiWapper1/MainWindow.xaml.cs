using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace guiWapper1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StatusReport_Click(object sender, RoutedEventArgs e)
        {
            //var message = "YEET";
            Background = Brushes.AliceBlue;

        }

        private void LogReport_Click(object sender, RoutedEventArgs e)
        {
            var command = "git log -p c:/aqdev/ver15";
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            //ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command);

            //procStartInfo.RedirectStandardOutput = true;
            //procStartInfo.UseShellExecute = false;
            //procStartInfo.CreateNoWindow = true;

            // wrap IDisposable into using (in order to release hProcess) 
            using (Process process = new Process())
            {
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.Arguments = "git log c:/aqdev/ver15";
                process.StartInfo.FileName = "cmd";
                process.Start();

                ////strCommand is path and file name of command to run
                //pProcess.StartInfo.FileName = "cmd";

                ////strCommandParameters are parameters to pass to program
                //pProcess.StartInfo.Arguments = command;

                //pProcess.StartInfo.UseShellExecute = false;

                ////Set output of program to be written to process output stream
                //pProcess.StartInfo.RedirectStandardOutput = true;
                //pProcess.StartInfo.CreateNoWindow = true;
                //Process.Start("git", @"log c:/aqdev/ver15");


                //Start the process
                //pProcess.Start();

                //Get program output
                //OutputBlock.Text += pProcess.StandardOutput.ReadLine();
                OutputBlock.Text = process.StandardOutput.ReadLine();

                //Wait for process to finish
                //process.WaitForExit();
            }
        }

        private void InitRepo_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Lavender;
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Coral;
        }

        private void Commit_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Chartreuse;
            OutputBlock.Text += "\nCommit LoggeD";
        }
    }
}
