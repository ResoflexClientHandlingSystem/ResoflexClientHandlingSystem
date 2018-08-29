using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    public class Schedule
    {
        private int scheduleId;
        private Project projectOfSchedule;
        private EventType type;
        private ArrayList servEngineer;
        private DateTime from;
        private DateTime to;
        private string vehicle;
        private float mileage;
        private string todoList;
        private string resource;
        private string checklist;
        private string travelMode;
        private string accommodationMode;
        private string meals;
        private string logs;

        public Schedule()
        {

        }
        public Schedule(int scheduleId)
        {
            this.scheduleId = scheduleId;
        }
        public Schedule(int scheduleId, Project projectOfSchedule, EventType type, ArrayList servEngineer, DateTime from, DateTime to, string vehicle, float mileage, string todoList, string resource, string checklist, string travelMode, string accommodationMode, string meals, string logs)
        {
            this.ScheduleId = scheduleId;
            this.ProjectOfSchedule = projectOfSchedule;
            this.Type = type;
            this.ServEngineer = servEngineer;
            this.From = from;
            this.To = to;
            this.Vehicle = vehicle;
            this.Mileage = mileage;
            this.TodoList = todoList;
            this.Resource = resource;
            this.Checklist = checklist;
            this.TravelMode = travelMode;
            this.AccommodationMode = accommodationMode;
            this.Meals = meals;
            this.Logs = logs;
        }

        public int ScheduleId { get => scheduleId; set => scheduleId = value; }
        public Project ProjectOfSchedule { get => projectOfSchedule; set => projectOfSchedule = value; }
        public EventType Type { get => type; set => type = value; }
        public ArrayList ServEngineer { get => servEngineer; set => servEngineer = value; }
        public DateTime From { get => from; set => from = value; }
        public DateTime To { get => to; set => to = value; }
        public string Vehicle { get => vehicle; set => vehicle = value; }
        public float Mileage { get => mileage; set => mileage = value; }
        public string TodoList { get => todoList; set => todoList = value; }
        public string Resource { get => resource; set => resource = value; }
        public string Checklist { get => checklist; set => checklist = value; }
        public string TravelMode { get => travelMode; set => travelMode = value; }
        public string AccommodationMode { get => accommodationMode; set => accommodationMode = value; }
        public string Meals { get => meals; set => meals = value; }
        public string Logs { get => logs; set => logs = value; }
        public object Text { get; internal set; }
    }
}
