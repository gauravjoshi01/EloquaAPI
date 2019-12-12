using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eloqua_API
{
    public class Site
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string displayName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
    }

    public class Soap
    {
        public string standard { get; set; }
        public string dataTransfer { get; set; }
        public string email { get; set; }
        public string externalAction { get; set; }
    }

    public class Rest
    {
        public string standard { get; set; }
        public string bulk { get; set; }
    }

    public class Apis
    {
        public Soap soap { get; set; }
        public Rest rest { get; set; }
    }

    public class Urls
    {
        public string @base { get; set; }
        public Apis apis { get; set; }
    }

    public class BaseUrl
    {
        public Site site { get; set; }
        public User user { get; set; }
        public Urls urls { get; set; }
    }
}
