using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }
        public string PlaceName { get; set; }
        public int PlaceNumber { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }


    }
}
