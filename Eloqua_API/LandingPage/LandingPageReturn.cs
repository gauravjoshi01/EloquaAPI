using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eloqua_API.LandingPage
{
    public class HtmlContent
    {
        public string type { get; set; }
        public string contentSource { get; set; }
        public string html { get; set; }
    }

    public class Element
    {
        public string type { get; set; }
        public string currentStatus { get; set; }
        public string id { get; set; }
        public string createdAt { get; set; }
        public string depth { get; set; }
        public string folderId { get; set; }
        public string name { get; set; }
        public List<string> permissions { get; set; }
        public string updatedAt { get; set; }
        public string updatedBy { get; set; }
        public string autoRedirectUrl { get; set; }
        public string autoRedirectWaitFor { get; set; }
        public string deployedAt { get; set; }
        public string excludeFromAuthentication { get; set; }
        public HtmlContent htmlContent { get; set; }
        public string isContentProtected { get; set; }
        public string layout { get; set; }
        public string micrositeId { get; set; }
        public string refreshedAt { get; set; }
        public string style { get; set; }
    }

    public class LandingPageReturn
    {
        public List<Element> elements { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public int total { get; set; }
    }
    
}
