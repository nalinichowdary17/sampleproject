using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcapp.Controllers
{
    public class firstController : Controller
    {
        // GET: first
        public string Index()
        {
            return "hello mvc controllers";
        }
    }
}