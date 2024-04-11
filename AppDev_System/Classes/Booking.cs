using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDev_System.Classes
{
    public class Booking
    {
        Query q = new Query();
        public string passenger_name { get; set; }
        public string destination {  get; set; }
        public float amount { get; set; }
        public DateTime date_time { get; set; }
        public DateTime date { get; set; }

        public Booking( string passenger_name, float amount, string destination)
        {
            this.passenger_name = passenger_name;
            this.amount = amount;
            this.destination = destination;

            this.date_time = DateTime.Now;
            this.date = DateTime.Now;
        }

        public Booking(string passenger_name, float amount, string destination, DateTime date_time_input, DateTime date)
        {
            this.passenger_name = passenger_name;
            this.amount = amount;
            this.destination = destination;

            this.date_time = date_time_input;
            this.date = date;
        }

        public Boolean editTicket(int rowId)
        {
            bool res = false;

            Query q = new Query();
            try
            {
                res = q.editTicket(this, rowId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("mali jjjuuuuudd ka");
                return res;
            }

            return res;
        }

        public void createBooking()
        {
            //pag query
            
            try
            {
                if (this.destination != "NULL")
                {
                    q.insertBooking(this);
                }
                else
                {
                    MessageBox.Show("null destination");
                }
                
            }
            catch
            {
                MessageBox.Show("mali ang pagka insert");
            }
        }
    }
}
