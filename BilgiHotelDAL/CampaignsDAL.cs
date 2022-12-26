using BilgiHotelDAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{

    public class CampaignsDAL
    {

        #region Get Campaign
        public CampaignsEntity GetCampaignwithName(string campaignName)
        {
            SqlParameter[] campaignParameters =
            {
                new SqlParameter
                {
                    ParameterName="campaignName",
                    Value=campaignName
                },

            };
            SqlDataReader campaignRdr = BilgiHotelHelperSql.MyExecuteReader("select * from Campaigns where campaignName=@campaignName", campaignParameters, "txt");

            CampaignsEntity myCampaign = null;
            while (campaignRdr.Read())
            {
               
                myCampaign.campaignName = campaignRdr[1].ToString();
                myCampaign.campaignDiscount= campaignRdr[2].ToString();
                myCampaign.campaignStartDate = Convert.ToDateTime(campaignRdr[3]);
                myCampaign.campaignEndDate = Convert.ToDateTime(campaignRdr[4]);
                myCampaign.isTheCampaignActive = (bool)campaignRdr[5];
                myCampaign.campaignDescription = campaignRdr[6].ToString();
            }
            return myCampaign;
        }
        #endregion
        #region Campaign Insert
        public int InsertCampaign(CampaignsEntity campaignToInsert)
        {
            SqlParameter[] campaignParameters =
            {

                     new SqlParameter {ParameterName="campaignName",Value=campaignToInsert.campaignName},
                     new SqlParameter {ParameterName="campaignDiscount",Value=campaignToInsert.campaignDiscount},
                     new SqlParameter {ParameterName="campaignStartDate",Value=campaignToInsert.campaignStartDate},
                     new SqlParameter {ParameterName="campaignEndDate",Value=campaignToInsert.campaignEndDate},
                     new SqlParameter {ParameterName="isTheCampaignActive",Value=campaignToInsert.isTheCampaignActive},
                     new SqlParameter {ParameterName="campaignDescription",Value=campaignToInsert.campaignDescription},

            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_CampaignInsert", campaignParameters, "sp");

            return affectedLine;

        }
        #endregion
        #region Campaign Update
        public int UpdateCampaign(CampaignsEntity campaignToUpdate)
        {
            SqlParameter[] campaignParameters =
            {

                     new SqlParameter {ParameterName="campaignName",Value=campaignToUpdate.campaignName},
                     new SqlParameter {ParameterName="campaignDiscount",Value=campaignToUpdate.campaignDiscount},
                     new SqlParameter {ParameterName="campaignStartDate",Value=campaignToUpdate.campaignStartDate},
                     new SqlParameter {ParameterName="campaignEndDate",Value=campaignToUpdate.campaignEndDate},
                     new SqlParameter {ParameterName="isTheCampaignActive",Value=campaignToUpdate.isTheCampaignActive},
                     new SqlParameter {ParameterName="campaignDescription",Value=campaignToUpdate.campaignDescription},

            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_CampaignUpdate", campaignParameters, "sp");

            return affectedLine;

        }
        #endregion
        #region Campaign Delete
        public int DeleteCampaign(CampaignsEntity campaignToDelete)
        {
            SqlParameter[] campaignParameters =
            {

                     new SqlParameter {ParameterName="campaignName",Value=campaignToDelete.campaignName},
                   

            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_CampaignDelete", campaignParameters, "sp");

            return affectedLine;

        }
        #endregion
    }
}
