using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework
{
    public class WriteReview
    {
        [FindsBy(How = How.XPath, Using = "//select[@id='7' and @name='reviews_clean']")]
        private IWebElement cleanDropDown;

        [FindsBy(How = How.XPath, Using = "//select[@id='7' and @name='reviews_comfort']")]
        private IWebElement comfortDropDown;

        [FindsBy(How = How.XPath, Using = "//select[@id='7' and @name='reviews_location']")]
        private IWebElement locationDropDown;

        [FindsBy(How = How.XPath, Using = "//select[@id='7' and @name='reviews_facilities']")]
        private IWebElement facilitiesDropDown;

        [FindsBy(How = How.XPath, Using = "//select[@id='7' and @name='reviews_staff']")]
        private IWebElement staffDropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='reviews-form-7']/div/div[2]/div/div/div[2]/div/textarea")]
        private IWebElement reviewsTextField;

        [FindsBy(How = How.XPath, Using = "//button[@id='7']")] 
        private IWebElement submitButton;

        public void SelectCleanGrade(string grade)
        {
            this.cleanDropDown.SelectFromDropDown(grade);
        }

        public void SelectStaffGrade(string grade)
        {
            this.staffDropDown.SelectFromDropDown(grade);
        }

        public void FillReview(string review)
        {
            this.reviewsTextField.SendKeys(review);
        }

        public void ClickSubmit()
        {
            this.submitButton.Click();
        }

        public bool IsAt()
        {
            return this.cleanDropDown.Exists();
        }
    }
}
