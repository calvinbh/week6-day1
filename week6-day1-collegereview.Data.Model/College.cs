using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_day1_collegereview.Data.Model
{
    public class College
    {
        public int CollegeId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Rank { get; set; }
        public float Tuition { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }
}
