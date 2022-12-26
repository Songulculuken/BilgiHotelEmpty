using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CampaignsEntity
    {
        public int campaignID { get; set; }
        public string campaignName { get; set; }

        public string campaignDiscount { get; set; }

        public DateTime campaignStartDate { get;set; }
        public DateTime campaignEndDate { get; set; }
        public bool isTheCampaignActive { get; set; }  
        public string campaignDescription { get; set; } 

    }
}
