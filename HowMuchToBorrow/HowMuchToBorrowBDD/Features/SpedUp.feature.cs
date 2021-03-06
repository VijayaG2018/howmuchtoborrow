﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HowMuchToBorrowBDD.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("SpedUp", Description="As a prospective loan customer \r\nI want to use the home loan borrow calculator ", SourceFile="Features\\SpedUp.feature", SourceLine=0)]
    public partial class SpedUpFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SpedUp.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SpedUp", "As a prospective loan customer \r\nI want to use the home loan borrow calculator ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void VerifyHomeLoanBorrowingPowerCalculator(string applicationType, string dependants, string propertyType, string yourIncome, string otherIncome, string livingExpenses, string otherLoanRepay, string otherCommitments, string creditCardLimits, string borrowResultAmount, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "VerifyBorrowResultAmount&StartOver"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("VerifyHomeLoanBorrowingPowerCalculator", @__tags);
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
testRunner.Given("I am on MuchBorrowCalculatorPage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
testRunner.And(string.Format("I have entered Yourdetails {0} and {1} and {2} and {3} and {4} and {5} and {6} an" +
                        "d {7} and {8}", applicationType, dependants, propertyType, yourIncome, otherIncome, livingExpenses, otherLoanRepay, otherCommitments, creditCardLimits), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
testRunner.When("I click on Work out how much I could borrow button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
testRunner.Then(string.Format("the BorrowResult {0} will be displayed correctly", borrowResultAmount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
testRunner.And("I click on StartOver Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
testRunner.And("all the fields are reset to zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("VerifyHomeLoanBorrowingPowerCalculator, \'Single\'", new string[] {
                "VerifyBorrowResultAmount&StartOver"}, SourceLine=17)]
        public virtual void VerifyHomeLoanBorrowingPowerCalculator_Single()
        {
#line 9
this.VerifyHomeLoanBorrowingPowerCalculator("\'Single\'", "\'0\'", "\'Home to live in\'", "\'80000\'", "\'10000\'", "\'500\'", "\'100\'", "\'0\'", "\'10000\'", "\'532000\'", ((string[])(null)));
#line hidden
        }
        
        public virtual void VerifyErrorMessage(string applicationType, string dependants, string propertyType, string yourIncome, string otherIncome, string livingExpenses, string otherLoanRepay, string otherCommitments, string creditCardLimits, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "VerifyErrorMessage"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("VerifyErrorMessage", @__tags);
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
testRunner.Given(string.Format("I have entered Yourdetails {0} and {1} and {2} and {3} and {4} and {5} and {6} an" +
                        "d {7} and {8}", applicationType, dependants, propertyType, yourIncome, otherIncome, livingExpenses, otherLoanRepay, otherCommitments, creditCardLimits), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
testRunner.When("I click on Work out how much I could borrow button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
testRunner.Then("an appropriate error message will be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("VerifyErrorMessage, \'Single\'", new string[] {
                "VerifyErrorMessage"}, SourceLine=27)]
        public virtual void VerifyErrorMessage_Single()
        {
#line 22
this.VerifyErrorMessage("\'Single\'", "\'0\'", "\'Home to live in\'", "\'0\'", "\'0\'", "\'1\'", "\'0\'", "\'0\'", "\'0\'", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
