﻿using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Ssptsd
    {
        public int Ssptsdid { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public string? LeftType { get; set; }
        public string? RightType { get; set; }
        public decimal? LeftLength { get; set; }
        public decimal? RightLength { get; set; }
        public int? MpanelNo { get; set; }
        public string? LightType { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
