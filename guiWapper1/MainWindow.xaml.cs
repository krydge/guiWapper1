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

        private async void LogReport_Click(object sender, RoutedEventArgs e)
        {
            var command = "cd o:; git log --max-count=1 -p";
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            //ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command);

            //procStartInfo.RedirectStandardOutput = true;
            //procStartInfo.UseShellExecute = false;
            //procStartInfo.CreateNoWindow = true;

            // wrap IDisposable into using (in order to release hProcess)
            using (Process process = new Process())
            {
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.Arguments = command;
                process.StartInfo.FileName = "powershell.exe";
                process.Start();
                string text;
                int wait = 0;
                while (process.StandardOutput.Peek() > -1 && wait < 1000)
                {
                    text = process.StandardOutput.ReadLine();
                    if (text.StartsWith("+++") ||
                        text.StartsWith("---") ||
                        text.StartsWith("diff") ||
                        text.StartsWith("index"))
                    {
                        Run run = new Run("\n" + text);
                        run.Foreground = Brushes.Yellow;
                        OutputBlock.Inlines.Add(run);
                    }
                    else if (text.StartsWith("+"))
                    {
                        Run run = new Run("\n" + text);
                        run.Foreground = Brushes.Green;
                        OutputBlock.Inlines.Add(run);
                    }
                    else if (text.StartsWith("-"))
                    {
                        Run run = new Run("\n" + text);
                        run.Foreground = Brushes.Red;
                        OutputBlock.Inlines.Add(run);
                    }
                    else
                    {
                        Run run = new Run("\n" + text);
                        run.Foreground = Brushes.White;
                        OutputBlock.Inlines.Add(run);
                    }
                    wait++;
                }

                //while (process.StandardError.Peek() > -1)
                //{
                //    OutputBlock.Foreground = Brushes.Red;
                //    OutputBlock.Text += process.StandardOutput.ReadLine();
                //}
                //process.WaitForExit();
                    //Wait for process to finish
                //}

                process.WaitForExit();
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
