using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class DiyScheduled
    {
        public string ScheduledId { get; set; }
        public string Title { get; set; }
        public string ImageFile { get; set; }
        public string Font { get; set; }
        public string FontMaterialId { get; set; }
        public string BorderMaterialId { get; set; }
        public string ShirtNum { get; set; }
        public int? ShirtNumX { get; set; }
        public int? ShirtNumY { get; set; }
        public int? ShirtNumW { get; set; }
        public int? ShirtNumH { get; set; }
        public string Name { get; set; }
        public int? NameX { get; set; }
        public int? NameY { get; set; }
        public int? NameW { get; set; }
        public int? NameH { get; set; }
        public string Logo { get; set; }
        public int? LogoX { get; set; }
        public int? LogoY { get; set; }
        public int? LogoW { get; set; }
        public int? LogoH { get; set; }
        public int? Position { get; set; }
        public int? IsRadian { get; set; }
        public string Version { get; set; }
    }
}
