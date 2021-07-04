using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_nunit_spec.models
{
    public class TravelData
    {
        public List<String> destinations;
        //= new List<string> { "Bali"};
        public DateTime departureDate;
        public DateTime returnDate;
        public List<int> ages;


        public static TravelData getSample()
        {
            var data = new TravelData();
            data.ages = new List<int> { 22, 11 };
            data.destinations = new List<String> { "bali" };
            data.

            return data;
        }

    }



}
