using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    public class Event
    {
        private int eventId;
        private Project eventProject;
        private EventType type;
        private Staff servEngineer;
        private DateTime from;
        private DateTime to;
        private string vehicleDetails;
        private float mileage;
        private string feedback;
        private string other;
        private string todoList;
        private string resource;
        private string checklist;
        private string travelMode;
        private string accommodationMode;
        private string meals;
        private int schNo;

        public int EventId { get => eventId; set => eventId = value; }
        public DateTime From { get => from; set => from = value; }
        public DateTime To { get => to; set => to = value; }
        public string VehicleDetails { get => vehicleDetails; set => vehicleDetails = value; }
        public float Mileage { get => mileage; set => mileage = value; }
        public string Feedback { get => feedback; set => feedback = value; }
        public string Other { get => other; set => other = value; }
        public string TodoList { get => todoList; set => todoList = value; }
        public string Resource { get => resource; set => resource = value; }
        public string Checklist { get => checklist; set => checklist = value; }
        public string TravelMode { get => travelMode; set => travelMode = value; }
        public string AccommodationMode { get => accommodationMode; set => accommodationMode = value; }
        public string Meals { get => meals; set => meals = value; }
        public int SchNo { get => schNo; set => schNo = value; }
        internal Project EventProject { get => eventProject; set => eventProject = value; }
        internal EventType Type { get => type; set => type = value; }
        internal Staff ServEngineer { get => servEngineer; set => servEngineer = value; }

        public Event(int  eventID)
        {
            this.EventId = eventID;
        }

        public Event(int eventId, Project eventProject, EventType type, Staff servEngineer, DateTime from, DateTime to, string vehicleDetails, float mileage, string feedback, string other, string todoList, string resource, string checklist, string travelMode, string accommodationMode, string meals, int schNo)
        {
            this.eventId = eventId;
            this.eventProject = eventProject;
            this.type = type;
            this.servEngineer = servEngineer;
            this.from = from;
            this.to = to;
            this.vehicleDetails = vehicleDetails;
            this.mileage = mileage;
            this.feedback = feedback;
            this.other = other;
            this.todoList = todoList;
            this.resource = resource;
            this.checklist = checklist;
            this.travelMode = travelMode;
            this.accommodationMode = accommodationMode;
            this.meals = meals;
            this.schNo = schNo;
        }
    }
}
