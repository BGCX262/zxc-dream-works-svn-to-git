using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DreamWroks.CXZ.DataModel.Module.SystemInfo.TableEntity
{
    public class User
    {
        public long UserID { get; set; }
        public string UserName { get; set; }
        public bool Sex { get; set; }
        public int Age { get; set; }
        public string Birthplace { get; set; }
    }
}
