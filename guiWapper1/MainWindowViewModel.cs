using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiWapper1
{
    public class MainWindowViewModel:BindableBase
    {
        private string repoLocation;

        public string RepositoryLocation
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

        private IEnumerable<OutputLine> output;

        public IEnumerable<OutputLine> Output
        {
            get { return output; }
            set { output = value; }
        }


    }
}
