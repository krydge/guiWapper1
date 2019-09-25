﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GuiTestSample
{
    using TechTalk.SpecFlow;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Feature1")]
    public partial class BogusFeature1Feature
    {

        private TechTalk.SpecFlow.ITestRunner testRunner;

//#line 1 "Feature1.feature"
//#line hidden

        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature1", "A short summary of the feature", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }

        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }

        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }

        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }

        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("commit a comment")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public virtual void CommitAComment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("commit a comment", null, new string[] {
                        "tag1"});
#line 7
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
            testRunner.Given("a user types (.*) in a comment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
            testRunner.When("the user clicks commit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
            testRunner.Then("the answer is true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
//#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("click Dark Mode")]
        [NUnit.Framework.CategoryAttribute("tag2")]
        public virtual void ClickDarkMode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("click Dark Mode", null, new string[] {
                        "tag2"});
#line 13
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
            testRunner.Given("a user is in light mode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
            testRunner.When("the user clicks dark mode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
            testRunner.Then("the background changes to dark", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("click Light Mode")]
        [NUnit.Framework.CategoryAttribute("tag3")]
        public virtual void ClickLightMode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("click Light Mode", null, new string[] {
                        "tag3"});
#line 19
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 20
            testRunner.Given("a user is in dark mode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
            testRunner.When("the user clicks light mode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
            testRunner.Then("the background changes to light", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion