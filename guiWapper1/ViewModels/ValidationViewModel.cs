using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiWapper1.ViewModels
{
    public class ValidationViewModel : BindableDataErrorInfoBase
    {
        private readonly IRegionManager regionManager;
        private readonly IEventAggregator eventAggragator;

        public DelegateCommand<string> NavagateToMessaging { get;}

        public ValidationViewModel(IRegionManager regionManager, IEventAggregator eventAggregator) {
            this.regionManager = regionManager;
            this.eventAggragator = eventAggregator;
            NavagateToMessaging = new DelegateCommand<string>((Uri) =>
            {
                regionManager.RequestNavigate("ContentRegion", Uri);

            });
        }

    }
}
