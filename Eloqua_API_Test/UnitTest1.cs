using System;
using Eloqua_API;
using Eloqua_API.LandingPage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eloqua_API_Test
{

    [TestClass]
    public class UnitTest1
    {
        string username = "MarketOneInternational\\Gaurav.Joshi";
        string password = "Market@03";
        string baseURL = "https://secure.p01.eloqua.com";
        LandingPageHelper landingPageHelper = new LandingPageHelper();

        [TestMethod]
        public void TestGetBaseURL()
        {
            string baseUrl = landingPageHelper.GetBaseUrl(username, password);
            //"https://secure.p01.eloqua.com"
        }

        [TestMethod]
        public void TestGetLandingPages()
        {
            //this method will return only 10 landing pages
            //to get next 10 landing pages increase page by 1
            int page = 1;
            LandingPageReturn landingPage = new LandingPageReturn();
            do
            {
                landingPage = landingPageHelper.GetLandingPages(page, username, password, baseURL);
                page = page + 1;
            } while (page * 10 < landingPage.total);
        }
    }
}
