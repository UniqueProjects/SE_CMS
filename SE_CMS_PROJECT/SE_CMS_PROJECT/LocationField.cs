using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SE_CMS_PROJECT
{
    public class LocationField
    {
        public int Location_Id { get; set; }
        public string Location_Name { get; set; }
        public string Location_latitude { get; set; }
        public string Location_Longitude { get; set; }
        public Boolean Location_Status { get; set; }
    }
}