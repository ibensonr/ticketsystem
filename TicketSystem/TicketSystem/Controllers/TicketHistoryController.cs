using BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TicketSystem.Controllers
{
    public class TicketHistoryController : ApiController
    {
        private readonly ITicketServices _ticketServices;

        public TicketHistoryController()
        {
            _ticketServices = new TicketServices();
        }
        // GET: api/TicketHistory
        public HttpResponseMessage Get()
        {
            var tickets = _ticketServices.GetTicketHistory();
            if (tickets != null)
            {
                var ticketEntities = tickets; // as List<TicketEntity> ?? tickets.ToList();
                if (ticketEntities != null)
                    return Request.CreateResponse(HttpStatusCode.OK, ticketEntities);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Tickets not found");
        }

        // GET: api/TicketHistory/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TicketHistory
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TicketHistory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TicketHistory/5
        public void Delete(int id)
        {
        }
    }
}
