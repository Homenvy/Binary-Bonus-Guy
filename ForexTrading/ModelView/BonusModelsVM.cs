using ForexTrading.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ForexTrading.ModelView
{
    public class BonusModelsVM
    {
        public List<Forex> Forex { get; set; }
        public List<Binary> Binary { get; set; }
    }
}