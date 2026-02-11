namespace ReqnrollPlaywright.StepDefinitions
{
    [Binding]
    public sealed class EaAppTestSteps
    {

        private readonly ScenarioContext _scenarioContext;

        public EaAppTestSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I enter following login details")]

        public void GivenIEnterFollowingLoginDetails(Table table)
        {
            ScenarioContext.StepIsPending();
        }


        [Given("I navigate to the application")]
        public void GivenINavigateToTheApplication()
        {
            // ScenarioContext.StepIsPending is deprecated, this is new -> throw new PendingStepException();
            ScenarioContext.StepIsPending();
        }

        [Given("I click login link")]
        public void GivenIClickLoginLink()
        {
            ScenarioContext.StepIsPending();
        }

        [Then("I see employee lists")]
        public void ThenISeeEmployeeLists()
        {
            ScenarioContext.StepIsPending();
        }

    }
}
