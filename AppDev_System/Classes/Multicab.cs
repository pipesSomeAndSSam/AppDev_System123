using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppDev_System
{
    public class Multicab
    {
        public string multicabNumber {  get; set; }
        public int seats { get; set; }

        public int seatsAvailable { get; set; }

        public Routes routes;

        public Multicab(string multicabNumber, int seats, int seatsAvailable, string barangay, int multicab_id, int cost) 
        {
            this.multicabNumber = multicabNumber;
            this.seats = seats;
            if(seatsAvailable >  seats )
            {
                MessageBox.Show("Error exceeds seats limit");
            }
            else
            {
                this.seatsAvailable = seatsAvailable;
            }
            routes = new Routes(barangay, multicab_id, cost);
        }
    }
}
