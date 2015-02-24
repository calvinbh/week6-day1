using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_day1_collegereview.Data.Model
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Reviewer { get; set; }
        public int Stars { get; set; }
        public string ReviewText { get; set; }
        public int CollegeId { get; set; }
        public virtual College College { get; set; }
    }
}
