using Microsoft.AspNetCore.Mvc;
namespace example.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)The [Route] decorator accepts a string argument that represents the route string associated with a given method. For example, [Route("index")] matches the URL localhost:5000/index. They do NOT have leading slashes.
        public string Index()
        {
            return "This is my index!";
        }

        [HttpGet]
        [Route("projects")]
        public string Projects(string name)
        {
            return "These are my projects";
        }

        [HttpGet]
        [Route("contacts")]
        public string Contacts(string name)
        {
            return "These are my contactss";
        }
    }
}