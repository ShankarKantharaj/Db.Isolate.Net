﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Db.Isolate.Integration.Test
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class StoredProcedureFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "StoredProcedure.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "StoredProcedure", "\tFor testing stored procedure in a \r\n\tisolated way", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "StoredProcedure")))
            {
                Db.Isolate.Integration.Test.StoredProcedureFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute stored procedure without parameters and returns table output")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StoredProcedure")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        public virtual void ExecuteStoredProcedureWithoutParametersAndReturnsTableOutput()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute stored procedure without parameters and returns table output", new string[] {
                        "mytag"});
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
 testRunner.Given("Truncate table \"Table_input\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Address",
                        "isPermanentAddress",
                        "Date"});
            table1.AddRow(new string[] {
                        "1",
                        "xyz",
                        "R.M Nagar",
                        "true",
                        "2017-06-25"});
            table1.AddRow(new string[] {
                        "2",
                        "abc",
                        "Electronic city",
                        "true",
                        "2017-06-25"});
#line 11
 testRunner.And("table name \"Table_input\" with test data", ((string)(null)), table1, "And ");
#line 15
 testRunner.When("I execute stored procedure \"sp_test\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "id",
                        "name",
                        "address",
                        "isPermanentAddress",
                        "date"});
            table2.AddRow(new string[] {
                        "1",
                        "xyz",
                        "R.M Nagar",
                        "True",
                        "2017-06-25T00:00:00"});
            table2.AddRow(new string[] {
                        "2",
                        "abc",
                        "Electronic city",
                        "True",
                        "2017-06-25T00:00:00"});
#line 16
 testRunner.Then("result is", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute stored procedure with input and output parameters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StoredProcedure")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        public virtual void ExecuteStoredProcedureWithInputAndOutputParameters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute stored procedure with input and output parameters", new string[] {
                        "mytag"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
 testRunner.Given("Truncate table \"Table_input\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.And("Truncate table \"Table_input1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Address",
                        "isPermanentAddress",
                        "Date"});
            table3.AddRow(new string[] {
                        "1",
                        "xyz",
                        "R.M Nagar",
                        "true",
                        "2017-06-25"});
            table3.AddRow(new string[] {
                        "2",
                        "abc",
                        "R.M Nagar",
                        "true",
                        "2017-06-25"});
#line 26
 testRunner.And("table name \"Table_input\" with test data", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Address",
                        "isPermanentAddress",
                        "Date"});
            table4.AddRow(new string[] {
                        "1",
                        "xyz",
                        "R.M Nagar",
                        "true",
                        "2017-06-25"});
            table4.AddRow(new string[] {
                        "2",
                        "abc",
                        "R.M Nagar",
                        "true",
                        "06-25-2017"});
#line 30
 testRunner.And("table name \"Table_input1\" with test data", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "input1",
                        "input2",
                        "output1(out)",
                        "output2(out)"});
            table5.AddRow(new string[] {
                        "val1",
                        "1",
                        "val1",
                        "1"});
#line 34
 testRunner.When("input parameters to stored procedure is", ((string)(null)), table5, "When ");
#line 37
 testRunner.And("I execute stored procedure \"sp_test_with_params\" which returns output parameters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.Then("output parameters is as expected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
