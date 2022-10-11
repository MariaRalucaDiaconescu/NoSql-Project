﻿using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace Logic
{
    class TicketEscalation : TicketsService
    {
        // Konrad Figura

        /// <summary>
        /// Escalates the ticket to higher level.
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns></returns>
        public StatusStruct EscalateTicket(Ticket ticket)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.Id);
                var update = Builders<BsonDocument>.Update.Set("escalationLevel", (int)ticket.EscalationLevel + 1);
                ticketsdb.Update(filter, update);
                return new StatusStruct(0);
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.WriteError(ex);
                return new StatusStruct(1, "Unable to escalate the ticket. Try again later.");
            }
        }

        /// <summary>
        /// Checks if ticket can be escalated.
        /// </summary>
        /// <param name="ticket">Ticket to chekc if can be escalated.</param>
        public bool IsTicketEscalatable(Ticket ticket)
        {
            return ticket.EscalationLevel < Enum.GetValues(typeof(EmployeeType)).Length - 2;
        }
    }
}
