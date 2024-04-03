using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev_System
{
    public class Routes
    {

        public string barangay {  get; set; }
        public int multicab_id { get; set; }

        public int cost { get; set; }

        public Routes(string barangay, int multicab_id, int cost) 
        {
            this.barangay = barangay;
            this.multicab_id = multicab_id;
            this.cost = cost;
        }

        public Boolean createRoute()
        {
            bool res = false;
            Query q = new Query();
            res = q.insertRoute(this.barangay, this.multicab_id, this.cost);
            return res;
        }
    }
}
