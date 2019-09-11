using guiWapper1.Model;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiWapper1
{
    public class MainWindowViewModel : BindableBase 
    {
        private string repoLocation = "C:";

        public MainWindowViewModel()
        {
            var callPowershellLogic = new CallPowershellLogic();
            onClickStatus = new DelegateCommand(
               //execute
               () => Output = callPowershellLogic.StatusReport_Click(RepoLocation)

               );
            onClickLog = new DelegateCommand(
              //execute
              () => Output = callPowershellLogic.LogReport_Click(RepoLocation)

              );
            onClickInit = new DelegateCommand(
              //execute
              () => Output = callPowershellLogic.InitReport_Click(RepoLocation)

              );
            onClickAdd = new DelegateCommand(
             //execute
             () => Output = callPowershellLogic.AddReport_Click(RepoLocation, addMessage)

             );
            onClickCommit = new DelegateCommand(
             //execute
             () => Output = callPowershellLogic.CommitReport_Click(RepoLocation, CommitMessage)

             );
            onClickFileSearch = new DelegateCommand(
             //execute
             () => RepoLocation = callPowershellLogic.FileSearch_Click(RepoLocation)

             );
        }
        public string RepoLocation
        {
            get { return repoLocation; }
            set { repoLocation = value;
                RaisePropertyChanged();
            }
        }

        private string commitMessage;

        public string CommitMessage
        {
            get { return commitMessage; }
            set { commitMessage = value;
                RaisePropertyChanged();
            }
        }

        private string addMessage;

        public string AddMessage
        {
            get { return addMessage; }
            set
            {
                addMessage = value;
                RaisePropertyChanged();
            }
        }

        public DelegateCommand onClickStatus { get; set; }
        public DelegateCommand onClickLog { get; set; }
        public DelegateCommand onClickAdd { get; set; }
        public DelegateCommand onClickInit { get; set; }
        public DelegateCommand onClickCommit { get; set; }
        public DelegateCommand onClickFileSearch { get; set; }

        private List<OutputLine> output1;

        public List<OutputLine> Output1
        {
            get { return output1; }
            set { output1 = value;
                RaisePropertyChanged();
            }
        }


        private string output;

        public string Output
        {
            get { return output; }
            set
            {
                output = value;
                RaisePropertyChanged();
            }
        }


    }
}
