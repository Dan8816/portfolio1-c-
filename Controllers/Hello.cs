using System;
using Microsoft.AspNetCore.Mvc;
namespace example.Controllers     //be sure to use your own project's namespace!
{
    public class Hello : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)The [Route] decorator accepts a string argument that represents the route string associated with a given method. For example, [Route("index")] matches the URL localhost:5000/index. They do NOT have leading slashes.
        public IActionResult Index()
        {
            //return View();
            //or
            ViewBag.Example = "About Me";
            return View("Index");
            //Both of these returns render same view, only one is needed
        }

        [HttpGet]
        [Route("projects")]
        public IActionResult Projects()//string Projects(string name)
        {
            ViewBag.Example = "Here are some of my projects!";
            return View("Projects");
            //return "These are my projects";
        }

        [HttpGet]
        [Route("contacts")]
        public IActionResult Contacts()//string Contacts(string name)
        {
            ViewBag.Example = "Contact Me!";
            return View("Contacts");
            //return "These are my contactss";
        }

        [HttpGet]
        [Route("firstMethod")]
        public IActionResult firstMethod()
        {
            System.Console.WriteLine("hit the firstMethod route");
            //Will redirect to the "firstOtherMethod"
            return RedirectToAction("firstOtherMethod");
        }
        [HttpGet]
        [Route("firstOtherMethod")]
        public IActionResult firstOtherMethod()
        {
            System.Console.WriteLine("hit the firstOtherMethod route");
            return View("Index");
        }

        //public IActionResult SecondMethod()
        //{
        // The anonymous object consists of keys and values
        // The keys should match the parameter names of the method being redirected to
            //return RedirectToAction("SecondOtherMethod", new { Food = "sandwiches", Quantity= 5 });
        //}
        //[HttpGet]
        //[Route("other/{Food}/{Quantity}")]
        //public IActionResult SecondOtherMethod(string Food, int Quantity)
        //{
            //Console.WriteLine($"I ate {Quantity} {Food}.");
            // Writes "I ate 5 sandwiches."
        //}
    }
}