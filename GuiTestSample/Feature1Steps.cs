using System;
using TechTalk.SpecFlow;

namespace GuiTestSample
{
    [Binding]
    public class Feature1Steps
    {
        [Given(@"a user types in a comment")]
        public void GivenAUserTypesInAComment()
        {
            throw new PendingStepException();
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
    }
}
