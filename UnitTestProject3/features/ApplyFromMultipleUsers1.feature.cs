﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UnitTestProject3.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ApplyToJobFromMultipleUsersFeature")]
    public partial class ApplyToJobFromMultipleUsersFeatureFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ApplyFromMultipleUsers.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ApplyToJobFromMultipleUsersFeature", "In order to avoid repeated work\r\nI want to send apply to job once time from 15 us" +
                    "ers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Apply to job from 15 users")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void ApplyToJobFrom15Users()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Apply to job from 15 users", new string[] {
                        "mytag"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I have ciklum home page jobs.ciklum.com/search-and-apply/", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I have found vacancy Automated QAs for e-Boks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "LastName",
                        "Email",
                        "Phone"});
            table1.AddRow(new string[] {
                        "Andrey",
                        "Birmingam",
                        "agb@mailinator.com",
                        "37552"});
            table1.AddRow(new string[] {
                        "Devid",
                        "Boui",
                        "db@mailinator.com",
                        "99635"});
            table1.AddRow(new string[] {
                        "Ann",
                        "Mild",
                        "annm@mailinator.com",
                        "78453"});
            table1.AddRow(new string[] {
                        "Grace",
                        "Crued",
                        "grace@malinator.com",
                        "77777"});
            table1.AddRow(new string[] {
                        "Alan",
                        "Mundy",
                        "Mundy@malinator.com",
                        "77777"});
            table1.AddRow(new string[] {
                        "Naomi",
                        "Burgland",
                        "Burgland@malinator.com",
                        "77777"});
            table1.AddRow(new string[] {
                        "Rachel",
                        "Sheader",
                        "Sheader@malinator.com",
                        "77777"});
            table1.AddRow(new string[] {
                        "Sarah",
                        "Wiltshire",
                        "Wiltshire@malinator.com",
                        "77777"});
            table1.AddRow(new string[] {
                        "Cris",
                        "Hinde",
                        "Hinde@malinator.com",
                        "77777"});
            table1.AddRow(new string[] {
                        "Adelle",
                        "Saville",
                        "Saville@malinator.com",
                        "77777"});
            table1.AddRow(new string[] {
                        "Albert",
                        "Hamill",
                        "Hamill@malinator.com",
                        "77777"});
            table1.AddRow(new string[] {
                        "Pablo",
                        "Dover",
                        "Dover@malinator.com",
                        "77777"});
            table1.AddRow(new string[] {
                        "Nikola",
                        "Sneddon",
                        "Sneddon@malinator.com",
                        "77777"});
            table1.AddRow(new string[] {
                        "Nikita",
                        "Till",
                        "Till@malinator.com",
                        "77777"});
            table1.AddRow(new string[] {
                        "Jasper",
                        "Wilton",
                        "Wilton@malinator.com",
                        "77777"});
#line 9
 testRunner.When("I have entered name, lastname, phone, email for each of users", ((string)(null)), table1, "When ");
#line 26
 testRunner.Then("I applied for job from 15 users", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
