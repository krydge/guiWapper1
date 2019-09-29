using guiWapper1.Model;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using guiWapper1;
using System.Windows;
using Prism.Regions;

namespace guiWapper1.ViewModels
{
    public class MainWindowViewModel : BindableDataErrorInfoBase 
    {
        private string repoLocation;
        private IRegionManager regionManager;
        private IEventAggregator eventAggragator;
        private DelegateCommand onError;

        public DelegateCommand onClickStatus { get; set; }
        public DelegateCommand onClickLog { get; set; }
        public DelegateCommand onClickAdd { get; set; }
        public DelegateCommand onClickInit { get; set; }
        public DelegateCommand onClickCommit { get; set; }
        public DelegateCommand onClickFileSearch { get; set; }
        public DelegateCommand<string> NavigateToMessaging { get; }


        public MainWindowViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            this.regionManager = regionManager;
            this.eventAggragator = eventAggregator;
            RepoLocation = "C:";
            NavigateToMessaging = new DelegateCommand<string>((Uri) =>
            {
                regionManager.RequestNavigate("ContentRegion", Uri);
                //var outputView = regionManager.Regions["ContentRegion"].GetView("OutputView");
                //regionManager.Regions["ContentRegion"].Remove(outputView);

            });

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
            set {
                if(value.Contains(" "))
                {
                    RepoError = "Repository can't have any spaces";
                }
                else if (value.Length == 0)
                {
                    RepoError = "There must be an entry to use this function";
                }
                else
                {
                    RepoError = null;
                }
                SetProperty(ref repoLocation, value);
                RaisePropertyChanged();

            }
        }

        private string commitMessage;

        public string CommitMessage
        {
            get { return commitMessage; }
            set {
                if (value.Contains(" "))
                {
                    CommitError = "Commit can't have any spaces (till we figure why it doesn't work)";
                }
                else if (value.Length == 0)
                {
                    CommitError = "There must be an entry to use this function";
                }
                else
                {
                    CommitError = null;
                }
                SetProperty(ref commitMessage, value);
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
        private string repoError;
        public string RepoError
        {
            get { return repoError; }
            set
            {
                SetProperty(ref repoError, value);
                ErrorDictionary[nameof(RepoLocation)] = value;
                repoErrorVisibility = value?.Length > 0 ? Visibility.Collapsed : Visibility.Visible;
                RepoButtonDisable = RepoErrorVisibility.Equals(Visibility.Collapsed) ? false : true;
                ErrorList = Error;
            }
        }
        public string ErrorList
        {
            get { return errorList; }
            set
            {
                if (value.Length == 0)
                { 
                    regionManager.RequestNavigate("ContentRegion", "OutputView");
                }
                else
                {
                    regionManager.RequestNavigate("ContentRegion", "ValidationView");
                }
                SetProperty(ref errorList, value);
                RaisePropertyChanged();
            }
        }
        private string commitError;
        public string CommitError
        {
            get { return commitError; }
            set
            {
                SetProperty(ref commitError, value);
                ErrorDictionary[nameof(CommitMessage)] = value;
                commitErrorVisibility = value?.Length > 0 ? Visibility.Collapsed : Visibility.Visible;
                CommitButtonDisable = CommitErrorVisibility.Equals(Visibility.Collapsed) ? false : true;
                ErrorList = Error;
            }
        }

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
                regionManager.RequestNavigate("ContentRegion", "OutputView");
                SetProperty(ref output, value);
                RaisePropertyChanged();
            }
        }

        ///////////////////////////////////////////////////////////////////////////
        //Visibility items
        private Visibility commitErrorVisibility;
        private Visibility repoErrorVisibility;
        private bool repoButtonDisable;
        private bool commitButtonDisable;
        private string errorList;

        public Visibility RepoErrorVisibility
        {
            get { return repoErrorVisibility; }
            set { SetProperty(ref repoErrorVisibility, value); }
        }
        public Visibility CommitErrorVisibility
        {
            get { return commitErrorVisibility; }
            set { SetProperty(ref commitErrorVisibility, value); }
        }
        //enable buttons
        //
        public bool RepoButtonDisable
        {
            get { return repoButtonDisable; }
            set
            {
                SetProperty(ref repoButtonDisable, value);
            }
        }
        public bool CommitButtonDisable
        {
            get { return commitButtonDisable; }
            set
            {
                SetProperty(ref commitButtonDisable, value);
            }
        }
    }
}
