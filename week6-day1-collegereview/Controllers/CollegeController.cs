using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using week6_day1_collegereview.Adapters.Adapter;
using week6_day1_collegereview.Adapters.Interface;
using week6_day1_collegereview.Data.Model;
using week6_day1_collegereview.Models;

namespace week6_day1_collegereview.Controllers
{
       public class CollegeController : ApiController
       {
           private ICollegeAdapter _adapter;
           public CollegeController()
           {
               _adapter = new CollegeAdapter();
           }
           public IHttpActionResult Get()
           {
              List<CollegeViewModel> model = _adapter.GetAllColleges();           
               return Ok(model);
           }


       } 
}
