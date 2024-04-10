﻿using System;
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

        public Booking( string passenger_name, float amount, string destination)
        {
            this.passenger_name = passenger_name;
            this.amount = amount;
            this.destination = destination;
        }

        public void createBooking()
        {
            //pag query
            
            try
            {
                q.insertBooking(this);
            }
            catch
            {
                MessageBox.Show("mali ang pagka insert");
            }
        }
    }
}