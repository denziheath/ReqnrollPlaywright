using ReqnrollPlaywright.Drivers;
using ReqnrollPlaywright.Pages;
using SpecFlow.Assist;

namespace ReqnrollPlaywright.StepDefinitions
{
    [Binding]
    public sealed class EaAppTestSteps
    {
        private readonly Driver _driver;
        private readonly LoginPage _loginpage;

        public EaAppTestSteps(Driver driver)
        {
            _driver = driver;
            _loginpage = new LoginPage(_driver.Page);
        }



        [Given(@"I enter following login details")]

        public async Task GivenIEnterFollowingLoginDetails(Table table)
        {
            // ScenarioContext.StepIsPending is deprecated -> throw new PendingStepException();

            dynamic data = table.CreateDynamicInstance();
            await _loginpage.Login((string)data.UserName, (string)data.Password);
        }

        [Given("I navigate to the application")]
        public void GivenINavigateToTheApplication()
        {
            _driver.Page.GotoAsync(url:"http://www.eaapp.somee.com");
        }

        [Given("I click login link")]
        public async Task GivenIClickLoginLink()
        {
            await _loginpage.ClickLogin();
        }

        [Then("I see employee lists")]
        public void ThenISeeEmployeeLists()
        {
        }

    }
}
