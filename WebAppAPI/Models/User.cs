using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAPI.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserFName { get; set; }
        public string UserMName { get; set; }
        public string UserLName { get; set; }
        public string UserMobNo { get; set; }
        public string UserEmailId { get; set; }
        public string UserAltNo { get; set; }
        public string UserPanNo { get; set; }
        public string UserAdhNo { get; set; }
        public int SourceChannelId { get; set; }

    }
}