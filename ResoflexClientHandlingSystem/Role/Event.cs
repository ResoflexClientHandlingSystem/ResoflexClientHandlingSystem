using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Event
    {
        private int visitId;
        private int projectId;
        private String type;
        private String servEngineer;
        private DateTime from;
        private DateTime to;
        private String vehicle;
        private float mileage;

        public Event(int visitId, int projectId, string type, string servEngineer, DateTime from, DateTime to, string vehicle, float mileage)
        {
            this.visitId = visitId;
            this.projectId = projectId;
            this.type = type;
            this.servEngineer = servEngineer;
            this.from = from;
            this.to = to;
            this.vehicle = vehicle;
            this.mileage = mileage;
        }
    }
}
