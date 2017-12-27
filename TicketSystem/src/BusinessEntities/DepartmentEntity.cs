using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class DepartmentEntity
    {
        public int id { get; set; }
        public string deptname { get; set; }
        public string deptdesc { get; set; }
        public Nullable<int> createdby { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<int> modifiedby { get; set; }
        public Nullable<System.DateTime> modifiedon { get; set; }
        public bool deleted { get; set; }
    }
}
