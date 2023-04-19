using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLabLossDemo
{
    public class MetaLabLossDetails
    {
        public MetaLabLossDetails()
        {
            LossDetails = new List<MetaLabLossModel>()
            {
            new MetaLabLossModel {Year = 2019, Loss = -4.5},
            new MetaLabLossModel {Year = 2020, Loss = -6.6},
            new MetaLabLossModel {Year = 2021, Loss = -10.2},
            new MetaLabLossModel {Year = 2022, Loss = -13.7}
            };
        }

        public List<MetaLabLossModel> LossDetails { get; set; }
    }
}
