using OpenQA.Selenium.Support.PageObjects;

namespace Framework
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static WriteReview WriteReview
        {
            get { return GetPage<WriteReview>(); }
        }

        public static TopNavigationPage TopNavigation
        {
            get { return GetPage<TopNavigationPage>(); }
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }

        public static MyAccount MyAccount
        {
            get { return GetPage<MyAccount>(); }
        }

        public static Invoice Invoice
        {
            get { return GetPage<Invoice>(); }
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }
    }
}
