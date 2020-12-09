using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class UserMail
    {
        public string MailId { get; set; }
        public string Email { get; set; }
        public DateTime? AddTime { get; set; }
        public string Ip { get; set; }
        public string Details { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public int? IsDispose { get; set; }
        public DateTime? DisTime { get; set; }
        public string Remark { get; set; }
        public string Version { get; set; }
    }
}
