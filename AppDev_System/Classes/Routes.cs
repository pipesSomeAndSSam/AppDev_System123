using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev_System
{
    public class Routes
    {

        public string barangayName {  get; set; }
        public float distance { get; set; }

        public float regularFareNew { get; set; }
        public float specialFareNew { get; set; }
        public float regularFareOld { get; set; }
        public float specialFareOld { get; set; }

        public Routes(string barangay, float distance, float regularFareNew, float specialFareNew) 
        {
            this.barangayName = barangay;
            this.distance = distance;
            this.regularFareNew = regularFareNew;
            this.specialFareNew = specialFareNew;
        }

        public Boolean createRoute()
        {
            bool res = false;
            Query q = new Query();
            try 
            {
                res = q.insertRoute( this.barangayName , this.distance, this.regularFareNew, this.specialFareNew);
            }
            catch (Exception ex) 
            {
                return res;
            }
            return res;
        }
    }
}
