using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DreamWroks.CXZ.DataAccess.SystemInfo;
using DreamWroks.CXZ.DataModel.Module.SystemInfo.TableEntity;

namespace DreamWroks.CXZ.BusinessLogic.Module.SystemInfo
{
    public static class DemoBLL
    {
        public static User GetEntityByID<T>(int userid)
        {
            return (new DemoDAL()).GetEntityByID(userid);
        }
    }
}
