using guiWapper1.ViewModels;
using Moq;
using Prism.Events;
using Prism.Regions;
using System;
using TechTalk.SpecFlow;

namespace GuiTestSample
{
    [Binding]
    public class Feature1Steps { 


        private readonly ScenarioContext context;

        public Feature1Steps(ScenarioContext context)
        {
            this.context = context;
            var regionMock = new Mock<IRegionManager>();
            context.Add("regionMock", regionMock);
            var eventMock = new Mock<IEventAggregator>();
            context.Add("eventMock", eventMock);
        }
        [Given(@"a user types (.*) in a comment")]
        public void GivenAUserTypesInAComment(string comment)
        {
            var mainVM = new MainWindowViewModel(context.Get<Mock<IRegionManager>>, context.eventMock)
        }

        [When(@"the user clicks commit")]
        public void WhenTheUserClicksCommit()
        {
            throw new PendingStepException();
        }

        [Then(@"the answer is true")]
        public void ThenTheAnswerIsTrue()
        {
            throw new PendingStepException();
        }
        [Given(@"a user is in light mode")]
        public void GivenAUserIsInLightMode()
        {
            throw new PendingStepException();
        }

        [When(@"the user clicks dark mode")]
        public void WhenTheUserClicksDarkMode()
        {
            throw new PendingStepException();
        }

        [Then(@"the background changes to dark")]
        public void ThenTheBackgroundChangesToDark()
        {
            throw new PendingStepException();
        }

        [Given(@"a user is in dark mode")]
        public void GivenAUserIsInDarkMode()
        {
            throw new PendingStepException();
        }

        [When(@"the user clicks light mode")]
        public void WhenTheUserClicksLightMode()
        {
            throw new PendingStepException();
        }

        [Then(@"the background changes to light")]
        public void ThenTheBackgroundChangesToLight()
        {
            throw new PendingStepException();
        }

    }
}
