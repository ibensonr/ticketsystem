using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class TicketEntity
    {
        public int id { get; set; }
        public Nullable<int> deptid { get; set; }
        public Nullable<int> ticketstatusid { get; set; }
        public string ticketname { get; set; }
        public string ticketdesc { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<int> createdby { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<int> modifiedby { get; set; }
        public Nullable<System.DateTime> modifiedon { get; set; }
        public bool deleted { get; set; }
    }
}
