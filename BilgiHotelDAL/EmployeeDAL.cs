
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class EmployeeDAL
    {
        string sqlbaglan = DataConnections.Get_MsSqlConnecionString;
       

        #region  Get Employees

        
        public EmployeesEntity GetEmployeewithAd(string employeeName)
        {
            SqlParameter[] employeeParameters =
            {
                new SqlParameter
                {
                    ParameterName="@employeeName",
                    Value=employeeName
                },

            };

            SqlDataReader employeeRdr = BilgiHotelHelperSql.MyExecuteReader("select * from employees where employeeName=@employeeName", employeeParameters, "txt");

            EmployeesEntity myEmployee = null;
            while (employeeRdr.Read())
            {
               
                myEmployee.employeeName = employeeRdr[1].ToString();
                myEmployee.employeeSurname = employeeRdr[2].ToString();
                myEmployee.employeeTCIdentificationNumber = employeeRdr[3].ToString();
                myEmployee.employeeBirthDate = Convert.ToDateTime(employeeRdr[4]);
                myEmployee.employeePhoneNumber = employeeRdr[5].ToString();
                myEmployee.employeeEMail = employeeRdr[6].ToString();
                myEmployee.employeeAddress = employeeRdr[7].ToString();
                myEmployee.countryID = (int)employeeRdr[8];
                myEmployee.cityID = (int)employeeRdr[9];
                myEmployee.districtID = (int)employeeRdr[10];
                myEmployee.assignmentID = (int)employeeRdr[11];
                myEmployee.genderID = (int)employeeRdr[12];
                myEmployee.employeeHourlyWage = employeeRdr[13].ToString();
                myEmployee.employeeSalary = employeeRdr[14].ToString();
                myEmployee.employeeRegistrationNumber = employeeRdr[15].ToString();
                myEmployee.isTheEmployeeDisabled = (bool)employeeRdr[16];
                myEmployee.employeeEmergencyName = employeeRdr[17].ToString();
                myEmployee.employeeEmergencyPhoneNo = employeeRdr[18].ToString();
                myEmployee.employeeStartingDateOfEmployment = Convert.ToDateTime(employeeRdr[19]);
                myEmployee.employeeEndingDateOfEmployment = Convert.ToDateTime(employeeRdr[20]);
                myEmployee.employeeWorkingStatus = employeeRdr[21].ToString();
                myEmployee.isTheEmployeeActive = (bool)employeeRdr[22];
                myEmployee.employeeDescription = employeeRdr[23].ToString();
            }
            return myEmployee;

        }
        #endregion
        #region Insert Employee
        public int InsertEmployee(EmployeesEntity employeeToInsert)
        {
            SqlParameter[] employeeParameters =
            {

                     new SqlParameter {ParameterName="employeeName",Value=employeeToInsert.employeeName},
                     new SqlParameter {ParameterName="employeeSurname",Value=employeeToInsert.employeeSurname},
                     new SqlParameter {ParameterName="employeeTCIdentificationNumber",Value=employeeToInsert.employeeTCIdentificationNumber},
                     new SqlParameter {ParameterName="employeeBirthDate",Value=employeeToInsert.employeeBirthDate},
                     new SqlParameter {ParameterName="employeePhoneNumber",Value=employeeToInsert.employeePhoneNumber},
                     new SqlParameter {ParameterName="employeeEMail",Value=employeeToInsert.employeeEMail},
                     new SqlParameter {ParameterName="employeeAddress",Value=employeeToInsert.employeeAddress},
                     new SqlParameter {ParameterName="countryID",Value=employeeToInsert.countryID},
                     new SqlParameter {ParameterName="cityID",Value=employeeToInsert.cityID},
                     new SqlParameter {ParameterName="districtID",Value=employeeToInsert.districtID},
                     new SqlParameter {ParameterName="assignmentID",Value=employeeToInsert.assignmentID},
                     new SqlParameter {ParameterName="genderID",Value=employeeToInsert.genderID},
                     new SqlParameter {ParameterName="employeeHourlyWage",Value=employeeToInsert.employeeHourlyWage},
                     new SqlParameter {ParameterName="employeeSalary",Value=employeeToInsert.employeeSalary},
                     new SqlParameter {ParameterName="employeeRegistrationNumber",Value=employeeToInsert.employeeRegistrationNumber},
                     new SqlParameter {ParameterName="isTheEmployeeDisabled",Value=employeeToInsert.isTheEmployeeDisabled},
                     new SqlParameter {ParameterName="employeeEmergencyName",Value=employeeToInsert.employeeEmergencyName},
                     new SqlParameter {ParameterName="employeeEmergencyPhoneNo",Value=employeeToInsert.employeeEmergencyPhoneNo},
                     new SqlParameter {ParameterName="employeeStartingDateOfEmployment",Value=employeeToInsert.employeeStartingDateOfEmployment},
                     new SqlParameter {ParameterName="employeeEndingDateOfEmployment",Value=employeeToInsert.employeeEndingDateOfEmployment},
                     new SqlParameter {ParameterName="employeeWorkingStatus",Value=employeeToInsert.employeeWorkingStatus},
                     new SqlParameter {ParameterName="isTheEmployeeActive",Value=employeeToInsert.isTheEmployeeActive},
                     new SqlParameter {ParameterName="employeeDescription",Value=employeeToInsert.employeeDescription},

            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_EmployeeInsert", employeeParameters, "sp");

            return affectedLine;
            
        }
        #endregion
        #region Update Employee
         public int UpdateEmployee(EmployeesEntity employeeToUpdate)
        {
            SqlParameter[] employeeParameters =
            {

                     new SqlParameter {ParameterName="employeeName",Value=employeeToUpdate.employeeName},
                     new SqlParameter {ParameterName="employeeSurname",Value=employeeToUpdate.employeeSurname},
                     new SqlParameter {ParameterName="employeeTCIdentificationNumber",Value=employeeToUpdate.employeeTCIdentificationNumber},
                     new SqlParameter {ParameterName="employeeBirthDate",Value=employeeToUpdate.employeeBirthDate},
                     new SqlParameter {ParameterName="employeePhoneNumber",Value=employeeToUpdate.employeePhoneNumber},
                     new SqlParameter {ParameterName="employeeEMail",Value=employeeToUpdate.employeeEMail},
                     new SqlParameter {ParameterName="employeeAddress",Value=employeeToUpdate.employeeAddress},
                     new SqlParameter {ParameterName="countryID",Value=employeeToUpdate.countryID},
                     new SqlParameter {ParameterName="cityID",Value=employeeToUpdate.cityID},
                     new SqlParameter {ParameterName="districtID",Value=employeeToUpdate.districtID},
                     new SqlParameter {ParameterName="assignmentID",Value=employeeToUpdate.assignmentID},
                     new SqlParameter {ParameterName="genderID",Value=employeeToUpdate.genderID},
                     new SqlParameter {ParameterName="employeeHourlyWage",Value=employeeToUpdate.employeeHourlyWage},
                     new SqlParameter {ParameterName="employeeSalary",Value=employeeToUpdate.employeeSalary},
                     new SqlParameter {ParameterName="employeeRegistrationNumber",Value=employeeToUpdate.employeeRegistrationNumber},
                     new SqlParameter {ParameterName="isTheEmployeeDisabled",Value=employeeToUpdate.isTheEmployeeDisabled},
                     new SqlParameter {ParameterName="employeeEmergencyName",Value=employeeToUpdate.employeeEmergencyName},
                     new SqlParameter {ParameterName="employeeEmergencyPhoneNo",Value=employeeToUpdate.employeeEmergencyPhoneNo},
                     new SqlParameter {ParameterName="employeeStartingDateOfEmployment",Value=employeeToUpdate.employeeStartingDateOfEmployment},
                     new SqlParameter {ParameterName="employeeEndingDateOfEmployment",Value=employeeToUpdate.employeeEndingDateOfEmployment},
                     new SqlParameter {ParameterName="employeeWorkingStatus",Value=employeeToUpdate.employeeWorkingStatus},
                     new SqlParameter {ParameterName="isTheEmployeeActive",Value=employeeToUpdate.isTheEmployeeActive},
                     new SqlParameter {ParameterName="employeeDescription",Value=employeeToUpdate.employeeDescription},

            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_EmployeeUpdate", employeeParameters, "sp");

            return affectedLine;
           
        }
        #endregion
        #region Employee Delete
        public int DeleteEmployee(EmployeesEntity employeeToDelete)
        {
            SqlParameter[] employeeParameters =
            {
                new SqlParameter {ParameterName="employeeName",Value=employeeToDelete.employeeName}
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("Delete from employees where employeeName=@employeeName", employeeParameters, "txt");
            return affectedLine;
        }
       

    }

}
# endregion

