using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Attendance
    {
        private int attendanceId;
        private int staffId;
        private DateTime date;
        private Boolean halfDay;
        private Boolean overTime;
        private float otHours;

        public Attendance()
        {
        }

        public Attendance(int attendanceId, int staffId, DateTime date, bool halfDay, bool overTime, float otHours)
        {
            this.attendanceId = attendanceId;
            this.staffId = staffId;
            this.date = date;
            this.halfDay = halfDay;
            this.overTime = overTime;
            this.otHours = otHours;
        }
    }
}
