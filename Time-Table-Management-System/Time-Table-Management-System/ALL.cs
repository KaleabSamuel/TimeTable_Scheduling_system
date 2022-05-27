using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System
{
    public class Room
    {
        string roomName;
        int capacity;
        Room(string roomName, int capacity)
        {
            this.roomName = roomName;
            this.capacity = capacity;
        }
        public string Name
        {
            get { return roomName; }
            set { roomName = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public static Room[] getRooms()
        {
            Room[] r = null;
            DAL d = new DAL();
            DataTable dt = d.getRooms();
            if (dt.Rows.Count > 0)
            {
                string name;
                int capacity = 70, i = 0;
                r = new Room[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    name = row["Rname"].ToString();
                    if (!(row["capacity"] is DBNull))
                        capacity = (int)row["capacity"];
                    r[i++] = new Room(name, capacity);
                }
            }
            return r;
        }

    }

    public class BatchCourseTeacher
    {
        string cName, cCode, bName;
        int studentNo, tid, type, times;
        public BatchCourseTeacher(string Cname, string CNumber, string Bname, int studentNo, int tid, int type, int times)
        {
            this.cName = Cname;
            this.cCode = CNumber;
            this.bName = Bname;
            this.studentNo = studentNo;
            this.tid = tid;
            this.type = type;
            this.times = times;
        }

        public string CName
        {
            get { return cName; }
            set { cName = value; }
        }
        public string CCode
        {
            get { return cCode; }
            set { cCode = value; }
        }
        public string BName
        {
            get { return bName; }
            set { bName = value; }
        }
        public int StudentNo
        {
            get { return studentNo; }
            set { studentNo = value; }
        }
        public int Tid
        {
            get { return tid; }
            set { tid = value; }
        }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Times
        {
            get { return times; }
            set { times = value; }
        }
        public static int getLength(BatchCourseTeacher[] a)
        {
            int length = 0;
            for (int i = 0; i < a.Length; i++)
                length += a[i].times;
            return length;
        }
        public static BatchCourseTeacher[] getBatchCourses()
        {
            BatchCourseTeacher[] r = null;
            DAL d = new DAL();
            DataTable dt = d.getBatchCourses();
            if (dt.Rows.Count > 0)
            {
                string cname, cnumber, bname;
                int students = 0, i = 0, tid,type,times;
                r = new BatchCourseTeacher[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    cname = row["cname"].ToString();
                    cnumber = row["cnumber"].ToString();
                    bname = row["bname"].ToString();
                    if (!(row["students"] is DBNull))
                        students = (int)row["students"];
                    tid = (int)row["tid"];
                    type = (int)row["type"];
                    times = (int)row["times"];

                    r[i++] = new BatchCourseTeacher(cname, cnumber, bname, students, tid,type,times);
                }
            }
            return r;
        }

    }

    public class CourseTeacher
    {
        string cName, cCode, tName;
        int tid;
        CourseTeacher(string Cname, string CNumber, string Tname, int tid)
        {
            this.cName = Cname;
            this.cCode = CNumber;
            this.tName = Tname;
            this.tid = tid;
        }

        public string CName
        {
            get { return cName; }
            set { cName = value; }
        }
        public string CCode
        {
            get { return cCode; }
            set { cCode = value; }
        }
        public string BName
        {
            get { return tName; }
            set { tName = value; }
        }
        public int Tid
        {
            get { return tid; }
            set { tid = value; }
        }

        public static CourseTeacher[] unavailable()
        {
            CourseTeacher[] r = null;
            DAL d = new DAL();
            DataTable dt = d.getCourseTeacher();
            if (dt.Rows.Count > 0)
            {
                string cname, cnumber, tname;
                int tid, i = 0;
                r = new CourseTeacher[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    cname = row["cname"].ToString();
                    cnumber = row["cnumber"].ToString();
                    tname = row["tname"].ToString();
                    tid = (int)row["tid"];
                    r[i++] = new CourseTeacher(cname, cnumber, tname, tid);
                }
            }
            return r;
        }
    }

    public class Class
    {
        string room, course, batch, schedule;
        int tid;
        public Class(string course, string batch, string schedule, string room, int tid)
        {
            this.room = room;
            this.course = course;
            this.batch = batch;
            this.schedule = schedule;
            this.tid = tid;
        }
        public string Room
        {
            get { return room; }
            set { room = value; }
        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }
        public string Batch
        {
            get { return batch; }
            set { batch = value; }
        }
        public string Schedule
        {
            get { return schedule; }
            set { schedule = value; }
        }
        public int Tid
        {
            get { return tid; }
            set { tid = value; }
        }
    }

    public class DayTime
    {
        int did, tid;
        DayTime(int did, int tid)
        {
            this.did = did;
            this.tid = tid;
        }
        public int DayID
        {
            get { return did; }
            set { did = value; }
        }
        public int TimeID
        {
            get { return tid; }
            set { tid = value; }
        }

        public static DayTime[] getDayTime()
        {
            DayTime[] r = null;
            DAL d = new DAL();
            DataTable dt = d.getDayTime();
            if (dt.Rows.Count > 0)
            {
                int tid,did, i = 0;
                r = new DayTime[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    tid = (int)row["tid"];
                    did = (int)row["did"];
                    r[i++] = new DayTime(did,tid);
                }
            }
            return r;
        }

    }

    public class Unavailable
    {
        int tid, did, timeID;
        Unavailable(int tid, int did, int timeID)
        {
            this.tid = tid;
            this.did = did;
            this.timeID = timeID;
        }
        public int DayID
        {
            get { return did; }
            set { did = value; }
        }
        public int TeacherID
        {
            get { return tid; }
            set { tid = value; }
        }
        public int TimeID
        {
            get { return timeID; }
            set { timeID = value; }
        }
        public static Unavailable[] getUnavailable()
        {
            Unavailable[] r = null;
            DAL d = new DAL();
            DataTable dt = d.getUnavailable();
            if (dt.Rows.Count > 0)
            {
                int tid, did,timeID, i = 0;
                r = new Unavailable[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    tid = (int)row["tid"];
                    did = (int)row["did"];
                    timeID = (int)row["time_id"];
                    r[i++] = new Unavailable(tid, did,timeID);
                }
            }
            return r;
        }
    }

    public class Schedule
    {
        List<Class> classes;
        int contradiction;
        double fitness;
        public Schedule()
        {
            classes = new List<Class>();
            contradiction = 0;
            fitness = 0;
        }
        public Schedule(Schedule s)
        {
            classes = new List<Class>();
            for (int i = 0; i < s.Classes.Count; i++)
                classes.Add(s.Classes[i]);
            contradiction = s.contradiction;
            fitness = s.fitness;
        }
        public int Contradiction
        {
            get { return contradiction; }
            set { contradiction = value; }
        }
        public double Fitness
        {
            get { return fitness; }
            set { fitness = value; }
        }
        public List<Class> Classes
        {
            get { return classes; }
            set { classes = value; }
        }

        public void setClass(int i, Class c)
        {
            classes[i] = c;
        }

        public Class getClass(int i)
        {
            return classes[i];
        }
    }

}
