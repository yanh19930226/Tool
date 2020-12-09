using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class PropertyDelimit
    {
        public string DelimitId { get; set; }
        public string PropertyId { get; set; }
        public string ShowName { get; set; }
        public string BackName { get; set; }
        public int? IsOpen { get; set; }
        public string Val { get; set; }
        public string Version { get; set; }
        public int? Sno { get; set; }
    }
}
