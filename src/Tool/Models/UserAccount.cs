using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class UserAccount
    {
        public string UserId { get; set; }
        public string Account { get; set; }
        public string Pwd { get; set; }
        public string Version { get; set; }
    }
}
