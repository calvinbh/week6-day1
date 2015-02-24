using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week6_day1_collegereview.Models;

namespace week6_day1_collegereview.Adapters.Interface
{
    public interface ICollegeAdapter
    {
        List<CollegeViewModel> GetAllColleges();
    }
}
