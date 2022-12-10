using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class ManagersDAL
    {
        #region Get Manager
        public ManagersEntity GetYManagerwithAd(string managerName)
        {
            SqlParameter[] managerParameters =
            {
                new SqlParameter { ParameterName = "managerName", Value = managerName },
            };
            SqlDataReader managerRdr = BilgiHotelHelperSql.MyExecuteReader("select * from managers where managerName=@managerName", managerParameters, "txt");
            ManagersEntity myManager= new ManagersEntity();  
            while(managerRdr.Read())
            {
                myManager.managerName= managerRdr[1].ToString();
                myManager.managerSurname = managerRdr[2].ToString();
                myManager.managerPhoneNumber = managerRdr[3].ToString();
                myManager.managerEMail = managerRdr[4].ToString();
                myManager.managerAddress = managerRdr[5].ToString();
                myManager.countryID = (int)managerRdr[6];
                myManager.cityID = (int)managerRdr[7];
                myManager.districtID = (int)managerRdr[8];
                myManager.assignmentID = (int)managerRdr[9];
                myManager.genderID = (int)managerRdr[10];
                myManager.managerSalary = managerRdr[11].ToString();
                myManager.startingDateOfEmployment = Convert.ToDateTime(managerRdr[12]);
                myManager.endingDateOfEmployment = Convert.ToDateTime(managerRdr[13]);
                myManager.isTheManagerActive = (bool)managerRdr[14];
                myManager.managerDescription = managerRdr[15].ToString();

            }
            return myManager;  
        }
        #endregion
        #region Manager Insert
        public int InsertManager(ManagersEntity managerToInsert)
        {
            SqlParameter[] managerParameters =
            {
                new SqlParameter{ParameterName="managerName" , Value=managerToInsert.managerName},
                new SqlParameter{ParameterName="managerSurname", Value=managerToInsert.managerSurname},
                 new SqlParameter{ParameterName="managerPhoneNumber", Value=managerToInsert.managerPhoneNumber},
                 new SqlParameter { ParameterName = "managerEMail", Value = managerToInsert.managerEMail },
                 new SqlParameter { ParameterName = "managerAddress", Value = managerToInsert.managerAddress },
                 new SqlParameter { ParameterName = "countryID", Value = managerToInsert.countryID },
                 new SqlParameter { ParameterName = "cityID", Value = managerToInsert.cityID },
                 new SqlParameter { ParameterName = "districtID", Value = managerToInsert.districtID },
                 new SqlParameter { ParameterName = "assignmentID", Value = managerToInsert.assignmentID },
                 new SqlParameter { ParameterName = "genderID", Value = managerToInsert.genderID },
                 new SqlParameter { ParameterName = "managerSalary", Value = managerToInsert.managerSalary},
                 new SqlParameter { ParameterName = "startingDateOfEmployment", Value = managerToInsert.startingDateOfEmployment },
                 new SqlParameter { ParameterName = "endingDateOfEmployment", Value = managerToInsert.endingDateOfEmployment },
                 new SqlParameter { ParameterName = "isTheManagerActive", Value = managerToInsert.isTheManagerActive },
                 new SqlParameter { ParameterName = "managerDescription", Value = managerToInsert.managerDescription },
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_YoneticiEkle", managerParameters, "sp");
            return affectedLine;    
            
        }
        #endregion
        #region Manager Update
        public int UpdateManager(ManagersEntity managerToUpdate)
        {
            SqlParameter[] managerParameters =
            {
                new SqlParameter{ParameterName="managerName" , Value=managerToUpdate.managerName},
                new SqlParameter{ParameterName="managerSurname", Value=managerToUpdate.managerSurname},
                 new SqlParameter{ParameterName="managerPhoneNumber", Value=managerToUpdate.managerPhoneNumber},
                 new SqlParameter { ParameterName = "managerEMail", Value = managerToUpdate.managerEMail },
                 new SqlParameter { ParameterName = "managerAddress", Value = managerToUpdate.managerAddress },
                 new SqlParameter { ParameterName = "countryID", Value = managerToUpdate.countryID },
                 new SqlParameter { ParameterName = "cityID", Value = managerToUpdate.cityID },
                 new SqlParameter { ParameterName = "districtID", Value = managerToUpdate.districtID },
                 new SqlParameter { ParameterName = "assignmentID", Value = managerToUpdate.assignmentID },
                 new SqlParameter { ParameterName = "genderID", Value = managerToUpdate.genderID },
                 new SqlParameter { ParameterName = "managerSalary", Value = managerToUpdate.managerSalary},
                 new SqlParameter { ParameterName = "startingDateOfEmployment", Value = managerToUpdate.startingDateOfEmployment },
                 new SqlParameter { ParameterName = "endingDateOfEmployment", Value = managerToUpdate.endingDateOfEmployment },
                 new SqlParameter { ParameterName = "isTheManagerActive", Value = managerToUpdate.isTheManagerActive },
                 new SqlParameter { ParameterName = "managerDescription", Value = managerToUpdate.managerDescription },
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_YoneticiGuncelle", managerParameters, "sp");
            return affectedLine;

        }
        #endregion
        #region Manager Delete
        public int DeleteManager(ManagersEntity managerToDelete)
        {
            SqlParameter[] managerParameters =
            {
                new SqlParameter{ParameterName="managerName" , Value=managerToDelete.managerName},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_YoneticiSil", managerParameters, "sp");
            return affectedLine;

        }
        #endregion
    }
}
