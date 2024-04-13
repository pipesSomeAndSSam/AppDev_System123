using System;
using System.Collections.Generic;
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
        public DateTime arrival_time { get; set; }
        public DateTime departure_time { get; set; }
        public int seatsTotal { get; set; }
        public int seatsAvailable { get; set; }
        public float earnings { get; set; }
        public DateTime date_day { get; set; }
        public string plateNumber_id { get; set; }




        public bool isIn {  get; set; }
        public List<Booking> tickets { get; set; }

        public Multicab(string plateNumb_id, string nameOfDriver, DateTime arrival_time, int seatsTotal, float earnings) //WITHOUT DEPAPRTURE
        {
            this.seatsAvailable = this.seatsTotal = seatsTotal;
            this.plateNumber_id = plateNumb_id;
            this.nameOfDriver = nameOfDriver;
            this.arrival_time = arrival_time;
            this.earnings = earnings;
            this.tickets = new List<Booking>();
            this.isIn = true;
            this.date_day = DateTime.Now;
        }

        public Multicab(string plateNumb_id, string nameOfDriver, DateTime arrival_time, DateTime departure_time, int seatsTotal, float earnings) //WITH DEPAPRTURE
        {
            this.seatsAvailable = this.seatsTotal = seatsTotal;
            this.plateNumber_id = plateNumb_id;
            this.nameOfDriver = nameOfDriver;
            this.arrival_time = arrival_time;
            this.earnings = earnings;
            this.tickets = new List<Booking>();
            this.isIn = true;
            this.date_day = DateTime.Now;
        }


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
    }
}
