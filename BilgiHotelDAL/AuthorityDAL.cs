using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class AuthorityDAL
    {
        #region Get Authority
        public AuthorityEntity GetAuthoritywithAd(string authorityName)
        {
            SqlParameter[] authorityParameters =
            {
                new SqlParameter{ParameterName="authorityName",Value=authorityName},

            };
            SqlDataReader authorityRdr = BilgiHotelHelperSql.MyExecuteReader("select * from Authority where authorityName=@authorityName", authorityParameters, "txt");
            AuthorityEntity myAuthority = new AuthorityEntity();
            while(authorityRdr.Read())
            {
                myAuthority.authorityName = authorityRdr[1].ToString();
                myAuthority.authorityAccessCode = authorityRdr[2].ToString();
                myAuthority.isTheAuthorityActive = (bool)authorityRdr[3];
                myAuthority.authorityDescription = authorityRdr[4].ToString();
            }
            return myAuthority;
        }
        #endregion
        #region Authority Insert
        public int InsertAuthority(AuthorityEntity authorityToInsert)
        {
            SqlParameter[] authorityParameters =
            {
                new SqlParameter{ParameterName="authorityName",Value=authorityToInsert.authorityName},
                new SqlParameter{ParameterName="authorityAccessCode", Value=authorityToInsert.authorityAccessCode},
                new SqlParameter{ParameterName="isTheAuthorityActive",Value=authorityToInsert.isTheAuthorityActive},
                new SqlParameter{ParameterName="authorityDescription",Value=authorityToInsert.authorityDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("insert into Authority ([authorityName],[authorityAccessCode],[isTheAuthorityActive],[authorityDescription]) values (@authorityName,@authorityAccessCode,@isTheAuthorityActive,@authorityDescription", authorityParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Authority Update
        public int UpdateAuthority(AuthorityEntity authorityToUpdate)
        {
            SqlParameter[] authorityParameters =
            {
                new SqlParameter{ParameterName="authorityName",Value=authorityToUpdate.authorityName},
                new SqlParameter{ParameterName="authorityAccessCode", Value=authorityToUpdate.authorityAccessCode},
                new SqlParameter{ParameterName="isTheAuthorityActive",Value=authorityToUpdate.isTheAuthorityActive},
                new SqlParameter{ParameterName="authorityDescription",Value=authorityToUpdate.authorityDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("update Authority set authorityName=@authorityName, authorityAccessCode=@authorityAccessCode, isTheAuthorityActive=@isTheAuthorityActive, authorityDescription=@authorityDescription where authorityName=@authorityName", authorityParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Authority Delete
        public int DeleteAuthority(AuthorityEntity authorityToDelete)
        {
            SqlParameter[] authorityParameters =
            {
                new SqlParameter{ParameterName="authorityName",Value=authorityToDelete.authorityName},
                
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("delete from Authority where authorityName=@authorityName", authorityParameters, "txt");
            return affectedLine;
        }
        #endregion
    }
}
