using _9_dars.Api.Models;
using _9dars.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9dars.Services
{
    public class EventService
    {
        public List<Event> events;
        public EventService()
        {
            events = new List<Event>();
        }


        public Event AddEvent(Event newEvent)
        {
            newEvent.Id = Guid.NewGuid();
            events.Add(newEvent);
            return newEvent;
        }


        public Event GetEventById(Guid Id)
        {
            foreach (var newEvent in events)
            {
                if (newEvent.Id == Id)
                {
                    return newEvent;
                }
            }

            return null;
        }


        public bool DeleteEvent(Guid Id)
        {
            var eventsFromDb = GetEventById(Id);
            if (eventsFromDb is null)
            {
                return false;
            }

            events.Remove(eventsFromDb);
            return true;
        }

        public bool UpdateEvents(Event newEvent)
        {
            var eventsFromDb = GetEventById(newEvent.Id);
            if (eventsFromDb is null)
            {
                return false;
            }
            var index = events.IndexOf(eventsFromDb);
            events[index] = newEvent;
            return true;
        }


        public List<Event> GetAllEvents()
        {
            return events;
        }


    }


}


