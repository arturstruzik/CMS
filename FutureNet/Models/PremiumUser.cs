using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FutureNet.Models
{
    public class PremiumUser
    {
        public int PremiumUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string FbSite { get; set; }
        public string Photo { get; set; }

        public ICollection<Contact> Contacts { get; set; }
    }
}