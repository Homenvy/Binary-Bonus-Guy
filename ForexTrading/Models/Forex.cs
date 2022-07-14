using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForexTrading.Models
{
    public class Forex
    {
        public int Id { get; set; }
        public string TradeCompany { get; set; }
        public string Icon { get; set; }
        public string IconAlt { get; set; }
        public string PreviewImg { get; set; }
        public string PreviewIcon { get; set; }
        public string PreviewAlt { get; set; }
        public string SiteURL { get; set; }
        public string SiteText { get; set; }
        public float BonusValue { get; set; }
        public string ClaimNowURL { get; set; }
        public string Details { get; set; }
        public int RowID { get; set; }
        public string BonusType { get; set; }
    }
}