
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class CustomersDAL
    {
        string sqlbaglan = DataConnections.Get_MsSqlConnecionString;
        #region Get Customer

        public CustomersEntity GetCustomerswithAd(string customerName)
        {
            SqlParameter[] customerParameters =
             {
                new SqlParameter
                {  ParameterName = "customerName", Value=customerName
                },
            };

            SqlDataReader customerRdr = BilgiHotelHelperSql.MyExecuteReader("select * from customers where customerName=@customerName", customerParameters, "txt");

            CustomersEntity myCustomer = null;
            while(customerRdr.Read())
            {
                myCustomer.customerName= customerRdr[1].ToString();
                myCustomer.customerSurname= customerRdr[2].ToString();
                myCustomer.customerPhoneNumber = customerRdr[3].ToString();
                myCustomer.customerEMail = customerRdr[4].ToString();
                myCustomer.customerAddress= customerRdr[5].ToString();
                myCustomer.customerCompanyName= customerRdr[6].ToString();
                myCustomer.companyTaxNumber= customerRdr[7].ToString();
                myCustomer.isTheCustomerCompany = (bool)customerRdr[8];
                myCustomer.countryID = (int)customerRdr[9];
                myCustomer.cityID = (int)customerRdr[10];
                myCustomer.districtID = (int)customerRdr[11];
                myCustomer.languageID = (int)customerRdr[12];
                myCustomer.genderID= (int)customerRdr[13];
                myCustomer.campaignID = (int)customerRdr[14];
                myCustomer.isTheCustomerActive = (bool)customerRdr[15];
                myCustomer.customerDescription = customerRdr[16].ToString();
            }
            return myCustomer;
        }
        #endregion
        #region Customer Insert
        public int InsertCustomer(CustomersEntity customerToInsert)
        {
            SqlParameter[] customerParameters =
            {
                 new SqlParameter{ParameterName ="customerName", Value=customerToInsert.customerName},
                 new SqlParameter{ParameterName ="customerSurname", Value=customerToInsert.customerSurname},
                 new SqlParameter{ParameterName ="customerPhoneNumber", Value=customerToInsert.customerPhoneNumber},
                 new SqlParameter{ParameterName ="customerEMail", Value=customerToInsert.customerEMail},
                 new SqlParameter{ParameterName ="customerAddress", Value=customerToInsert.customerAddress},
                 new SqlParameter{ParameterName ="customerCompanyName", Value=customerToInsert.customerCompanyName},
                 new SqlParameter{ParameterName ="companyTaxNumber", Value=customerToInsert.companyTaxNumber},
                 new SqlParameter{ParameterName ="isTheCustomerCompany", Value=customerToInsert.isTheCustomerCompany},
                 new SqlParameter{ParameterName ="countryID", Value=customerToInsert.countryID},
                 new SqlParameter{ParameterName ="cityID", Value=customerToInsert.cityID},
                 new SqlParameter{ParameterName ="districtID", Value=customerToInsert.districtID},
                 new SqlParameter{ParameterName ="languageID", Value=customerToInsert.languageID},
                 new SqlParameter{ParameterName ="genderID", Value=customerToInsert.genderID},
                 new SqlParameter{ParameterName ="campaignID", Value=customerToInsert.campaignID},
                 new SqlParameter{ParameterName ="isTheCustomerActive", Value=customerToInsert.isTheCustomerActive},
                 new SqlParameter{ParameterName ="customerDescription", Value=customerToInsert.customerDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_customerInsert", customerParameters, "sp");
            return affectedLine;
        }
        #endregion
        #region Customer Update
        public int UpdateCustomer(CustomersEntity customerToUpdate)
        {
            SqlParameter[] customerParameters =
            {
                 new SqlParameter{ParameterName ="customerName", Value=customerToUpdate.customerName},
                 new SqlParameter{ParameterName ="customerSurname", Value=customerToUpdate.customerSurname},
                 new SqlParameter{ParameterName ="customerPhoneNumber", Value=customerToUpdate.customerPhoneNumber},
                 new SqlParameter{ParameterName ="customerEMail", Value=customerToUpdate.customerEMail},
                 new SqlParameter{ParameterName ="customerAddress", Value=customerToUpdate.customerAddress},
                 new SqlParameter{ParameterName ="customerCompanyName", Value=customerToUpdate.customerCompanyName},
                 new SqlParameter{ParameterName ="companyTaxNumber", Value=customerToUpdate.companyTaxNumber},
                 new SqlParameter{ParameterName ="isTheCustomerCompany", Value=customerToUpdate.isTheCustomerCompany},
                 new SqlParameter{ParameterName ="countryID", Value=customerToUpdate.countryID},
                 new SqlParameter{ParameterName ="cityID", Value=customerToUpdate.cityID},
                 new SqlParameter{ParameterName ="districtID", Value=customerToUpdate.districtID},
                 new SqlParameter{ParameterName ="languageID", Value=customerToUpdate.languageID},
                 new SqlParameter{ParameterName ="genderID", Value=customerToUpdate.genderID},
                 new SqlParameter{ParameterName ="campaignID", Value=customerToUpdate.campaignID},
                 new SqlParameter{ParameterName ="isTheCustomerActive", Value=customerToUpdate.isTheCustomerActive},
                 new SqlParameter{ParameterName ="customerDescription", Value=customerToUpdate.customerDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_customerUpdate", customerParameters, "sp");
            return affectedLine;
        }
        #endregion
        #region Customer Delete
        public int DeleteCustomer(CustomersEntity customerToDelete)
        {
            SqlParameter[] customerParameters =
            {
                new SqlParameter{ParameterName="customerName", Value=customerToDelete.customerName},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_customerDelete", customerParameters, "sp");
            return affectedLine;
        }
        #endregion
    }
}
