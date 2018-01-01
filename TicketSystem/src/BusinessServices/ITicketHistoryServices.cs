using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    interface ITicketHistoryServices
    {
        TicketHistoryEntity GetTicketHistoryById(int ticketId);
        IEnumerable<TicketHistoryEntity> GetAllTicketHistory();
        int CreateTicketHistory(TicketHistoryEntity ticketEntity);
        bool UpdateTicketHistory(int ticketId, TicketHistoryEntity ticketEntity);
        bool DeleteTicketHistory(int ticketId);
    }
}
