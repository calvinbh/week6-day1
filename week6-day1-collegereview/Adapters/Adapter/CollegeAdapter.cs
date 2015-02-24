using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using week6_day1_collegereview.Adapters.Interface;
using week6_day1_collegereview.Data;
using week6_day1_collegereview.Models;

namespace week6_day1_collegereview.Adapters.Adapter
{
    public class CollegeAdapter : ICollegeAdapter
    {
        public List<CollegeViewModel> GetAllColleges()
        {
            List<CollegeViewModel> model;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {

                model = db.Colleges.Select(x => new CollegeViewModel()
                {
                    CollegeId = x.CollegeId,
                    Name = x.Name,
                    Location = x.Location,
                    Rank = x.Rank,
                    Tuition = x.Tuition
                }).ToList();
            }
        }
    }
}
    
