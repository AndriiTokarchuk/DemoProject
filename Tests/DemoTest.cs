using Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

    [TestClass]
    public class DemoTest : TestBase
    {
        [TestMethod]
        public void DemoTests()
        {
            Pages.Login.Goto();
            Assert.IsTrue(Pages.Login.IsAt());
            Pages.Login.LoginUnderUser("user@phptravels.com", "demouser");
            Assert.IsTrue(Pages.Login.IsLoggedUnderUser("Johny", "Smith"));

            Assert.IsTrue(Pages.MyAccount.IsAt());
            Assert.IsTrue(Pages.MyAccount.IsHotelPresent("Hurghada Sunset Desert Safari"));

            Pages.MyAccount.GetReviewWindowForHotel("Hurghada Sunset Desert Safari");
            Assert.IsTrue(Pages.WriteReview.IsAt());
            Pages.WriteReview.SelectCleanGrade("10");
            Pages.WriteReview.SelectStaffGrade("2");

            string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            Pages.WriteReview.FillReview(loremIpsum);
            Pages.WriteReview.ClickSubmit();

            Pages.MyAccount.GetInvoiceWindowForHotel("Hurghada Sunset Desert Safari");
            Assert.IsTrue(Pages.Invoice.IsAt());
            Assert.IsTrue(Pages.Invoice.GetDepositNowSum() == "USD $30.80");
            Assert.IsTrue(Pages.Invoice.GetTotalAmountSum() == "USD $28");
            Assert.IsTrue(Pages.Invoice.GetTaxAndVatSum() == "USD $308");
            Browser.Close();
        }
    }
}
