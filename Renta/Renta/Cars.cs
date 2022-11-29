using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenia
{
    public class AllCars
    {
        public AllCars(int id, string marka, string segment, string fuel, int perHR, string status)
        {
            Id = id;
            Marka = marka;
            Segment = segment;
            Fuel = fuel;
            PerHR = perHR;
            Status = status;
        }
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Segment { get; set; }
        public string Fuel { get; set; }
        public int PerHR { get; set; }
        public string Status { get; set; }
        public string Price
        {
            get { return $"{PerHR} PLN"; }
        }
    }
}
