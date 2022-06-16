using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_and_Setters
{
    class Movies
    {
        public string duration;
        public string producer;
        private string rating;

        public Movies(string aDuration, string aProducer, string aRating)
        {
            duration = aDuration;
            producer = aProducer;
            Rating = aRating;
        }

            public string Rating
        { 
            get
            {
                return rating;
            }
            set
            {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
        
    }
}
