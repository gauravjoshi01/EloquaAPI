using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Eloqua_API.LandingPage
{
    public class LandingPageHelper
    {
        public string GetBaseUrl(string userName,string passWord)
        {
            string URL = "https://login.eloqua.com/id";
            string JsonString = Eloqua_API.RestFolder.RestAPI.HttpGet(URL,userName,passWord);

            BaseUrl ret = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<BaseUrl>(JsonString);
            return ret.urls.@base;
        }

        public LandingPageReturn GetLandingPages(int page, string userName, string passWord,string baseurl)
        {
            LandingPageReturn dataret = new LandingPageReturn();
            string URL = baseurl + "/api/REST/2.0/assets/landingPages?page=" + page + "&count=10&depth=partial";

            string JsonString = Eloqua_API.RestFolder.RestAPI.HttpGet(URL,userName,passWord);


            DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(LandingPageReturn));
            using (var memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(JsonString)))
            {
                dataret = deserializer.ReadObject(memoryStream) as LandingPageReturn;
            }

            return dataret;
        }

        public LandingPageReturn GetLandingPage(int lpID, string userName, string passWord, string baseurl)
        {
            LandingPageReturn dataret = new LandingPageReturn();
            string URL = baseurl + "/api/REST/2.0/assets/landingPage/=" + lpID;

            string JsonString = Eloqua_API.RestFolder.RestAPI.HttpGet(URL, userName, passWord);


            DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(LandingPageReturn));
            using (var memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(JsonString)))
            {
                dataret = deserializer.ReadObject(memoryStream) as LandingPageReturn;
            }

            return dataret;
        }
    }
}
