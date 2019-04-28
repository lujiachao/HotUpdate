using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitUpdate
{
    public class AppSettingsOptions
    {
        public string GuidRequest { get; set; }

        public int Code { get; set; }

        public string Message { get; set; }

       public Data Data { get; set; }
    }

    public class Data
    {
        public string AgreeStatus { get; set; }

        public string ExtendParam { get; set; }
    }
}
