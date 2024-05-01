using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDev_System.Classes;
using AppDev_System.Forms;
using MySql.Data.MySqlClient;

namespace AppDev_System
{
    public class Multicab
    {
        public int dataBaseId { get; set; }
        public string nameOfDriver { get; set; }
        public string arrival_time { get; set; }
        public DateTime departure_time { get; set; }
        public int seatsTotal { get; set; }
        public int seatsAvailable { get; set; }
        public float earnings { get; set; }
        public DateTime date_day { get; set; }
        public string plateNumber_id { get; set; }
        public DateTime time_dateTime_ {  get; set; }

        public string date_date { get; set; }
        public string date_added_toDataBse { get; set; }
        public DateTime date_queued {  get; set; }
        public string date_queued_string { get; set; }

        

        public bool isIn {  get; set; }
        public string added_to_database { get; set; }
        public List<Booking> tickets { get; set; }


        public Multicab(string plateNumb_id, string nameOfDriver, string arrival_time, int seatsTotal, float earnings) //WITHOUT DEPAPRTURE
        {
            this.seatsAvailable = this.seatsTotal = seatsTotal;
            this.plateNumber_id = plateNumb_id;
            this.nameOfDriver = nameOfDriver;
            this.arrival_time = arrival_time;
            this.earnings = earnings;
            this.tickets = new List<Booking>();
            this.isIn = false;
            this.date_day = DateTime.Now;

            CultureInfo culture = new CultureInfo("en-US");
            this.time_dateTime_ = Convert.ToDateTime(this.arrival_time, culture);

            this.date_added_toDataBse = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt");
        }
        public Multicab(string plateNumb_id, string nameOfDriver, string arrival_time) //FOR GRID
        {
            this.plateNumber_id = plateNumb_id;
            this.nameOfDriver = nameOfDriver;
            this.arrival_time = arrival_time;
            this.tickets = new List<Booking>();
            this.isIn = false;
            this.date_day = DateTime.Now;

            this.date_added_toDataBse = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt");
        }
        public void dataBaseId_(int id)
        {
            this.dataBaseId = id;
        }
        public void setDay_Date(string date)
        {
            this.date_date = date;
        }

        public Multicab(string plateNumb_id, string nameOfDriver, string arrival_time, DateTime departure_time, int seatsTotal, float earnings) //WITH DEPAPRTURE
        {
            this.seatsAvailable = this.seatsTotal = seatsTotal;
            this.plateNumber_id = plateNumb_id;
            this.nameOfDriver = nameOfDriver;
            this.arrival_time = arrival_time;
            this.earnings = earnings;
            this.tickets = new List<Booking>();
            this.isIn = false;
            this.date_day = DateTime.Now;

            CultureInfo culture = new CultureInfo("en-US");
            this.time_dateTime_ = Convert.ToDateTime(this.arrival_time, culture);

            this.date_added_toDataBse = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt");
        }
        
        /*

        public Boolean addPassenger(Booking ticket)
        {
            bool res = false;

            if (this.seatsAvailable > 0)
            { 
                this.tickets.Add(ticket);
                this.seatsAvailable--;
            }
            else
            {
                MessageBox.Show("No More Available Seats");
            }

            return res;
        }

        public void removeAllTickets()
        {
            this.tickets.Clear();
        }
        */

        public Boolean createMulticab()
        {
            bool res = false;

            try 
            {
                Query q = new Query();
                res = q.insertMulticab(this);
            }
            catch 
            {
                return res;
            }

            return res;
        }

        public Boolean editMulticab()
        {
            bool res = false;

            Query query = new Query();
            query.editMulticab(this);

            return res;
        }

        public override string ToString()
        {
            /*
            return ("muf = " + this.dataBaseId +
                          "\nname_of_driver = " + this.nameOfDriver +
                          "\ndateTime_of_arrival = " + this.arrival_time +
                          "\ndateTime_of_departure = " + this.departure_time+
                          "\nseats = " + this.seatsTotal+
                          "\nseats_available = " + this.seatsAvailable +
                          "\nearnings = " + this.earnings +
                          "\ndate_day = " + this.date_day.ToString("yyyy-MM-dd") +
                          "\nmulticab_plate = " + this.plateNumber_id+
                          "\nisIn = " + this.isIn + "\n");*/

            return this.nameOfDriver;
        }
    }
}
