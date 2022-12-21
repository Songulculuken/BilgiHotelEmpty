using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class AssignmentsDAL
    {
        #region Get Assignment
        public AssignmentsEntity getAssignmentswithAd(string assignmentName)
        {
            SqlParameter[] assignmentParameters =
            {
                new SqlParameter{ParameterName="assignmentName",Value=assignmentName},
            };
            SqlDataReader gorevRdr = BilgiHotelHelperSql.MyExecuteReader("select * from Assignments where assignmentName=@assignmentName", assignmentParameters, "txt");
            AssignmentsEntity myGorev = new AssignmentsEntity();
            while(gorevRdr.Read())
            {
                myGorev.assignmentName = gorevRdr[1].ToString();
                myGorev.isTheAssignmentActive = (bool)gorevRdr[2];
                myGorev.assignmentDescription = gorevRdr[3].ToString();
            }
            return myGorev; 
        }
        #endregion
        #region Assignment Insert
        public int InsertAssignment(AssignmentsEntity assignmentToInsert)
        {
            SqlParameter[] assignmentParameters =
            {
                new SqlParameter{ParameterName="assignmentName",Value=assignmentToInsert.assignmentName},
                new SqlParameter{ParameterName="isTheAssignmentActive",Value=assignmentToInsert.isTheAssignmentActive},
                new SqlParameter{ParameterName="assignmentDescription",Value=assignmentToInsert.assignmentDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("insert into Assignments([assignmentName], [isTheAssignmentActive], [assignmentDescription]) values (@assignmentName,@isTheAssignmentActive,@assignmentDescription)", assignmentParameters, "txt");
            return affectedLine;    
        }
        #endregion
        #region Assignment Update
        public int UpdateAssignment(AssignmentsEntity assignmentToUpdate)
        {
            SqlParameter[] assignmentParameters =
            {
                new SqlParameter{ParameterName="assignmentName",Value= assignmentToUpdate.assignmentName},
                new SqlParameter{ParameterName="isTheAssignmentActive",Value= assignmentToUpdate.isTheAssignmentActive},
                new SqlParameter{ParameterName="assignmentDescription",Value= assignmentToUpdate.assignmentDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("update Assignments set  [assignmentName]=@assignmentName, [isTheAssignmentActive]=@isTheAssignmentActive, [assignmentDescription]=@assignmentDescription where assignmentName=@assignmentName", assignmentParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Delete Assignment
        public int DeleteAssignment(AssignmentsEntity assignmentToDelete)
        {
            SqlParameter[] assignmentParameters =
            {
                new SqlParameter{ParameterName="assignmentName",Value= assignmentToDelete.assignmentName},
                
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("delete from Assignments where assignmentName=@assignmentName", assignmentParameters, "txt");
            return affectedLine;
        }
        #endregion
    }
}
