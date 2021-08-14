using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Taggedreport
    {
        public int Tagid { get; set; }
        public int Stepid { get; set; }

        public virtual Step Step { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
