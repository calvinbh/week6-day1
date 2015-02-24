using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week6_day1_collegereview.Models
{
    public class CollegeViewModel
    {
        public int CollegeId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Rank { get; set; }
        public float Tuition { get; set; }
    }
}