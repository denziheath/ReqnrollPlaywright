using ReqnrollPlaywright.Drivers;
using ReqnrollPlaywright.Pages;

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

            //Specflow is deprecated so this line isnt working
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
        public async Task ThenISeeEmployeeLists()
        {
            //no idea why this is throwing an error
            var isExist = await _loginPage.IsEmployeeDetailsExists();
            isExist.Should().Be(true);
        }

    }
}
