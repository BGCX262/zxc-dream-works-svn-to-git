using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

using DreamWroks.CXZ.DataModel.Module.SystemInfo.TableEntity;
using DreamWroks.CXZ.DataAccess.Base;

namespace DreamWroks.CXZ.DataAccess.SystemInfo
{
    public class DemoDAL
    {
        /// <summary>
        /// 根据用户ID获得用户实体
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public User GetEntityByID(int userid)
        {
            string sql = string.Format("select UserID, UserName, Sex, Age, Birthplace from Tab_Sys_User where UserID = {0}", userid);
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(sql);
            DataSet ds = db.ExecuteDataSet(cmd);
            
            if (ds == null) return null;
            if (ds.Tables.Count <= 0) return null;
            if (ds.Tables[0] == null) return null;
            if (ds.Tables[0].Rows.Count <= 0) return null;
            DataRow dr = ds.Tables[0].Rows[0];
            User user = new User();

            user.UserID = (int)dr["UserID"];
            user.UserName = dr["UserName"].ToString();
            user.Sex = (bool)dr["Sex"];
            user.Age = (int)dr["Age"];
            user.Birthplace = dr["Birthplace"].ToString();
            return user;
        }
    }
}
