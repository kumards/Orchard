﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Orchard.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Comments")]
    public partial class CommentsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Comments.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Comments", "  In order to enable simple comment capabilities on my site\r\n  As an author\r\n  I " +
                    "want to allow comments to be safely posted on specific content item pages", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("HTML markup in any given comment is encoded")]
        public virtual void HTMLMarkupInAnyGivenCommentIsEncoded()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HTML markup in any given comment is encoded", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
    testRunner.When("I go to \"admin/blogs/create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "Title.Title",
                        "My Blog"});
#line 9
        testRunner.And("I fill in", ((string)(null)), table1, "And ");
#line 12
        testRunner.And("I hit \"Publish\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
        testRunner.And("I go to \"admin/blogs\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
        testRunner.And("I follow \"My Blog\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "Title.Title",
                        "My Post"});
            table2.AddRow(new string[] {
                        "Body.Text",
                        "Hi there."});
#line 16
        testRunner.And("I fill in", ((string)(null)), table2, "And ");
#line 20
        testRunner.And("I hit \"Publish\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
        testRunner.And("I go to \"my-blog/my-post\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "Comments.CommentText",
                        "This is<br id=\"bad-br\" />a <a href=\"#\">link</a>."});
#line 22
        testRunner.And("I fill in", ((string)(null)), table3, "And ");
#line 25
        testRunner.And("I hit \"Submit Comment\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
        testRunner.And("I go to \"my-blog/my-post\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
    testRunner.Then("I should see \"This is&lt;br id=&quot;bad-br&quot; /&gt;a &lt;a href\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
        testRunner.And("I should not see \"<br id=\"bad-br\" />\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
    testRunner.When("I go to \"Users/Account/LogOff\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
        testRunner.And("I go to \"my-blog/my-post\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table4.AddRow(new string[] {
                        "Comments.Author",
                        "Some One"});
            table4.AddRow(new string[] {
                        "Comments.CommentText",
                        "This is<br id=\"bad-anon-br\" />a <a href=\"#\">link</a>."});
#line 35
        testRunner.And("I fill in", ((string)(null)), table4, "And ");
#line 39
        testRunner.And("I hit \"Submit Comment\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
        testRunner.And("I go to \"my-blog/my-post\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
    testRunner.Then("I should see \"This is&lt;br id=&quot;bad-anon-br&quot; /&gt;a &lt;a href\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
        testRunner.And("I should not see \"<br id=\"bad-anon-br\" />\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
    testRunner.When("I go to \"users/account/logon\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table5.AddRow(new string[] {
                        "userNameOrEmail",
                        "admin"});
            table5.AddRow(new string[] {
                        "password",
                        "6655321"});
#line 49
        testRunner.And("I fill in", ((string)(null)), table5, "And ");
#line 53
        testRunner.And("I hit \"Sign In\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
        testRunner.And("I go to \"admin/settings/comments\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table6.AddRow(new string[] {
                        "CommentSettings.ModerateComments",
                        "true"});
#line 56
        testRunner.And("I fill in", ((string)(null)), table6, "And ");
#line 59
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
    testRunner.Then("I should see \"Settings updated\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
    testRunner.When("I go to \"users/account/logoff\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
        testRunner.And("I go to \"my-blog/my-post\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table7.AddRow(new string[] {
                        "Comments.Author",
                        "Bill"});
            table7.AddRow(new string[] {
                        "Comments.CommentText",
                        "This is a moderated comment."});
#line 64
        testRunner.And("I fill in", ((string)(null)), table7, "And ");
#line 68
        testRunner.And("I hit \"Submit Comment\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
        testRunner.And("I go to \"my-blog/my-post\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
    testRunner.Then("I should see \"Hi there\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
        testRunner.And("I should not see \"This is a moderated comment\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
