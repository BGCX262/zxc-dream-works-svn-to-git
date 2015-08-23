using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DreamWroks.CXZ.DataModel.Module.SystemInfo.TableEntity;
using DreamWroks.CXZ.BusinessLogic.Module.SystemInfo;
using System.Text;

namespace DreamWroks.CXZ.WebPage.Module.SystemInfo.UnitTest
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = DemoBLL.GetEntityByID<User>(1);
            StringBuilder sb = new StringBuilder();
            sb.Append(user.UserID);
            sb.Append("\t");
            sb.Append(user.UserName);
            sb.Append("\t");
            sb.Append(user.Sex?"男":"女");
            sb.Append("\t");
            sb.Append(user.Age);
            sb.Append("\t");
            sb.Append(user.Birthplace);
            sb.Append("\t");
            Response.Write(sb.ToString());
        }
    }
}
