using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports
{
    public class Calc
    {
        public Calc() 
        { 
            
        }
        public static double toRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }
        public static double Dist (double lat1, double lon1,double lat2, double lon2) 
        {
            var r = 6372.8;
            lat1 = toRadians(lat1);
            lon1 = toRadians(lon1);
            lat2 = toRadians(lat2);
            lon2 = toRadians(lon2);
            var sdlat = Math.Sin((lat2 - lat1) / 2);
            var sdlon = Math.Sin((lon2 - lon1) / 2);
            var q = sdlat * sdlat + Math.Cos(lat1) * Math.Cos(lat2) * sdlon * sdlon;
            var d = 2 * r * Math.Asin(Math.Sqrt(q));
            return d;
        }
    }
}
