using Microsoft.AspNetCore.Mvc;

namespace mydemoproj.Controllers
{
    public class FirstController : Controller
    {
       public string GetName()
        {
            return "This is my first method ";
        }

        [Route("address/{city}/{country}")]  // this way of calling is route data
        public string GetAddress(string city,string country)
        {
            //(string city, string country) // this way of calling is  model binder
            return $"{ city} - {country}";
        }
    }
}
