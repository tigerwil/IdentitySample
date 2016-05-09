using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentitySample.Models
{
    public class CanadianProvinces
    {
        public static readonly IDictionary<string, string> ProvinceDictionary =
            new Dictionary<string, string>
            {
                {"Alberta", "AB"},
                {"British Columbia","BC"},
                {"Manitoba","MB"},
                {"New Brunswick","NB" },
                {"Newfoundland and Labrador", "NL"},
                {"Northwest Territories", "NT"},
                {"Nova Scotia","NS"},
                {"Nunavut" ,"NU"},
                {"Ontario", "ON"},
                {"Prince Edward Island","PE"},
                {"Quebec","QC"},
                {"Saskatchewan","SK"},
                {"Yukon","YT"}
            };

        public static SelectList ProvinceSelectList
        {
            get { return new SelectList(ProvinceDictionary, "Value", "Key"); }
        }


    }
}